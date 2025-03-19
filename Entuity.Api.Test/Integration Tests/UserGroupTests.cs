using Entuity.Api.Models.PostItems;
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
			.GetAllAsync(default);


		userGroups.Should().NotBeNull();
	}

	[Fact]
	public async Task UserGroupsController_CreateAsync_Succeeds()
	{
		var newUserGroup = new UserGroupCreate { Name = "Test User Group" };

		var response = await client
			.UserGroups
			.CreateAsync(newUserGroup, default);

		response.Should().NotBeNull();
		response.Items.Should().NotBeNullOrEmpty();

		// Ensure that the group was created
		var createdGroup = response.Items.FirstOrDefault(userGroup => userGroup.Name == "Test User Group");

		createdGroup.Should().NotBeNull();


		var successfulCast = int.TryParse(createdGroup!.Id, out var id);

		// Clean up
		await client
			.UserGroups
			.DeleteAsync(id, default);
	}

	[Fact]
	public async Task UserGroupsController_DeleteAsync_Succeeds()
	{
		var newUserGroup = new UserGroupCreate { Name = "Test User Group" };

		var response = await client
			.UserGroups
			.CreateAsync(newUserGroup, default);

		response.Should().NotBeNull();
		response.Items.Should().NotBeNullOrEmpty();

		// Ensure that the group was created
		var createdGroup = response.Items.FirstOrDefault(userGroup => userGroup.Name == "Test User Group");

		createdGroup.Should().NotBeNull();


		var successfulCast = int.TryParse(createdGroup!.Id, out var id);

		// Clean up
		var deleteResponse = await client
			.UserGroups
			.DeleteAsync(id, default);

		deleteResponse.Should().NotBeNull();
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
