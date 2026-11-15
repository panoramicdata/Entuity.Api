using Entuity.Api.Models.ConfigurationData.Configuration.Post;
using Entuity.Api.Models.ConfigurationData.Configuration.Update;
using Entuity.Api.Models.ConfigurationData.Servers.Post;
using Entuity.Api.Models.ConfigurationData.Sets.Post;
using Entuity.Api.Models.ConfigurationData.Sets.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ConfigurationTests(EntuityClient client) : TestFixture
{
	private const string Success = "SUCCESS";

	[Fact]
	public Task ConfigurationController_GetAllConfigurationSetsAsync_Succeeds()
		=> ForEachSetAsync(null);

	[Fact]
	public Task ConfigurationController_GetConfigurationSetAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetConfigurationSetAsync(id, default));

	[Fact]
	public async Task ConfigurationController_CreateConfigurationSetAsync_Succeeds()
	{
		var id = await CreateSetAsync();

		_ = await client.Configuration.DeleteConfigurationSetAsync(id, default);
	}

	[Fact]
	public async Task ConfigurationController_DeleteConfigurationSetAsync_Succeeds()
	{
		var id = await CreateSetAsync();

		(await client.Configuration.DeleteConfigurationSetAsync(id, default)).ErrorCode.Should().Contain(Success);
	}

	[Fact]
	public async Task ConfigurationController_UpdateConfigurationSetAsync_Succeeds()
	{
		var id = await CreateSetAsync();

		var updateResponse = await client.Configuration.UpdateConfigurationSetAsync(
			id,
			new ConfigurationSetUpdate { ServerGroupName = "Updated Server Group" },
			default);

		updateResponse.Should().NotBeNull();
		updateResponse.ServerGroupName.Should().Be("Updated Server Group");

		(await client.Configuration.DeleteConfigurationSetAsync(id, default)).ErrorCode.Should().Contain(Success);
	}

	[Fact]
	public async Task ConfigurationController_GetServerGroupUsersAsync_Succeeds()
	{
		var groupId = await FirstSetIdAsync();

		(await client.Configuration.GetConfigurationSetUsersAsync(groupId, default)).Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_CreateUserOnServerGroupAsync_Succeeds()
	{
		var (groupId, user) = await AddUserAsync("TestUser", "TestPassword");

		_ = await client.Configuration.RemoveUserFromConfigurationSetAsync(groupId, user, default);
	}

	[Fact]
	public async Task ConfigurationController_UpdateUserInConfigurationSetAsync_Succeeds()
	{
		var (groupId, user) = await AddUserAsync("TestUser", "TestPassword");

		var updateResponse = await client.Configuration.UpdateUserInConfigurationSetAsync(
			groupId,
			user,
			new ConfigurationSetUserUpdate { Password = "UpdatedPassword" },
			default);

		updateResponse.Should().NotBeNull();

		_ = await client.Configuration.RemoveUserFromConfigurationSetAsync(groupId, user, default);
	}

	[Fact]
	public async Task ConfigurationController_DeleteUserOnServerGroupAsync_Succeeds()
	{
		var (groupId, user) = await AddUserAsync("TestUser2", "TestPassword2");

		var deleteResponse = await client.Configuration.RemoveUserFromConfigurationSetAsync(groupId, user, default);

		deleteResponse.ErrorCode.Should().Contain(Success);
	}

	[Fact]
	public Task ConfigurationController_GetConfigurationSetDetailsAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetConfigurationSetDetailsAsync(id, default));

	[Fact]
	public Task ConfigurationController_GetConfigurationSetViews_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetAllConfigurationSetViewsAsync(id, default));

	[Fact]
	public async Task ConfigurationController_AddViewToConfigurationSetAsync_Succeeds()
	{
		var (groupId, view) = await AddViewAsync();

		_ = await client.Configuration.RemoveViewFromConfigurationSetAsync(groupId, view.ViewName, default);
	}

	[Fact]
	public async Task ConfigurationController_RemoveViewFromConfigurationSetAsync_Succeeds()
	{
		var (groupId, view) = await AddViewAsync();

		var removeResponse = await client.Configuration.RemoveViewFromConfigurationSetAsync(groupId, view.ViewName, default);

		removeResponse.ErrorCode.Should().Contain(Success);
	}

	[Fact]
	public async Task ConfigurationController_UpdateViewInConfigurationSetAsync_Succeeds()
	{
		var (groupId, view) = await AddViewAsync();

		var viewResponse = await client.Configuration.GetAllConfigurationSetViewsAsync(groupId, default);

		viewResponse.Should().NotBeNull();
		viewResponse.Items.Should().NotBeNull();

		var createdView = viewResponse.Items.FirstOrDefault(v => v.ViewName == view.ViewName);

		createdView.Should().NotBeNull();

		var updateResponse = await client.Configuration.UpdateViewInConfigurationSetAsync(
			groupId,
			createdView!.ViewUUID,
			new ConfigurationSetViewUpdate { ViewName = "UpdatedTestView" },
			default);

		updateResponse.Should().NotBeNull();

		_ = await client.Configuration.RemoveViewFromConfigurationSetAsync(groupId, updateResponse.ViewUUID, default);
	}

	[Fact]
	public Task ConfigurationController_GetAllConfigurationSetContentFiltersAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetAllConfigurationSetContentFiltersAsync(id, default));

	[Fact]
	public async Task ConfigurationController_AddOrUpdateConfigurationSetContentFilterAsync_Succeeds()
	{
		var groupId = await FirstSetIdAsync();

		var response = await client.Configuration.AddOrUpdateConfigurationSetContentFilterAsync(
			groupId,
			new ConfigurationSetContentFilterCreate { Name = FilterName() },
			default);

		response.Should().NotBeNull();
	}

	[Fact]
	public Task ConfigurationController_GetAllConfigurationSetIncidentFiltersAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetAllConfigurationSetIncidentFiltersAsync(id, default));

	[Fact]
	public async Task ConfigurationController_AddOrUpdateConfigurationSetIncidentFilterAsync_Succeeds()
	{
		var groupId = await FirstSetIdAsync();

		var response = await client.Configuration.AddOrUpdateConfigurationSetIncidentFilterAsync(
			groupId,
			new ConfigurationSetIncidentFilterCreate { Name = FilterName() },
			default);

		response.Should().NotBeNull();
	}

	[Fact]
	public Task ConfigurationController_GetAllConfigurationSetEventFiltersAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetAllConfigurationSetEventFiltersAsync(id, default));

	[Fact]
	public async Task ConfigurationController_AddOrUpdateConfigurationSetEventFilterAsync_Succeeds()
	{
		var groupId = await FirstSetIdAsync();

		var response = await client.Configuration.AddOrUpdateConfigurationSetEventFilterAsync(
			groupId,
			new ConfigurationSetEventFilterCreate { Name = FilterName() },
			default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_GetConfigurationSetSummaryInfoAsync_Succeeds()
	{
		var response = await client.Configuration.GetConfigurationSetSummaryInfoAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public Task ConfigurationController_GetServerGroupMembershipsAsync_Succeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetConfigurationSetMembershipsAsync(id, default));

	[Fact]
	public Task ConfigurationController_AddServerGroupMembershipsAsync_Succeds()
		=> ForEachSetAfterMembershipsAsync(async id => await client.Configuration.AddConfigurationSetMembersAsync(
			id,
			new ConfigurationSetMembershipAdd { MembersAdded = [Guid.NewGuid()] },
			default));

	[Fact]
	public Task ConfigurationController_AddServerGroupMembershipsAsyncWithFilter_Succeds()
		=> ForEachSetAfterMembershipsAsync(async id => await client.Configuration.AddConfigurationSetMembersAsync(
			id,
			new ConfigurationSetMembershipAdd { MembersAdded = [Guid.NewGuid()] },
			new() { ForceControl = true },
			default));

	[Fact]
	public Task ConfigurationController_RemoveServerGroupMembershipsAsync_Succeds()
		=> ForEachSetAfterMembershipsAsync(async id => await client.Configuration.RemoveConfigurationSetMembersAsync(
			id,
			new ConfigurationSetMembershipRemove { MembersRemoved = [Guid.NewGuid()] },
			default));

	[Fact]
	public Task ConfigurationController_GetAllConfigurationSetUserGroupsAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.GetAllConfigurationSetUserGroupsAsync(id, default));

	[Fact]
	public async Task ConfigurationController_GetConfigurationSetUserGroupAsync_Succeeds()
	{
		foreach (var configSet in await AllSetsAsync())
		{
			var firstUserGroup = await FirstUserGroupAsync(configSet.ServerGroupId);

			(await client.Configuration.GetConfigurationSetUserGroupAsync(configSet.ServerGroupId, firstUserGroup, default))
				.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_UpdateConfigurationSetUserGroupAsync_Succeeds()
	{
		foreach (var configSet in await AllSetsAsync())
		{
			var groupId = configSet.ServerGroupId;
			var userGroup = await FirstUserGroupAsync(groupId);

			var userGroupResponse = await client.Configuration.GetConfigurationSetUserGroupAsync(groupId, userGroup, default);

			userGroupResponse.Should().NotBeNull();

			var originalMembers = userGroupResponse.Members.ToList();

			var updateResponse = await client.Configuration.UpdateConfigurationSetUserGroupAsync(
				groupId,
				userGroup,
				new ConfigurationSetUserGroupMembershipUpdate { Members = ["a", "b"] },
				default);

			updateResponse.Should().NotBeNull();
			updateResponse.Members.Should().NotBeNull();

			_ = await client.Configuration.UpdateConfigurationSetUserGroupAsync(
				groupId,
				userGroup,
				new ConfigurationSetUserGroupMembershipUpdate { Members = originalMembers },
				default);
		}
	}

	[Fact]
	public async Task ConfigurationController_CreateConfigurationSetGroupMemberAsync_Succeeds()
	{
		var (groupId, userGroup, username) = await AddUserGroupMemberAsync();

		_ = await client.Configuration.DeleteConfigurationSetUserGroupMemberAsync(groupId, userGroup, username, default);
	}

	[Fact]
	public async Task ConfigurationController_DeleteConfigurationSetGroupMemberAsync_Succeeds()
	{
		var (groupId, userGroup, username) = await AddUserGroupMemberAsync();

		var deleteResponse = await client.Configuration.DeleteConfigurationSetUserGroupMemberAsync(groupId, userGroup, username, default);

		deleteResponse.ErrorCode.Should().Contain(Success);
	}

	[Fact]
	public Task ConfigurationController_TriggerSyncOnConfigurationSetAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.TriggerSyncOnConfigurationSetAsync(id, default));

	[Fact]
	public Task ConfigurationController_PopulateConfigurationSetDetailsAsync_Succeeds()
		=> ForEachSetAsync(async id => await client.Configuration.PopulateConfigurationSetDetailsAsync(id, new ConfigurationSetDetailedCreate(), default));

	private static string FilterName() => $"Test Filter {Guid.NewGuid()}";

	private async Task<IReadOnlyList<Models.ConfigurationData.Sets.Get.ConfigurationSet>> AllSetsAsync()
	{
		var serverGroups = await client.Configuration.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Items.Should().NotBeNull();

		return [.. serverGroups.Items];
	}

	private async Task ForEachSetAsync(Func<Guid, Task<object>>? call)
	{
		foreach (var configSet in await AllSetsAsync())
		{
			if (call is not null)
			{
				(await call(configSet.ServerGroupId)).Should().NotBeNull();
			}
		}
	}

	private async Task ForEachSetAfterMembershipsAsync(Func<Guid, Task<object>> call)
	{
		foreach (var configSet in await AllSetsAsync())
		{
			(await client.Configuration.GetConfigurationSetMembershipsAsync(configSet.ServerGroupId, default)).Should().NotBeNull();

			(await call(configSet.ServerGroupId)).Should().NotBeNull();
		}
	}

	private async Task<Guid> FirstSetIdAsync()
	{
		var serverGroups = await client.Configuration.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Count.Should().BePositive();

		return serverGroups.Items.First().ServerGroupId;
	}

	private async Task<string> FirstUserGroupAsync(Guid groupId)
	{
		var response = await client.Configuration.GetAllConfigurationSetUserGroupsAsync(groupId, default);

		response.Should().NotBeNull();

		var firstUserGroup = response.Items.FirstOrDefault();

		firstUserGroup.Should().NotBeNull();

		return firstUserGroup!.UserGroupName;
	}

	private async Task<Guid> CreateSetAsync()
	{
		var response = await client.Configuration.CreateConfigurationSetAsync(
			new ConfigurationSetCreate { ServerGroupName = "Test Server Group" },
			default);

		response.Should().NotBeNull();

		return response.ServerGroupId;
	}

	private async Task<(Guid GroupId, string UserName)> AddUserAsync(string userName, string password)
	{
		var groupId = await FirstSetIdAsync();

		var response = await client.Configuration.AddUserToConfigurationSetAsync(
			groupId,
			new ConfigurationSetUserAdd { UserName = userName, Password = password },
			default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain(Success);

		return (groupId, userName);
	}

	private async Task<(Guid GroupId, ConfigurationSetViewCreate View)> AddViewAsync()
	{
		var groupId = await FirstSetIdAsync();

		var newView = new ConfigurationSetViewCreate
		{
			ViewName = "TestView",
			BaseViewType = 1,
			BaseViewNames = ["All Objects"],
			DomainFilter = "All Objects",
			EventFilter = "All Events",
			IncidentFilter = "All Incidents",
		};

		var response = await client.Configuration.AddViewToConfigurationSetAsync(groupId, newView, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain(Success);

		return (groupId, newView);
	}

	private async Task<(Guid GroupId, string UserGroup, string Username)> AddUserGroupMemberAsync()
	{
		var groupId = await FirstSetIdAsync();
		var userGroup = await FirstUserGroupAsync(groupId);
		var newUser = new ConfigurationSetUserGroupMemberCreate { Username = "TestUser" };

		var response = await client.Configuration.AddConfigurationSetUserGroupMemberAsync(groupId, userGroup, newUser, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain(Success);

		return (groupId, userGroup, newUser.Username);
	}
}
