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
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetServerDetails_ValidId_Succeeds()
	{
		// Arrange
		var serverResponse = await client
			.Servers
			.GetAllAsync(default);

		serverResponse.Should().NotBeNull();

		foreach (var server in serverResponse.Items)
		{
			var result = await client
				.Servers
				.GetServerDetailsAsync(server.Id, default);

			result.Should().NotBeNull();
		}
	}
}
