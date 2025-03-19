using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class MaintenanceTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task MaintenanceController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Maintenance
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task MaintenanceController_GetAsync_Succeeds()
	{
		var maintenanceSchedules = await client
			.Maintenance
			.GetAllAsync(default);

		maintenanceSchedules.Should().NotBeNull();

		foreach (var schedule in maintenanceSchedules.Items)
		{
			var result = await client
				.Maintenance
				.GetAsync(schedule.Id, default);

			result.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task MaintenanceController_CreateAsync_Succeeds()
	{
		var newMaintenance = new MaintenanceCreate { Name = "TestMaintenance" };

		var result = await client
			.Maintenance
			.CreateAsync(newMaintenance, default);

		result.Should().NotBeNull();

		// Attempt cleanup
		var deleteResponse = await client
			.Maintenance
			.DeleteAsync(result.Id, default);
	}

	[Fact]
	public async Task MaintenanceController_UpdateAsync_Succeeds()
	{
		var newMaintenance = new MaintenanceCreate { Name = "TestMaintenance" };

		var result = await client
			.Maintenance
			.CreateAsync(newMaintenance, default);

		result.Should().NotBeNull();

		// Update the maintenance schedule
		var updateMaintenance = new MaintenanceUpdate
		{
			Name = "TestMaintenanceUpdated",
			AddDevices = new(){
			{ "a-server", [1,2,3] } }
		};
		var updateResult = await client
			.Maintenance
			.UpdateAsync(result.Id, updateMaintenance, default);

		updateResult.Should().NotBeNull();
		updateResult.Devices.Should().ContainKey("a-server");

		// Attempt cleanup
		var deleteResponse = await client
			.Maintenance
			.DeleteAsync(result.Id, default);
	}

	[Fact]
	public async Task MaintenanceController_DeleteAsync_Succeeds()
	{
		var newMaintenance = new MaintenanceCreate { Name = "TestMaintenance2" };

		var result = await client
			.Maintenance
			.CreateAsync(newMaintenance, default);

		result.Should().NotBeNull();

		// Attempt cleanup
		var deleteResponse = await client
			.Maintenance
			.DeleteAsync(result.Id, default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.Content.Should().Be("OK");
	}

}
