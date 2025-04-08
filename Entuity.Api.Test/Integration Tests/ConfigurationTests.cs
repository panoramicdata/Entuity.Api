using Entuity.Api.Models.ConfigurationData.Configuration.Post;
using Entuity.Api.Models.ConfigurationData.Configuration.Update;
using Entuity.Api.Models.ConfigurationData.Servers.Post;
using Entuity.Api.Models.ConfigurationData.Sets.Post;
using Entuity.Api.Models.ConfigurationData.Sets.Update;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ConfigurationTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task ConfigurationController_GetAllConfigurationSetsAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_GetConfigurationSetAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		response.Should().NotBeNull();

		foreach (var serverGroup in response.Items)
		{
			var serverGroupResponse = await client
				.Configuration
				.GetConfigurationSetAsync(serverGroup.ServerGroupId, default);

			serverGroupResponse.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_CreateConfigurationSetAsync_Succeeds()
	{
		var serverGroup = new ConfigurationSetCreate
		{
			ServerGroupName = "Test Server Group",
		};

		var response = await client
			.Configuration
			.CreateConfigurationSetAsync(serverGroup, default);

		response.Should().NotBeNull();

		// Attempt Delete
		_ = await client
			.Configuration
			.DeleteConfigurationSetAsync(response.ServerGroupId, default);
	}

	[Fact]
	public async Task ConfigurationController_DeleteConfigurationSetAsync_Succeeds()
	{
		var configSet = new ConfigurationSetCreate
		{
			ServerGroupName = "Test Server Group",
		};

		var response = await client
			.Configuration
			.CreateConfigurationSetAsync(configSet, default);

		response.Should().NotBeNull();

		// Attempt Delete
		var deleteResponse = await client
			.Configuration
			.DeleteConfigurationSetAsync(response.ServerGroupId, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.ErrorCode.Should().Contain("SUCCESS");
	}

	[Fact]
	public async Task ConfigurationController_UpdateConfigurationSetAsync_Succeeds()
	{
		var configSet = new ConfigurationSetCreate
		{
			ServerGroupName = "Test Server Group",
		};

		var response = await client
			.Configuration
			.CreateConfigurationSetAsync(configSet, default);

		response.Should().NotBeNull();

		// Attempt Update
		var updateResponse = await client
			.Configuration
			.UpdateConfigurationSetAsync(response.ServerGroupId, new ConfigurationSetUpdate
			{
				ServerGroupName = "Updated Server Group",
			}, default);

		updateResponse.Should().NotBeNull();
		updateResponse.ServerGroupName.Should().Be("Updated Server Group");

		// Attempt Delete
		var deleteResponse = await client
			.Configuration
			.DeleteConfigurationSetAsync(response.ServerGroupId, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.ErrorCode.Should().Contain("SUCCESS");
	}

	[Fact]
	public async Task ConfigurationController_GetServerGroupUsersAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Count.Should().BePositive();

		// Get first server Group
		var serverGroup = serverGroups.Items.First();
		var response = await client
			.Configuration
			.GetConfigurationSetUsersAsync(serverGroup.ServerGroupId, default);
		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_CreateUserOnServerGroupAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Count.Should().BePositive();

		// Get first server Group
		var serverGroup = serverGroups.Items.First();

		var newUser = new ConfigurationSetUserAdd()
		{
			UserName = "TestUser",
			Password = "TestPassword"
		};

		var response = await client
			.Configuration
			.AddUserToConfigurationSetAsync(serverGroup.ServerGroupId, newUser, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain("SUCCESS");

		// Attempt Delete

		_ = await client
			.Configuration
			.RemoveUserFromConfigurationSetAsync(serverGroup.ServerGroupId, newUser.UserName, default);
	}

	[Fact]
	public async Task ConfigurationController_UpdateUserInConfigurationSetAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Count.Should().BePositive();

		// Get first server Group
		var serverGroup = serverGroups.Items.First();

		var newUser = new ConfigurationSetUserAdd()
		{
			UserName = "TestUser",
			Password = "TestPassword"
		};

		var response = await client
			.Configuration
			.AddUserToConfigurationSetAsync(serverGroup.ServerGroupId, newUser, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain("SUCCESS");

		// Update
		var update = new ConfigurationSetUserUpdate
		{
			Password = "UpdatedPassword"
		};

		var updateResponse = await client
			.Configuration
			.UpdateUserInConfigurationSetAsync(serverGroup.ServerGroupId, newUser.UserName, update, default);

		updateResponse.Should().NotBeNull();

		// Attempt Delete
		_ = await client
			.Configuration
			.RemoveUserFromConfigurationSetAsync(serverGroup.ServerGroupId, newUser.UserName, default);
	}

	[Fact]
	public async Task ConfigurationController_DeleteUserOnServerGroupAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Count.Should().BePositive();

		// Get first server Group
		var serverGroup = serverGroups.Items.First();

		var newUser = new ConfigurationSetUserAdd()
		{
			UserName = "TestUser2",
			Password = "TestPassword2"
		};

		var response = await client
			.Configuration
			.AddUserToConfigurationSetAsync(serverGroup.ServerGroupId, newUser, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain("SUCCESS");

		// Attempt Delete

		var deleteResponse = await client
			.Configuration
			.RemoveUserFromConfigurationSetAsync(serverGroup.ServerGroupId, newUser.UserName, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.ErrorCode.Should().Contain("SUCCESS");
	}

	[Fact]
	public async Task ConfigurationController_GetConfigurationSetDetailsAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		foreach (var serverGroup in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetConfigurationSetDetailsAsync(serverGroup.ServerGroupId, default);

			response.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_GetConfigurationSetViews_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		foreach (var serverGroup in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetAllConfigurationSetViewsAsync(serverGroup.ServerGroupId, default);
			response.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_AddViewToConfigurationSetAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		var newView = new ConfigurationSetViewCreate
		{
			ViewName = "TestView",
			BaseViewType = 1,
			BaseViewNames = ["All Objects"],
			DomainFilter = "All Objects",
			EventFilter = "All Events",
			IncidentFilter = "All Incidents",

		};

		var firstGroup = serverGroups.Items.First();

		var response = await client
			.Configuration
			.AddViewToConfigurationSetAsync(firstGroup.ServerGroupId, newView, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain("SUCCESS");

		// Remove View from Configuration Set
		_ = await client
			.Configuration
			.RemoveViewFromConfigurationSetAsync(firstGroup.ServerGroupId, newView.ViewName, default);
	}

	[Fact]
	public async Task ConfigurationController_RemoveViewFromConfigurationSetAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		var newView = new ConfigurationSetViewCreate
		{
			ViewName = "TestView",
			BaseViewType = 1,
			BaseViewNames = ["All Objects"],
			DomainFilter = "All Objects",
			EventFilter = "All Events",
			IncidentFilter = "All Incidents",

		};

		var firstGroup = serverGroups.Items.First();

		var response = await client
			.Configuration
			.AddViewToConfigurationSetAsync(firstGroup.ServerGroupId, newView, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain("SUCCESS");

		// Remove View from Configuration Set
		var removeResponse = await client
			.Configuration
			.RemoveViewFromConfigurationSetAsync(firstGroup.ServerGroupId, newView.ViewName, default);

		removeResponse.Should().NotBeNull();
		removeResponse.ErrorCode.Should().Contain("SUCCESS");
	}

	[Fact]
	public async Task ConfigurationController_GetAllConfigurationSetContentFiltersAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		response.Should().NotBeNull();
		response.Items.Should().NotBeNull();

		foreach (var configSet in response.Items)
		{
			var contentFilters = await client
				.Configuration
				.GetAllConfigurationSetContentFiltersAsync(configSet.ServerGroupId, default);

			contentFilters.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_AddOrUpdateConfigurationSetContentFilterAsync_Succeeds()
	{
		var guid = Guid.NewGuid().ToString();

		var newContentFilter = new ConfigurationSetContentFilterCreate
		{
			Name = $"Test Filter {guid}"
		};

		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Items.Should().NotBeNull();

		var firstGroup = serverGroups.Items.First();

		var response = await client
			.Configuration
			.AddOrUpdateConfigurationSetContentFilterAsync(firstGroup.ServerGroupId, newContentFilter, default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_GetAllConfigurationSetIncidentFiltersAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		response.Should().NotBeNull();
		response.Items.Should().NotBeNull();

		foreach (var configSet in response.Items)
		{
			var contentFilters = await client
				.Configuration
				.GetAllConfigurationSetIncidentFiltersAsync(configSet.ServerGroupId, default);

			contentFilters.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_AddOrUpdateConfigurationSetIncidentFilterAsync_Succeeds()
	{
		var guid = Guid.NewGuid().ToString();

		var newContentFilter = new ConfigurationSetIncidentFilterCreate
		{
			Name = $"Test Filter {guid}"
		};

		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Items.Should().NotBeNull();

		var firstGroup = serverGroups.Items.First();

		var response = await client
			.Configuration
			.AddOrUpdateConfigurationSetIncidentFilterAsync(firstGroup.ServerGroupId, newContentFilter, default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_GetAllConfigurationSetEventFiltersAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		response.Should().NotBeNull();
		response.Items.Should().NotBeNull();

		foreach (var configSet in response.Items)
		{
			var contentFilters = await client
				.Configuration
				.GetAllConfigurationSetEventFiltersAsync(configSet.ServerGroupId, default);

			contentFilters.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_AddOrUpdateConfigurationSetEventFilterAsync_Succeeds()
	{
		var guid = Guid.NewGuid().ToString();

		var newContentFilter = new ConfigurationSetEventFilterCreate
		{
			Name = $"Test Filter {guid}"
		};

		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();
		serverGroups.Items.Should().NotBeNull();

		var firstGroup = serverGroups.Items.First();

		var response = await client
			.Configuration
			.AddOrUpdateConfigurationSetEventFilterAsync(firstGroup.ServerGroupId, newContentFilter, default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_GetConfigurationSetSummaryInfoAsync_Succeeds()
	{
		var response = await client
		.Configuration
		.GetConfigurationSetSummaryInfoAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_GetServerGroupMembershipsAsync_Succeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		foreach (var serverGroup in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetConfigurationSetMembershipsAsync(serverGroup.ServerGroupId, default);

			response.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_AddServerGroupMembershipsAsync_Succeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default); ;

		serverGroups.Should().NotBeNull();

		foreach (var serverGroup in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetConfigurationSetMembershipsAsync(serverGroup.ServerGroupId, default);

			response.Should().NotBeNull();

			// Add server to a group
			var addResponse = await client
				.Configuration
				.AddConfigurationSetMembersAsync(serverGroup.ServerGroupId, new ConfigurationSetMembershipAdd
				{
					MembersAdded = [Guid.NewGuid()]
				}, default);

			addResponse.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_RemoveServerGroupMembershipsAsync_Succeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default); ;

		serverGroups.Should().NotBeNull();

		foreach (var serverGroup in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetConfigurationSetMembershipsAsync(serverGroup.ServerGroupId, default);

			response.Should().NotBeNull();

			// Add server to a group
			var addResponse = await client
				.Configuration
				.RemoveConfigurationSetMembersAsync(serverGroup.ServerGroupId, new ConfigurationSetMembershipRemove
				{
					MembersRemoved = [Guid.NewGuid()]
				}, default);

			addResponse.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_GetAllConfigurationSetUserGroupsAsync_Succeeds()
	{
		var serverGroups = await client
		.Configuration
		.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		foreach (var configSet in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetAllConfigurationSetUserGroupsAsync(configSet.ServerGroupId, default);

			response.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_GetConfigurationSetUserGroupAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		foreach (var configSet in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetAllConfigurationSetUserGroupsAsync(configSet.ServerGroupId, default);

			response.Should().NotBeNull();

			var firstUserGroup = response.Items.FirstOrDefault();

			firstUserGroup.Should().NotBeNull();

			var userGroupResponse = await client
				.Configuration
				.GetConfigurationSetUserGroupAsync(configSet.ServerGroupId, firstUserGroup!.UserGroupName, default);

			userGroupResponse.Should().NotBeNull();

		}

	}


	[Fact]
	public async Task ConfigurationController_UpdateConfigurationSetUserGroupAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		foreach (var configSet in serverGroups.Items)
		{
			var response = await client
				.Configuration
				.GetAllConfigurationSetUserGroupsAsync(configSet.ServerGroupId, default);

			response.Should().NotBeNull();

			var firstUserGroup = response.Items.FirstOrDefault();

			firstUserGroup.Should().NotBeNull();

			var userGroupResponse = await client
				.Configuration
				.GetConfigurationSetUserGroupAsync(configSet.ServerGroupId, firstUserGroup!.UserGroupName, default);

			userGroupResponse.Should().NotBeNull();

			// Hold the orignal members
			var originalMembers = userGroupResponse.Members.ToList();

			// Update the user group
			var updateUserGroup = new ConfigurationSetUserGroupMembershipUpdate() { Members = ["a", "b"] };

			var updateResponse = await client
				.Configuration
				.UpdateConfigurationSetUserGroupAsync(configSet.ServerGroupId, firstUserGroup.UserGroupName, updateUserGroup, default);

			updateResponse.Should().NotBeNull();
			updateResponse.Members.Should().NotBeNull();

			// Revert
			_ = await client
				.Configuration
				.UpdateConfigurationSetUserGroupAsync(configSet.ServerGroupId, firstUserGroup.UserGroupName, new ConfigurationSetUserGroupMembershipUpdate() { Members = originalMembers }, default);



		}
	}

	[Fact]
	public async Task ConfigurationController_CreateConfigurationSetGroupMemberAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		var userGroups = await client
			.Configuration
			.GetAllConfigurationSetUserGroupsAsync(serverGroups.Items.First().ServerGroupId, default);

		serverGroups.Should().NotBeNull();

		var newUser = new ConfigurationSetUserGroupMemberCreate
		{
			Username = "TestUser"
		};

		var response = await client
			.Configuration
			.AddConfigurationSetUserGroupMemberAsync(serverGroups.Items.First().ServerGroupId, userGroups.Items.First().UserGroupName, newUser, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain("SUCCESS");

		// Delete user
		_ = await client
			.Configuration
			.DeleteConfigurationSetUserGroupMemberAsync(serverGroups.Items.First().ServerGroupId, userGroups.Items.First().UserGroupName, newUser.Username, default);
	}

	[Fact]
	public async Task ConfigurationController_DeleteConfigurationSetGroupMemberAsync_Succeeds()
	{
		var serverGroups = await client
			.Configuration
			.GetAllConfigurationSetsAsync(default);

		serverGroups.Should().NotBeNull();

		var userGroups = await client
			.Configuration
			.GetAllConfigurationSetUserGroupsAsync(serverGroups.Items.First().ServerGroupId, default);

		serverGroups.Should().NotBeNull();

		var newUser = new ConfigurationSetUserGroupMemberCreate
		{
			Username = "TestUser"
		};

		var response = await client
			.Configuration
			.AddConfigurationSetUserGroupMemberAsync(serverGroups.Items.First().ServerGroupId, userGroups.Items.First().UserGroupName, newUser, default);

		response.Should().NotBeNull();
		response.ErrorCode.Should().Contain("SUCCESS");

		// Delete user
		var deleteResponse = await client
			.Configuration
			.DeleteConfigurationSetUserGroupMemberAsync(serverGroups.Items.First().ServerGroupId, userGroups.Items.First().UserGroupName, newUser.Username, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.ErrorCode.Should().Contain("SUCCESS");
	}
}
