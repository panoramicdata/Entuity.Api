using Entuity.Api.Enums;
using Entuity.Api.Query_Parameters;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class IncidentTests(EntuityClient client)
{
	[Fact]
	public async Task IncidentsController_GetAll_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetAllTypes_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetAllTypesAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithOpenedFromParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			OpenedFrom = 1727775926
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithOpenedToParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			ClosedTo = 1727775926
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithClosedFromParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			ClosedFrom = 1727775926
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithClosedToParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			ClosedTo = 1727775926
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingInfoParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			SeverityRating = SeverityRating.Info
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}
	[Fact]

	public async Task GetAllAsync_WithSeverityRatingMinorParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			SeverityRating = SeverityRating.Minor
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingMajorParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			SeverityRating = SeverityRating.Major
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingSevereParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			SeverityRating = SeverityRating.Severe
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingCriticalParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			SeverityRating = SeverityRating.Critical
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithSeverityRatingMultipleValuesParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			SeverityRating = SeverityRating.Info | SeverityRating.Minor
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateOpenParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			State = IncidentState.Open
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateClosedParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			State = IncidentState.Closed
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateFinalizedParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			State = IncidentState.Expire
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllAsync_WithStateAllParameter_Succeeds()
	{
		var parameters = new IncidentsFilter
		{
			State = IncidentState.All
		};
		// Arrange
		var result = await client
			.Incidents
			.GetAllAsync(parameters, default);

		result.Should().NotBeNull();
	}
}
