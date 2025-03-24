using Entuity.Api.Models.ZonesData.Post;
using Entuity.Api.Models.ZonesData.Update;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ZonesTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task ZonesController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Zones
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task ZonesController_CreateAsync_Succeeds()
	{
		var randomName = Guid.NewGuid().ToString();

		var result = await client
			.Zones
			.CreateAsync(new ZoneCreate
			{
				Name = randomName,
				V4Interface = "1.2.3.4"

			}, default);

		// Should return content if successful
		result.Content.Should().NotBeNull();

		// Attempt cleanup
		var createdZone =
			result?.Content?.Items.FirstOrDefault(item => item.Name == randomName);

		createdZone.Should().NotBeNull();

		var success = int.TryParse(createdZone?.Id, out var parsedId);
		success.Should().BeTrue();

		// Run the Delete
		var deleteResult = await client
			.Zones
			.DeleteAsync(parsedId, default);
	}

	[Fact]
	public async Task ZonesController_CreateAsync_Fails()
	{
		var response = await client
			.Zones
			.CreateAsync(new ZoneCreate
			{
				Name = "Test Zone"
			},
			default);

		response.IsSuccessStatusCode.Should().BeFalse();
	}

	[Fact]
	public async Task ZonesController_DeleteAsync_Succeeds()
	{
		var randomName = Guid.NewGuid().ToString();

		var result = await client
			.Zones
			.CreateAsync(new ZoneCreate
			{
				Name = randomName,
				V4Interface = "1.2.3.4"

			}, default);

		// Should return content if successful
		result.Content.Should().NotBeNull();

		// Attempt cleanup
		var createdZone =
			result?.Content?.Items.FirstOrDefault(item => item.Name == randomName);

		createdZone.Should().NotBeNull();

		var success = int.TryParse(createdZone?.Id, out var parsedId);
		success.Should().BeTrue();

		// Run the Delete
		var deleteResult = await client
			.Zones
			.DeleteAsync(parsedId, default);

		deleteResult.IsSuccessStatusCode.Should().BeTrue();
		deleteResult.Content.Should().NotBeNull();
	}

	[Fact]
	public async Task ZonesController_UpdateAsync_Succeeds()
	{
		var randomName = Guid.NewGuid().ToString();

		var result = await client
			.Zones
			.CreateAsync(new ZoneCreate
			{
				Name = randomName,
				V4Interface = "3.4.5.6"

			}, default);

		// Should return content if successful
		result.Content.Should().NotBeNull();

		var createdZone =
			result?.Content?.Items.FirstOrDefault(item => item.Name == randomName);

		createdZone.Should().NotBeNull();

		var success = int.TryParse(createdZone?.Id, out var parsedId);
		success.Should().BeTrue();

		// Update the Item to be {RANDOM_NAME} - edited
		var updateResult = await client
			.Zones
			.UpdateAsync(parsedId, new ZoneUpdate
			{
				Name = $"{randomName} - edited"
			}, default);

		updateResult.Content.Should().NotBeNull();

		//updateResult.Content!.Name.Should().Be($"{randomName} - edited");

		// Attempt cleanup
		var deleteResult = await client
			.Zones
			.DeleteAsync(parsedId, default);
	}
}
