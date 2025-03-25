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
}
