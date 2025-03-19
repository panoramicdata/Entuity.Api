using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class UserTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task UsersController_GetAllUsersAsync_Succeeds()
	{
		//Assert
		var users = await client
			.Users
			.GetAllAsync(CancellationToken.None);

		users.Should().NotBeNull();
	}

	[Fact]
	public async Task UsersController_GetUserAsync_Succeeds()
	{
		var users = await client
			.Users
			.GetAllAsync(default);

		users.Should().NotBeNull();
		users.Items.Should().NotBeEmpty();

		foreach (var user in users.Items)
		{
			var success = int.TryParse(user.Id, out var id);

			success.Should().BeTrue();

			var userDetail = await client
				.Users
				.GetAsync(id, default);
			userDetail.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task UsersController_CreateUserAsync_Succeeds()
	{
		var newUser = new UserCreate { Name = "TestUser", Password = "TestPassword" };

		var createResponse = await client
			.Users
			.CreateAsync(newUser, default);

		createResponse.Should().NotBeNull();

		// Attempt to delete the user
		var userId = createResponse.Items.FirstOrDefault(user => user.Name == newUser.Name)?.Id;

		userId.Should().NotBeNull();

		var success = int.TryParse(userId, out var id);

		success.Should().BeTrue();

		var deleteResponse = await client
			.Users
			.DeleteAsync(id, default);
	}

	[Fact]
	public async Task UsersController_DeleteUserAsync_Succeeds()
	{
		var newUser = new UserCreate { Name = "TestUser2", Password = "TestPassword2" };

		var createResponse = await client
			.Users
			.CreateAsync(newUser, default);

		createResponse.Should().NotBeNull();

		// Attempt to delete the user
		var userId = createResponse.Items.FirstOrDefault(user => user.Name == newUser.Name)?.Id;

		userId.Should().NotBeNull();

		var success = int.TryParse(userId, out var id);

		success.Should().BeTrue();

		var deleteResponse = await client
			.Users
			.DeleteAsync(id, default);

		deleteResponse.Should().NotBeNull();
	}

	[Fact]
	public async Task UsersController_UpdateUserAsync_Succeeds()
	{
		var newUser = new UserCreate { Name = "TestUser3", Password = "TestPassword3" };

		var createResponse = await client
			.Users
			.CreateAsync(newUser, default);

		createResponse.Should().NotBeNull();

		// Get the User's ID
		var userId = createResponse.Items.FirstOrDefault(user => user.Name == newUser.Name)?.Id;

		userId.Should().NotBeNull();

		var success = int.TryParse(userId, out var id);
		success.Should().BeTrue();

		var updatedUser = new UserUpdate { PwChangeDays = 3 };

		var updateResponse = await client
			.Users
			.UpdateAsync(id, updatedUser, default);

		updateResponse.Should().NotBeNull();

		// Attempt to delete the user
		var deleteResponse = await client
			.Users
			.DeleteAsync(id, default);

		deleteResponse.Should().NotBeNull();
	}

	[Fact]
	public async Task UsersController_GetUserGroupsAsync_Succeeds()
	{
		var users = await client
			.Users
			.GetAllAsync(default);

		users.Should().NotBeNull();

		foreach (var user in users.Items)
		{
			var success = int.TryParse(user.Id, out var id);
			success.Should().BeTrue();
			var userGroups = await client
				.Users
				.GetUsersGroup(id, default);
			userGroups.Should().NotBeNull();
		}
	}
}
