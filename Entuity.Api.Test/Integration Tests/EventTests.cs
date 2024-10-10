using Entuity.Api.Enums;
using Entuity.Api.Query_Parameters;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class EventTests(EntuityClient client)
{
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
			State = State.Open
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
			State = State.Closed
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
			State = State.Finalized
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
			State = State.All
		};
		// Arrange
		var result = await client
			.Events
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}
}
