using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ConfigurationTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task ConfigurationController_GetServerGroupsAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetServerGroupsAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task ConfigurationController_GetServerGroupAsync_Succeeds()
	{
		var response = await client
			.Configuration
			.GetServerGroupsAsync(default);

		response.Should().NotBeNull();

		foreach (var serverGroup in response.Items)
		{
			var serverGroupResponse = await client
				.Configuration
				.GetServerGroupAsync(serverGroup.ServerGroupId, default);

			serverGroupResponse.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ConfigurationController_CreateServerGroupAsync_Succeeds()
	{
		var serverGroup = new ServerGroupCreate
		{
			ServerGroupName = "Test Server Group",
		};

		var response = await client
			.Configuration
			.CreateServerGroupAsync(serverGroup, default);

		response.Should().NotBeNull();

		// Attempt Delete
		var deleteResponse = await client
			.Configuration
			.DeleteServerGroupAsync(response.ServerGroupId, default);
	}

	[Fact]
	public async Task ConfigurationController_DeleteServerGroupAsync_Succeeds()
	{
		var serverGroup = new ServerGroupCreate
		{
			ServerGroupName = "Test Server Group",
		};

		var response = await client
			.Configuration
			.CreateServerGroupAsync(serverGroup, default);

		response.Should().NotBeNull();

		// Attempt Delete
		var deleteResponse = await client
			.Configuration
			.DeleteServerGroupAsync(response.ServerGroupId, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.ErrorCode.Should().Contain("SUCCESS");
	}

	[Fact]
	public async Task ConfigurationController_UpdateServerGroupAsync_Succeeds()
	{
		var serverGroup = new ServerGroupCreate
		{
			ServerGroupName = "Test Server Group",
		};

		var response = await client
			.Configuration
			.CreateServerGroupAsync(serverGroup, default);

		response.Should().NotBeNull();

		// Attempt Update
		var updateResponse = await client
			.Configuration
			.UpdateServerGroupAsync(response.ServerGroupId, new ServerGroupUpdate
			{
				ServerGroupName = "Updated Server Group",
			}, default);

		updateResponse.Should().NotBeNull();
		updateResponse.ServerGroupName.Should().Be("Updated Server Group");

		// Attempt Delete
		var deleteResponse = await client
			.Configuration
			.DeleteServerGroupAsync(response.ServerGroupId, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.ErrorCode.Should().Contain("SUCCESS");
	}

	[Fact]
	public async Task ConfigurationController_GetServerGroupsSummaryInformation_Succeeds()
	{
		var response = await client
		.Configuration
		.GetServerGroupsSummaryInfoAsync(default);

		response.Should().NotBeNull();
	}
}
