using Entuity.Api.Models.UsersData.Post;
using Entuity.Api.Models.UsersData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class UserTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task UsersController_GetAllUsersAsync_Succeeds()
	{
		var users = await client.Users.GetAllAsync(default);

		users.Should().NotBeNull();
	}

	[Fact]
	public async Task UsersController_GetUserAsync_Succeeds()
	{
		var users = await client.Users.GetAllAsync(default);

		users.Should().NotBeNull();
		users.Items.Should().NotBeEmpty();

		foreach (var user in users.Items)
		{
			(await client.Users.GetAsync(ParseId(user.Id), default)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task UsersController_CreateUserAsync_Succeeds()
	{
		var id = await CreateUserAsync("TestUser", "TestPassword");

		await client.Users.DeleteAsync(id, default);
	}

	[Fact]
	public async Task UsersController_DeleteUserAsync_Succeeds()
	{
		var id = await CreateUserAsync("TestUser2", "TestPassword2");

		(await client.Users.DeleteAsync(id, default)).Should().NotBeNull();
	}

	[Fact]
	public async Task UsersController_UpdateUserAsync_Succeeds()
	{
		var id = await CreateUserAsync("TestUser3", "TestPassword3");

		(await client.Users.UpdateAsync(id, new UserUpdate { PwChangeDays = 3 }, default)).Should().NotBeNull();

		(await client.Users.DeleteAsync(id, default)).Should().NotBeNull();
	}

	[Fact]
	public async Task UsersController_GetUserGroupsAsync_Succeeds()
	{
		var users = await client.Users.GetAllAsync(default);

		users.Should().NotBeNull();

		foreach (var user in users.Items)
		{
			(await client.Users.GetUsersGroup(ParseId(user.Id), default)).Should().NotBeNull();
		}
	}

	private static int ParseId(string? value)
	{
		int.TryParse(value, out var id).Should().BeTrue();

		return id;
	}

	private async Task<int> CreateUserAsync(string name, string password)
	{
		var createResponse = await client.Users.CreateAsync(new UserCreate { Name = name, Password = password }, default);

		createResponse.Should().NotBeNull();

		var userId = createResponse.Items.FirstOrDefault(user => user.Name == name)?.Id;

		userId.Should().NotBeNull();

		return ParseId(userId);
	}
}
