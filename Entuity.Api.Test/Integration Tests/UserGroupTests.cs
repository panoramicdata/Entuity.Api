using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class UserGroupTests(EntuityClient client)
{
	[Fact]
	public async Task UserGroupsController_GetAllUserGroups_Succeeds()
	{
		//Assert
		var userGroups = await client
			.UserGroups
			.GetAllAsync(CancellationToken.None);


		userGroups.Should().NotBeNull();
	}
}
