using Entuity.Api.Enums;
using Entuity.Api.Models.EventsData.Post;
using Entuity.Api.QueryParameters;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class EventTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task EventsController_CreateAsync_Succeeds()
	{
		var eventTypes = await client
			.Events
			.GetAllTypesAsync(default);

		eventTypes.Should().NotBeNull();

		// Create a new event
		var randomGuid = Guid.NewGuid().ToString()[..5];
		var newEvent = new EventCreate()
		{
			Reason = $"API test {randomGuid}",
			Name = $"Event for Test {randomGuid}",
			Source = $"Event Source for {randomGuid}",
			EventTypeId = eventTypes.Items.First().Id,
			ObjectKeyInfo = new() { SwId = 12345, CompId = new() { Ids = [4096, 0, 0, 0] } },
			ExternalId = "12"
		};

		// Act
		var result = await client
			.Events
			.CreateAsync(newEvent, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task EventsController_GetAllTypesAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.Events
			.GetAllTypesAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithOpenedFromParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			OpenedFrom = 1727775926
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithOpenedToParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			ClosedTo = 1727775926
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithClosedFromParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			ClosedFrom = 1727775926
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithClosedToParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			ClosedTo = 1727775926
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingInfoParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			SeverityRating = SeverityRating.Info
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}
	[Fact]

	public async Task GetAllAsync_WithSeverityRatingMinorParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			SeverityRating = SeverityRating.Minor
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingMajorParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			SeverityRating = SeverityRating.Major
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingSevereParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			SeverityRating = SeverityRating.Severe
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingCriticalParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			SeverityRating = SeverityRating.Critical
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingMultipleValuesParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			SeverityRating = SeverityRating.Info | SeverityRating.Minor
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateOpenParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			State = EventState.Open
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateClosedParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			State = EventState.Closed
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateFinalizedParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			State = EventState.Finalized
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateAllParameter_Succeeds()
	{
		var parameters = new EventsFilter
		{
			State = EventState.All
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}
}
