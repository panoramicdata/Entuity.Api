using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ObjectTests(EntuityClient client) : TestFixture
{

	[Fact]
	public async Task ObjectsController_GetObjectAssociationsAsync_Succeeds()
	{
		var associations = await client
			.Objects
			.GetObjectAssociations(1, default);

		associations.Should().NotBeNull();
	}
}
