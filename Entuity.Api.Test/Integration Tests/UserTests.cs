using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class UserTests(EntuityClient client)
{
	[Fact]
	public async Task GetAllUsers()
	{
		//Assert
		var users = await client
			.Users
			.GetAllAsync();

		users.Should().NotBeNull();
	}
}
