using Entuity.Api.Models.ZonesData.Post;
using Entuity.Api.Models.ZonesData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class ZonesTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task ZonesController_GetAllAsync_Succeeds()
	{
		var result = await client.Zones.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task ZonesController_CreateAsync_Succeeds()
	{
		var (_, id) = await CreateZoneAsync(TestAddresses.V4(1, 2, 3, 4));

		await client.Zones.DeleteAsync(id, default);
	}

	[Fact]
	public async Task ZonesController_CreateAsync_Fails()
	{
		var response = await client.Zones.CreateAsync(new ZoneCreate { Name = "Test Zone" }, default);

		response.IsSuccessStatusCode.Should().BeFalse();
	}

	[Fact]
	public async Task ZonesController_DeleteAsync_Succeeds()
	{
		var (_, id) = await CreateZoneAsync(TestAddresses.V4(1, 2, 3, 4));

		var deleteResult = await client.Zones.DeleteAsync(id, default);

		deleteResult.IsSuccessStatusCode.Should().BeTrue();
		deleteResult.Content.Should().NotBeNull();
	}

	[Fact]
	public async Task ZonesController_UpdateAsync_Succeeds()
	{
		var (name, id) = await CreateZoneAsync(TestAddresses.V4(3, 4, 5, 6));

		var updateResult = await client.Zones.UpdateAsync(id, new ZoneUpdate { Name = $"{name} - edited" }, default);

		updateResult.Content.Should().NotBeNull();

		await client.Zones.DeleteAsync(id, default);
	}

	private async Task<(string Name, int Id)> CreateZoneAsync(string address)
	{
		var name = Guid.NewGuid().ToString();

		var result = await client.Zones.CreateAsync(new ZoneCreate { Name = name, V4Interface = address }, default);

		result.Content.Should().NotBeNull();

		var createdZone = result.Content?.Items.FirstOrDefault(item => item.Name == name);

		createdZone.Should().NotBeNull();

		int.TryParse(createdZone?.Id, out var id).Should().BeTrue();

		return (name, id);
	}
}
