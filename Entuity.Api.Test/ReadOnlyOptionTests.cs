using AwesomeAssertions;
using System.Net;

namespace Entuity.Api.Test;

public sealed class ReadOnlyOptionTests : IDisposable
{
	private readonly LoopbackServer _server = new(_ => (200, "{}"));

	private static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	private EntuityClientOptions CreateOptions(bool isReadOnly) => _server.Options(o => o.IsReadOnly = isReadOnly);

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

		var act = () => httpClient.SendAsync(new HttpRequestMessage(new HttpMethod(method), $"{_server.BaseUrl}/api/users"), CancellationToken);

		await act.Should().ThrowAsync<InvalidOperationException>();
		_server.Requests.Should().BeEmpty();
	}

	[Fact]
	public async Task WriteRequest_WhenNotReadOnly_IsSent()
	{
		using var httpClient = new HttpClient(new AuthenticatedHttpClientHandler(CreateOptions(isReadOnly: false)));

		using var response = await httpClient.PostAsync($"{_server.BaseUrl}/api/users", new StringContent("{}"), CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		_server.Requests.Should().ContainSingle();
	}

	[Fact]
	public async Task GetRequest_WhenReadOnly_IsStillSent()
	{
		using var httpClient = new HttpClient(new AuthenticatedHttpClientHandler(CreateOptions(isReadOnly: true)));

		using var response = await httpClient.GetAsync($"{_server.BaseUrl}/api/users", CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		_server.Requests.Should().ContainSingle();
	}

	[Fact]
	public async Task ClientWriteCall_WhenReadOnly_ThrowsAndSendsNothing()
	{
		using var client = new EntuityClient(CreateOptions(isReadOnly: true));

		var act = () => client.Settings.ResetGlobalUsersSettingsAsync(CancellationToken);

		// Refit wraps handler exceptions in ApiRequestException
		(await act.Should().ThrowAsync<Refit.ApiRequestException>()).WithInnerException<InvalidOperationException>();
		_server.Requests.Should().BeEmpty();
	}

	public void Dispose() => _server.Dispose();
}
