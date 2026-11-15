using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entuity.Api;

public class AuthenticatedHttpClientHandler(EntuityClientOptions options) : HttpClientHandler
{
	private readonly EntuityClientOptions _options = options;
	private readonly ILogger _logger = options.Logger ?? NullLogger.Instance;
	private static readonly JsonSerializerOptions JsonSerializerOptions = new()
	{
		WriteIndented = true,
		Converters = { new JsonStringEnumConverter() },
		UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
	};

	/// <summary>
	/// Override of the base method that is used to handle the sending of a request
	/// </summary>
	/// <param name="request">The request that is to be sent</param>
	/// <param name="cancellationToken">A cancellation token for the operation</param>
	/// <returns>The response to the request that was sent</returns>
	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		EnsureMethodAllowed(request);

		var requestId = Guid.NewGuid();

		PrepareHeaders(request);

		await LogRequestAsync(requestId, request, cancellationToken).ConfigureAwait(false);

		var httpResponse = await base
			.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);

		await LogResponseAsync(requestId, httpResponse, cancellationToken).ConfigureAwait(false);

		await RewriteTypePropertyAsync(httpResponse, cancellationToken).ConfigureAwait(false);

		return httpResponse;
	}

	private void EnsureMethodAllowed(HttpRequestMessage request)
	{
		if (_options.IsReadOnly
			&& request.Method != HttpMethod.Get
			&& request.Method != HttpMethod.Head
			&& request.Method != HttpMethod.Options)
		{
			throw new InvalidOperationException(
				$"The client is read-only, so {request.Method} {request.RequestUri?.AbsolutePath} was not sent.");
		}
	}

	private void PrepareHeaders(HttpRequestMessage request)
	{
		request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

		request.Headers.Authorization = new AuthenticationHeaderValue(
			"Basic",
			Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_options.Username}:{_options.Password}"))
		);

		if (!string.IsNullOrWhiteSpace(_options.UserAgent))
		{
			request.Headers.Add("User-Agent", _options.UserAgent);
		}
	}

	private static string FormatHeaders(HttpHeaders headers)
		=> string.Join("\n", headers.Select(h => $"{h.Key}: {string.Join(", ", h.Value)}"));

	private static async Task<string> ReadBodyAsync(HttpContent? content, CancellationToken cancellationToken)
		=> content is null
			? string.Empty
			: await content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

	private async Task LogRequestAsync(Guid requestId, HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		var body = await ReadBodyAsync(request.Content, cancellationToken).ConfigureAwait(false);

		_logger.LogDebug(
			"{RequestId}: REQUEST: Url:{Url}\nHeaders:{Headers}\nBody: {Body}",
			requestId,
			request.RequestUri!.ToString(),
			FormatHeaders(request.Headers),
			body);
	}

	private async Task LogResponseAsync(Guid requestId, HttpResponseMessage httpResponse, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		var body = await ReadBodyAsync(httpResponse.Content, cancellationToken).ConfigureAwait(false);
		try
		{
			var jObject = JsonSerializer.Deserialize<object>(body);
			body = JsonSerializer.Serialize(jObject, JsonSerializerOptions);
		}
		catch (JsonException)
		{
			// Not a JSON object, so log the raw body
		}

		_logger.LogDebug(
			"{RequestId}: RESPONSE: {StatusCode}\nHeaders:{Headers}\nBody: {Body}",
			requestId,
			httpResponse.StatusCode,
			FormatHeaders(httpResponse.Headers),
			body);
	}

	private static async Task RewriteTypePropertyAsync(HttpResponseMessage httpResponse, CancellationToken cancellationToken)
	{
		if (httpResponse.Content is null)
		{
			return;
		}

		var content = await httpResponse
			.Content
			.ReadAsStringAsync(cancellationToken)
			.ConfigureAwait(false);

		content = content.Replace("\"type\"", "\"$type\"", StringComparison.Ordinal);

		httpResponse.Content = new StringContent(content);
	}
}
