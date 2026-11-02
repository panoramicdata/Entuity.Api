using AwesomeAssertions;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Entuity.Api.Test;

public sealed class ReadOnlyOptionTests : IDisposable
{
	private readonly TcpListener _listener = new(IPAddress.Loopback, 0);
	private readonly List<string> _requests = [];
	private readonly CancellationTokenSource _stop = new();

	public ReadOnlyOptionTests()
	{
		_listener.Start();
		_ = Task.Run(ServeAsync);
	}

	private static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	private string BaseUrl => $"http://127.0.0.1:{((IPEndPoint)_listener.LocalEndpoint).Port}";

	private EntuityClientOptions CreateOptions(bool isReadOnly) => new()
	{
		Url = BaseUrl,
		Username = "user",
		Password = "password",
		IsReadOnly = isReadOnly
	};

	[Fact]
	public void IsReadOnly_DefaultsToFalse()
		=> CreateOptions(isReadOnly: false).IsReadOnly.Should().BeFalse();

	[Theory]
	[InlineData("POST")]
	[InlineData("PUT")]
	[InlineData("DELETE")]
	[InlineData("PATCH")]
	public async Task WriteRequest_WhenReadOnly_ThrowsAndSendsNothing(string method)
	{
		using var httpClient = new HttpClient(new AuthenticatedHttpClientHandler(CreateOptions(isReadOnly: true)));

		var act = () => httpClient.SendAsync(new HttpRequestMessage(new HttpMethod(method), $"{BaseUrl}/api/users"), CancellationToken);

		await act.Should().ThrowAsync<InvalidOperationException>();
		_requests.Should().BeEmpty();
	}

	[Fact]
	public async Task WriteRequest_WhenNotReadOnly_IsSent()
	{
		using var httpClient = new HttpClient(new AuthenticatedHttpClientHandler(CreateOptions(isReadOnly: false)));

		using var response = await httpClient.PostAsync($"{BaseUrl}/api/users", new StringContent("{}"), CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		_requests.Should().ContainSingle();
	}

	[Fact]
	public async Task GetRequest_WhenReadOnly_IsStillSent()
	{
		using var httpClient = new HttpClient(new AuthenticatedHttpClientHandler(CreateOptions(isReadOnly: true)));

		using var response = await httpClient.GetAsync($"{BaseUrl}/api/users", CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		_requests.Should().ContainSingle();
	}

	[Fact]
	public async Task ClientWriteCall_WhenReadOnly_ThrowsAndSendsNothing()
	{
		using var client = new EntuityClient(CreateOptions(isReadOnly: true));

		var act = () => client.Settings.ResetGlobalUsersSettingsAsync(CancellationToken);

		// Refit wraps handler exceptions in ApiRequestException
		(await act.Should().ThrowAsync<Refit.ApiRequestException>()).WithInnerException<InvalidOperationException>();
		_requests.Should().BeEmpty();
	}

	public void Dispose()
	{
		_stop.Cancel();
		_listener.Stop();
		_stop.Dispose();
		GC.SuppressFinalize(this);
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
		catch (Exception ex) when (ex is OperationCanceledException or ObjectDisposedException or SocketException)
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

		lock (_requests)
		{
			_requests.Add(received.ToString());
		}

		const string body = "{}";
		var response = $"HTTP/1.1 200 OK\r\nContent-Type: application/json\r\nContent-Length: {body.Length}\r\nConnection: close\r\n\r\n{body}";
		await stream.WriteAsync(Encoding.UTF8.GetBytes(response), _stop.Token);
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
		return int.Parse(text[(index + header.Length)..end].Trim(), System.Globalization.CultureInfo.InvariantCulture);
	}
}
