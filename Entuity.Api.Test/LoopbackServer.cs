using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Entuity.Api.Test;

internal sealed class LoopbackServer : IDisposable
{
	private readonly TcpListener _listener = new(IPAddress.Loopback, 0);
	private readonly CancellationTokenSource _stop = new();
	private readonly Func<string, (int Status, string Body)> _respond;
	private readonly Task _serving;
	private readonly List<string> _requests = [];

	public LoopbackServer(Func<string, (int Status, string Body)> respond)
	{
		_respond = respond;
		_listener.Start();
		_serving = Task.Run(ServeAsync);
	}

	public string BaseUrl => $"http://{IPAddress.Loopback}:{((IPEndPoint)_listener.LocalEndpoint).Port}";

	public IReadOnlyList<string> Requests
	{
		get
		{
			lock (_requests)
			{
				return [.. _requests];
			}
		}
	}

	public EntuityClientOptions Options(Action<EntuityClientOptions>? configure = null)
	{
		var options = new EntuityClientOptions { Url = BaseUrl, Username = "user", Password = "password" };
		configure?.Invoke(options);
		return options;
	}

	public void Dispose()
	{
		_stop.Cancel();
		_listener.Stop();
		_serving.GetAwaiter().GetResult();
		_stop.Dispose();
	}

	private async Task ServeAsync()
	{
		try
		{
			while (!_stop.IsCancellationRequested)
			{
				using var tcp = await _listener.AcceptTcpClientAsync(_stop.Token);
				await HandleAsync(tcp);
			}
		}
		catch (Exception ex) when (ex is OperationCanceledException or ObjectDisposedException or SocketException or IOException)
		{
			// Listener stopped
		}
	}

	private async Task HandleAsync(TcpClient tcp)
	{
		var stream = tcp.GetStream();
		var buffer = new byte[8192];
		var received = new StringBuilder();
		while (true)
		{
			var read = await stream.ReadAsync(buffer, _stop.Token);
			received.Append(Encoding.UTF8.GetString(buffer, 0, read));
			var text = received.ToString();
			var headerEnd = text.IndexOf("\r\n\r\n", StringComparison.Ordinal);
			if (read == 0 || (headerEnd >= 0 && text.Length - headerEnd - 4 >= ContentLength(text)))
			{
				break;
			}
		}

		var request = received.ToString();
		lock (_requests)
		{
			_requests.Add(request);
		}

		var (status, body) = _respond(request);
		var bytes = Encoding.UTF8.GetBytes(body);
		var head = $"HTTP/1.1 {status} X\r\nContent-Type: application/json\r\nContent-Length: {bytes.Length}\r\nConnection: close\r\n\r\n";
		await stream.WriteAsync(Encoding.UTF8.GetBytes(head), _stop.Token);
		await stream.WriteAsync(bytes, _stop.Token);
	}

	private static int ContentLength(string text)
	{
		const string header = "Content-Length:";
		var index = text.IndexOf(header, StringComparison.OrdinalIgnoreCase);
		if (index < 0)
		{
			return 0;
		}

		var end = text.IndexOf("\r\n", index, StringComparison.Ordinal);
		return int.Parse(text[(index + header.Length)..end].Trim(), CultureInfo.InvariantCulture);
	}
}
