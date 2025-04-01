using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ObjectTests(EntuityClient client) : TestFixture
{

	[Fact]
	public async Task ObjectsController_GetObjectAssociationsAsync_Succeeds()
	{
		var associations = await client
			.Objects
			.GetObjectAssociationsAsync(1, default);

		associations.Should().NotBeNull();
	}

	[Fact]
	public async Task ObjectsController_GetObjectAssociationsDetailedAsync_Succeeds()
	{
		var associations = await client
			.Objects
			.GetObjectAssociationsAsync(1, default);

		associations.Should().NotBeNull();

		foreach (var association in associations.Items)
		{
			var detailed = await client
				.Objects
				.GetObjectAssociationsDetailedAsync(1, association, default);

			detailed.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ObjectsController_GetObjectAttributesAsync_Succeeds()
	{
		var attributes = await client
			.Objects
			.GetObjectAttributesAsync(1, default);

		attributes.Should().NotBeNull();
	}

	[Fact]
	public async Task ObjectsController_GetObjectAttributeDetailsAsync_Succeeds()
	{
		var attributes = await client
			.Objects
			.GetObjectAttributesAsync(1, default);

		attributes.Should().NotBeNull();

		foreach (var attribute in attributes.Items)
		{
			var detailed = await client
				.Objects
				.GetObjectAttributeDetailsAsync(1, attribute, default);

			detailed.Should().NotBeNull();
		}
	}
}
