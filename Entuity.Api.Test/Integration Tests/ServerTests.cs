using Entuity.Api.Test.Services;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ServerTests(EntuityClient client, TestCredentialsManager credentialsManager)
{
	[Fact]
	public async Task ServerController_GetAll_Succeeds()
	{
		// Arrange
		var result = await client
			.Servers
			.GetAll(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetServerDetails_ValidString_Succeeds()
	{
		// Arrange
		var result = await client
			.Servers
			.GetServerDetails(credentialsManager.TestServerId, default);

		result.Should().NotBeNull();
	}
}
