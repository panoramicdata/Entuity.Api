using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class UserTests(EntuityClient client)
{
	[Fact]
	public async Task UsersController_GetAllUsers_Succeeds()
	{
		//Assert
		var users = await client
			.Users
			.GetAllAsync(CancellationToken.None);

		users.Should().NotBeNull();
	}

	[Fact]
	public async Task UsersController_GetUser_Succeeds()
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
}
