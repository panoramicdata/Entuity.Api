using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class UserGroupTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task UserGroupsController_GetAllAsync_Succeeds()
	{
		//Assert
		var userGroups = await client
			.UserGroups
			.GetAllAsync(CancellationToken.None);


		userGroups.Should().NotBeNull();
	}

	[Fact]
	public async Task UserGroupsController_GetToolsAsync_Succeeds()
	{
		var userGroups = await client
			.UserGroups
			.GetAllAsync(CancellationToken.None);

		foreach (var group in userGroups.Items)
		{
			var success = int.TryParse(group.Id, out var id);

			success.Should().BeTrue();

			var tools = await client
				.UserGroups
				.GetToolsAsync(id, CancellationToken.None);
			tools.Should().NotBeNull();
		}
	}
}
