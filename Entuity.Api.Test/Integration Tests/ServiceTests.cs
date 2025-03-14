using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ServiceTests(EntuityClient client)
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
}
