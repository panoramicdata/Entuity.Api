using Entuity.Api.Models.UserDefinedRestPollersData.Post;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class UserDefinedRestPollerTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task UserDefinedRestPollersController_GetAllAsync_Succeeds()
	{
		var pollers = await client
			.UserDefinedRestPollers
			.GetAllAsync(default);

		pollers.Should().NotBeNull();
	}

	[Fact]
	public async Task UserDefinedRestPollersController_GetAsync_Succeeds()
	{
		var pollers = await client
			.UserDefinedRestPollers
			.GetAllAsync(default);

		pollers.Should().NotBeNull();

		// Foreach poller, get the detailed information
		foreach (var poller in pollers.Items)
		{
			var pollerDetails = await client
				.UserDefinedRestPollers
				.GetAsync(poller.PollerId, default);

			pollerDetails.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task UserDefinedRestPollersController_PostAsync_Succeeds()
	{
		var newPoller = new RestPollerCreate
		{
			PollerType = "API",
			PollerCollectorType = "ASSOCIATED_COMPONENT",
			PollerName = "CovidGlobal",
			ContextTypeName = "UserCreatedNode",
			ComponentTypeDetails = new()
			{
				TypeName = "udp_CovidGlobal",
				TypeDisplayName = "Covid Global Rates",
				Description = "",
				Visibility = "VISIBLE"
			},
			FilterDefinition = new()
			{
				FilterType = "FILTER_ATTRIBUTE_EQUALS_ANY",
				AttributeDefinition = "name",
				AttributeValue = new()
				{
					Array = ["CovidData"]
				}
			},
			ObtainRate = 86400,
			KeepTime = 604800,
			Steps =
			[
				new()
				{
					PollerStepType = "POLLING",
					StepName = "Step 1",
					AuthenticationDetails = new()
					{
						AuthType = "AUTH_NONE",
					},
					EndpointUrlSample = "https://coronavirus.m.pipedream.net",
					Host = "coronavirus.m.pipedream.net",
					ApiPath = "/",
					MethodType = "GET",
					Port = "",
					UseSsl = true,
					AttributeMappings = new(){
						NameToMapping = new()
						{
							["CovidData"] = new()
							{
								SwAttrName = "udp_CovidGlobal_confirmed",
								SwAttrDisplayName = "Global Confirmed Cases",
								DataType = "uint32",
								DisplayType = "string",
								Visibility = "SHORTLISTED",
								Enumerable = false,
								Searchable = false,
								StatusMap = new() { },
								EventInformation = new(){
									EventMode = "NONE",
									Mapping = null
								},
								SourcePath = "summaryStats.global.confirmed"
							}
						}
					}
				}
			]
		};

		var createResponse = await client
			.UserDefinedRestPollers
			.CreateAsync(newPoller, default);

		createResponse.Should().NotBeNull();
		createResponse.Content.Should().NotBeNull();

		// Get all pollers
		var pollers = await client
			.UserDefinedRestPollers
			.GetAllAsync(default);

		pollers.Should().NotBeNull();

		// Find the newly created poller
		var poller = pollers.Items.FirstOrDefault(p => p.PollerName == "CovidGlobal");

		poller.Should().NotBeNull();

		var pollerId = poller!.PollerId;

		// Delete the newly created poller
		var deleteResponse = await client
			.UserDefinedRestPollers
			.DeleteAsync(pollerId, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
	}
}
