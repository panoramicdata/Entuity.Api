using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class LicenseInformationTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task LicenseInformationController_GetLicenseInfoAsync_Succeeds()
	{
		var info = await client
			.LicenseInformation
			.GetLicenseInfoAsync(default);

		info.Should().NotBeNull();
	}
}
