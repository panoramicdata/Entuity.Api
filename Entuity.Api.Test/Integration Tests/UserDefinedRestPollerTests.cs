using Entuity.Api.Models.UserDefinedRestPollersData;
using Entuity.Api.Models.UserDefinedRestPollersData.Post;
using Entuity.Api.Models.UserDefinedRestPollersData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class UserDefinedRestPollerTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task UserDefinedRestPollersController_GetAllAsync_Succeeds()
	{
		var pollers = await client.UserDefinedRestPollers.GetAllAsync(default);

		pollers.Should().NotBeNull();
	}

	[Fact]
	public async Task UserDefinedRestPollersController_GetAsync_Succeeds()
	{
		var pollers = await client.UserDefinedRestPollers.GetAllAsync(default);

		pollers.Should().NotBeNull();

		foreach (var poller in pollers.Items)
		{
			(await client.UserDefinedRestPollers.GetAsync(poller.PollerId, default)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task UserDefinedRestPollersController_UpdateAsync_Succeeds()
	{
		var pollerId = await CreatePollerAsync();

		var updateResponse = await client.UserDefinedRestPollers.UpdateAsync(
			pollerId,
			new RestPollerUpdate { PollerType = "SNMP" },
			default);

		updateResponse.Should().NotBeNull();

		await client.UserDefinedRestPollers.DeleteAsync(pollerId, default);
	}

	[Fact]
	public async Task UserDefinedRestPollersController_PostAsync_Succeeds()
	{
		var pollerId = await CreatePollerAsync();

		await client.UserDefinedRestPollers.DeleteAsync(pollerId, default);
	}

	[Fact]
	public async Task UserDefinedRestPollersController_DeleteAsync_Succeeds()
	{
		var pollerId = await CreatePollerAsync();

		var deleteResponse = await client.UserDefinedRestPollers.DeleteAsync(pollerId, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
	}

	[Fact]
	public async Task UserDefinedRestPollersController_TestPollerAsync_Succeeds()
	{
		var testInformation = new RestPollerTestInformation { Url = "https://localhost/api/service/1644" };

		var testResponse = await client.UserDefinedRestPollers.TestRestPollerAsync(testInformation, default);

		testResponse.ReturnCode.Should().Be("OK");
	}

	private async Task<int> CreatePollerAsync()
	{
		var createResponse = await client.UserDefinedRestPollers.CreateAsync(NewPoller(), default);

		createResponse.Should().NotBeNull();
		createResponse.Content.Should().NotBeNull();

		var pollers = await client.UserDefinedRestPollers.GetAllAsync(default);

		pollers.Should().NotBeNull();

		var poller = pollers.Items.FirstOrDefault(p => p.PollerName == "CovidGlobal");

		poller.Should().NotBeNull();

		return poller!.PollerId;
	}

	private static RestPollerCreate NewPoller() => new()
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
				AttributeMappings = new()
				{
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
							StatusMap = new(),
							EventInformation = new()
							{
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
}
