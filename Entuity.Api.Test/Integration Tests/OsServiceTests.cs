using Entuity.Api.Models.OsServiceData.Post;
using Entuity.Api.Models.OsServiceData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class OsServiceTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task OsServicesController_GetAllAsync_Succeeds()
	{
		var response = await client.OsServices.GetAllAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task OsServicesController_GetAsync_Succeeds()
	{
		var response = await client.OsServices.GetAllAsync(default);

		response.Should().NotBeNull();

		foreach (var osService in response.ServiceRules)
		{
			(await client.OsServices.GetAsync(osService.Id, default)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task OsServicesController_CreateAsync_Succeeds()
	{
		var id = await CreateRuleAsync("TestService");

		await client.OsServices.DeleteAsync(id, default);
	}

	[Fact]
	public async Task OsServicesController_UpdateAsync_Succeeds()
	{
		var id = await CreateRuleAsync("TestServiceThree");

		var updateResponse = await client.OsServices.UpdateAsync(id, new OsServiceUpdate
		{
			ServiceName = "TestServiceThree",
			Description = "Test Description Edited",
			FilterUsing = 0,
			OperatingSystem = 0,
			Enabled = true
		}, default);

		updateResponse.Should().NotBeNull();

		await client.OsServices.DeleteAsync(id, default);
	}

	[Fact]
	public async Task OsServicesController_DeleteAsync_Succeeds()
	{
		var id = await CreateRuleAsync("TestServiceTwo");

		(await client.OsServices.DeleteAsync(id, default)).Should().NotBeNull();
	}

	private async Task<int> CreateRuleAsync(string serviceName)
	{
		var newRules = new OsServiceCollectionCreate
		{
			ServiceRules = [
				new()
				{
					ServiceName = serviceName,
					Description = "Test Description",
					FilterUsing = 0,
					OperatingSystem = 0
				}]
		};

		var response = await client.OsServices.CreateAsync(newRules, default);

		response.Should().NotBeNull();

		var createdRule = response.ServiceRules.FirstOrDefault(x => x.ServiceName == serviceName);

		createdRule.Should().NotBeNull();

		return createdRule!.Id;
	}
}
