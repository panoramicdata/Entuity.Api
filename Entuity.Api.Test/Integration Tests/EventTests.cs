using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class EventTests(EntuityClient client)
{
	[Fact]
	public async Task EventsController_GetAll_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetEventsOpenedFrom_ValidEpochTime_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetEventsOpenedFrom(1727775926, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetEventsOpenedTo_ValidEpochTime_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetEventsOpenedTo(1727775926, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetEventsClosedFrom_ValidEpochTime_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetEventsClosedFrom(1727775926, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetEventsClosedTo_ValidEpochTime_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetEventsClosedTo(1727775926, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetInfoEvents_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetInfoEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetMinorEvents_Succeeds()
	{

		// Arrange
		var result = await client
			.Events
			.GetMinorEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetMajorEvents_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetMajorEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetSevereEvents_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetSevereEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetCriticalEvents_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetCriticalEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetOpenEvents_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetOpenEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetClosedEvents_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetClosedEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetFinalizedEvents_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetFinalizedEvents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetAllTypes_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetAllTypesAsync(default);

		result.Should().NotBeNull();
	}
}
