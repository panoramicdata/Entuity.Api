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
	public async Task GetAllAsync_WithOpenedFromParameter_Succeeds()
	{
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
	public async Task GetAllAsync_WithStateOpenParameter_Succeeds()
	{
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
		var parameters = new EventParams
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
