using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class MerakiCloudControllerTests(EntuityClient client)
{
	[Fact]
	public async Task MerakiCloudControllersController_GetAllAsync_Succeeds()
	{
		var response = await client
			.MerakiCloudControllers
			.GetAllAsync(CancellationToken.None);

		response.Should().NotBeNull();
	}
}
