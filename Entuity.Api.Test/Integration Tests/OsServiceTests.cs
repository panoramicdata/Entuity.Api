using Entuity.Api.Models.OsServiceData.Post;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class OsServiceTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task OsServicesController_GetAllAsync_Succeeds()
	{
		var response = await client
			.OsServices
			.GetAllAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task OsServicesController_GetAsync_Succeeds()
	{
		var response = await client
			.OsServices
			.GetAllAsync(default);

		response.Should().NotBeNull();

		foreach (var osService in response.ServiceRules)
		{
			var osServiceResponse = await client
				.OsServices
				.GetAsync(osService.Id, default);

			osServiceResponse.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task OsServicesController_CreateAsync_Succeeds()
	{
		var newRules = new OsServiceCollectionCreate
		{
			ServiceRules = [
				new(){
					ServiceName = "TestService",
					Description = "Test Description",
					FilterUsing = 0,
					OperatingSystem = 0
				}]
		};

		var response = await client
			.OsServices
			.CreateAsync(newRules, default);

		response.Should().NotBeNull();

		// Find ID of created rule
		var createdRule = response
			.ServiceRules
			.FirstOrDefault(x => x.ServiceName == "TestService");

		createdRule.Should().NotBeNull();

		// Delete created rule
		var deleteResponse = await client
			.OsServices
			.DeleteAsync(createdRule!.Id, default);
	}

	[Fact]
	public async Task OsServicesController_DeleteAsync_Succeeds()
	{
		var newRules = new OsServiceCollectionCreate
		{
			ServiceRules = [
				new(){
					ServiceName = "TestServiceTwo",
					Description = "Test Description",
					FilterUsing = 0,
					OperatingSystem = 0
				}]
		};

		var response = await client
			.OsServices
			.CreateAsync(newRules, default);

		response.Should().NotBeNull();

		// Find ID of created rule
		var createdRule = response
			.ServiceRules
			.FirstOrDefault(x => x.ServiceName == "TestServiceTwo");

		createdRule.Should().NotBeNull();

		// Delete created rule
		var deleteResponse = await client
			.OsServices
			.DeleteAsync(createdRule!.Id, default);

		deleteResponse.Should().NotBeNull();
	}
}
