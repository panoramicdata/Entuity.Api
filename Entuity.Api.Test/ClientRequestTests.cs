using AwesomeAssertions;
using Entuity.Api.Enums;
using Entuity.Api.QueryParameters;
using Microsoft.Extensions.Logging;
using System.Text;

namespace Entuity.Api.Test;

public sealed class ClientRequestTests
{
	private static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	[Fact]
	public async Task GetRequest_SendsBasicAuthAndAcceptHeaders()
	{
		using var server = new LoopbackServer(_ => (200, """{"items":[],"count":0}"""));
		using var client = new EntuityClient(server.Options(o => o.UserAgent = "Entuity.Api.Test"));

		var zones = await client.Zones.GetAllAsync(CancellationToken);

		zones.Items.Should().BeEmpty();
		var request = server.Requests.Should().ContainSingle().Subject;
		request.Should().StartWith("GET /api/zones ");
		request.Should().Contain($"Authorization: Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes("user:password"))}");
		request.Should().Contain("application/json");
		request.Should().Contain("Entuity.Api.Test");
	}

	[Fact]
	public async Task EventsFilter_IsSentAsQueryString()
	{
		using var server = new LoopbackServer(_ => (200, """{"events":[],"updateId":1,"count":0}"""));
		using var client = new EntuityClient(server.Options());

		await client.Events.GetAllAsync(
			new EventsFilter { OpenedFrom = 10, ClosedTo = 20, SeverityRating = SeverityRating.Major },
			CancellationToken);

		var requestLine = server.Requests.Single().Split("\r\n")[0];
		requestLine.Should().Contain("openedFrom=10");
		requestLine.Should().Contain("closedTo=20");
		requestLine.Should().Contain("mask=4");
	}

	[Fact]
	public async Task Response_TypeProperty_IsRewrittenToDollarType()
	{
		using var server = new LoopbackServer(_ => (200, """{"type":"abc"}"""));
		using var http = new HttpClient(new AuthenticatedHttpClientHandler(server.Options()));

		var body = await http.GetStringAsync($"{server.BaseUrl}/api/x", CancellationToken);

		body.Should().Be("""{"$type":"abc"}""");
	}

	[Theory]
	[InlineData("""{"a":1}""")]
	[InlineData("[1,2]")]
	[InlineData("not json")]
	public async Task DebugLogging_LogsRequestAndResponse(string responseBody)
	{
		using var server = new LoopbackServer(_ => (200, responseBody));
		var logger = new ListLogger();
		using var http = new HttpClient(new AuthenticatedHttpClientHandler(server.Options(o => o.Logger = logger)));

		using var content = new StringContent("{}");
		using var response = await http.PostAsync($"{server.BaseUrl}/api/x", content, CancellationToken);

		response.IsSuccessStatusCode.Should().BeTrue();
		logger.Messages.Should().Contain(m => m.Contains("REQUEST", StringComparison.Ordinal));
		logger.Messages.Should().Contain(m => m.Contains("RESPONSE", StringComparison.Ordinal));
	}

	[Fact]
	public async Task Logging_AtInformationLevel_WritesNothing()
	{
		using var server = new LoopbackServer(_ => (200, "{}"));
		var logger = new ListLogger(LogLevel.Information);
		using var http = new HttpClient(new AuthenticatedHttpClientHandler(server.Options(o => o.Logger = logger)));

		await http.GetStringAsync($"{server.BaseUrl}/api/x", CancellationToken);

		logger.Messages.Should().BeEmpty();
	}

	[Fact]
	public void Client_ExposesEveryController_AndDisposesRepeatedly()
	{
		var client = new EntuityClient(new EntuityClientOptions { Url = "http://localhost", Username = "u", Password = "p" });

		new object?[]
		{
			client.AutoDiscovery, client.Configuration, client.CredentialManagement, client.FlowData,
			client.Filters, client.Ipam, client.Information, client.DataAccessTemplates, client.Inventory,
			client.Events, client.Incidents, client.Tools, client.LicenseInformation, client.Maintenance,
			client.MerakiCloudControllers, client.OsServices, client.Objects, client.Users, client.UserGroups,
			client.UserDefinedRestPollers, client.Servers, client.Services, client.Settings, client.Views,
			client.WebHooks, client.Zones
		}.Should().AllSatisfy(controller => controller.Should().NotBeNull());

		client.Dispose();
		client.Dispose();
	}

	private sealed class ListLogger(LogLevel minimum = LogLevel.Debug) : ILogger
	{
		public List<string> Messages { get; } = [];

		public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

		public bool IsEnabled(LogLevel logLevel) => logLevel >= minimum;

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
			=> Messages.Add(formatter(state, exception));
	}
}
