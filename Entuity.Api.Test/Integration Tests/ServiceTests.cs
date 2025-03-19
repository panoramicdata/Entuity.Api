using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ServiceTests(EntuityClient client) : TestFixture
{

	[Fact]
	public async Task ServicesController_GetAllAsync_Succeeds()
	{
		var services = await client
			.Services
			.GetAllAsync(CancellationToken.None);

		services.Should().NotBeNull();

	}

	[Fact]
	public async Task ServicesController_GetAsync_Succeeds()
	{
		var services = await client
			.Services
			.GetAllAsync(CancellationToken.None);

		foreach (var service in services.Items)
		{
			var detailedService = await client
				.Services
				.GetAsync(service.ObjectId, CancellationToken.None);

			detailedService.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ServicesController_CreateAsync_Succeeds()
	{
		var newService = new ServiceCreate { ServiceName = "Test Service" };

		var createResponse = await client
			.Services
			.CreateAsync(newService, default);

		createResponse.Should().NotBeNull();

		// Attempt Delete
		var deleteResponse = await client
			.Services
			.DeleteAsync(createResponse.Info.ServiceId, default);
	}

	[Fact]
	public async Task ServicesController_UpdateAsync_Succeeds()
	{
		var newService = new ServiceCreate { ServiceName = "Test Service" };

		var createResponse = await client
			.Services
			.CreateAsync(newService, default);

		createResponse.Should().NotBeNull();

		var updateService = new ServiceUpdate { ServiceName = "Updated Test Service" };

		var updateResponse = client
			.Services
			.UpdateAsync(createResponse.Info.ServiceId, updateService, default);

		updateResponse.Should().NotBeNull();

		// Attempt Delete
		var deleteResponse = await client
			.Services
			.DeleteAsync(createResponse.Info.ServiceId, default);
	}

	[Fact]
	public async Task ServicesController_DeleteAsync_Succeeds()
	{
		var newService = new ServiceCreate { ServiceName = "Test Service" };

		var createResponse = await client
			.Services
			.CreateAsync(newService, default);

		createResponse.Should().NotBeNull();

		// Attempt Delete
		var deleteResponse = await client
			.Services
			.DeleteAsync(createResponse.Info.ServiceId, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.Content.Should().Contain("ok");
	}
}
