using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class CredentialManagementTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task CredentialManagementController_GetAllCredentialsAsync_ReturnsCredentials()
	{
		// Arrange
		var cancellationToken = new CancellationToken();

		var response = await client
			.CredentialManagement
			.GetAllCredentialsAsync(cancellationToken);

		response.Should().NotBeNull();
	}
}
