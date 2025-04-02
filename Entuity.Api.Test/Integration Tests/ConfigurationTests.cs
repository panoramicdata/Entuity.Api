using Entuity.Api.Models.ConfigurationData.Configuration.Post;
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
	public async Task ConfigurationController_GetServerGroupConfigurationAsync_Succeeds()
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
}
