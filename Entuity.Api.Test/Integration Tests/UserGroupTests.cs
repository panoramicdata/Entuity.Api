using Entuity.Api.Models.UserGroupsData.Post;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class UserGroupTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task UserGroupsController_GetAllAsync_Succeeds()
	{
		var userGroups = await client.UserGroups.GetAllAsync(default);

		userGroups.Should().NotBeNull();
	}

	[Fact]
	public async Task UserGroupsController_CreateAsync_Succeeds()
	{
		var id = await CreateGroupAsync();

		await client.UserGroups.DeleteAsync(id, default);
	}

	[Fact]
	public async Task UserGroupsController_DeleteAsync_Succeeds()
	{
		var id = await CreateGroupAsync();

		(await client.UserGroups.DeleteAsync(id, default)).Should().NotBeNull();
	}

	[Fact]
	public async Task UserGroupsController_GetToolsAsync_Succeeds()
	{
		var userGroups = await client.UserGroups.GetAllAsync(CancellationToken.None);

		foreach (var group in userGroups.Items)
		{
			int.TryParse(group.Id, out var id).Should().BeTrue();

			(await client.UserGroups.GetToolsAsync(id, CancellationToken.None)).Should().NotBeNull();
		}
	}

	private async Task<int> CreateGroupAsync()
	{
		var response = await client.UserGroups.CreateAsync(new UserGroupCreate { Name = "Test User Group" }, default);

		response.Should().NotBeNull();
		response.Items.Should().NotBeNullOrEmpty();

		var createdGroup = response.Items.FirstOrDefault(userGroup => userGroup.Name == "Test User Group");

		createdGroup.Should().NotBeNull();

		int.TryParse(createdGroup!.Id, out var id).Should().BeTrue();

		return id;
	}
}
