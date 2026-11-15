using Entuity.Api.Models.ServicesData.Post;
using Entuity.Api.Models.ServicesData.Update;
using Entuity.Api.QueryParameters;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ServiceTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task ServicesController_GetAllAsync_Succeeds()
	{
		var services = await client.Services.GetAllAsync(CancellationToken.None);

		services.Should().NotBeNull();
	}

	[Fact]
	public Task ServicesController_GetAllAsyncWithViewPathParameter_Succeeds()
		=> GetAllWithFilterAsync(new ServicesFilter { ViewPath = "My Network/test" });

	[Fact]
	public Task ServicesController_GetAllAsyncWithIndirectParameter_Succeeds()
		=> GetAllWithFilterAsync(new ServicesFilter { Indirect = true });

	[Fact]
	public Task ServicesController_GetAllAsyncWithSubServicesParameter_Succeeds()
		=> GetAllWithFilterAsync(new ServicesFilter { SubServices = true });

	[Fact]
	public Task ServicesController_GetAllAsyncWithSubConsolidateParameter_Succeeds()
		=> GetAllWithFilterAsync(new ServicesFilter { Consolidate = true });

	[Fact]
	public Task ServicesController_GetAllAsyncWithSubMaxDepthParameter_Succeeds()
		=> GetAllWithFilterAsync(new ServicesFilter { MaxDepth = 5 });

	[Fact]
	public async Task ServicesController_GetAsync_Succeeds()
	{
		var services = await client.Services.GetAllAsync(CancellationToken.None);

		foreach (var service in services.Items)
		{
			(await client.Services.GetAsync(service.ObjectId, CancellationToken.None)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ServicesController_CreateAsync_Succeeds()
	{
		var serviceId = await CreateServiceAsync();

		await client.Services.DeleteAsync(serviceId, default);
	}

	[Fact]
	public async Task ServicesController_UpdateAsync_Succeeds()
	{
		var serviceId = await CreateServiceAsync();

		var updateResponse = await client.Services.UpdateAsync(
			serviceId,
			new ServiceUpdate { ServiceName = "Updated Test Service" },
			default);

		updateResponse.Should().NotBeNull();

		await client.Services.DeleteAsync(serviceId, default);
	}

	[Fact]
	public async Task ServicesController_DeleteAsync_Succeeds()
	{
		var serviceId = await CreateServiceAsync();

		var deleteResponse = await client.Services.DeleteAsync(serviceId, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.Content.Should().Contain("ok");
	}

	private async Task GetAllWithFilterAsync(ServicesFilter filter)
	{
		var services = await client.Services.GetAllAsync(filter, default);

		services.Should().NotBeNull();
	}

	private async Task<int> CreateServiceAsync()
	{
		var createResponse = await client.Services.CreateAsync(new ServiceCreate { ServiceName = "Test Service" }, default);

		createResponse.Should().NotBeNull();

		return createResponse.Info.ServiceId;
	}
}
