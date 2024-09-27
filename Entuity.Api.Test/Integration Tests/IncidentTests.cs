using Entuity.Api.Enums;
using FluentAssertions;

namespace Entuity.Api.Test;

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
	public async Task GetBySeverity_SeverityRatingOf1_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Information, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetBySeverity_SeverityRatingOf2_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Minor, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetBySeverity_SeverityRatingOf4_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Major, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetBySeverity_SeverityRatingOf8_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Severe, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetBySeverity_SeverityRatingOf16_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Critical, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetOpen_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetOpen(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetClosed_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetClosed(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetExpired_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetExpired(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetNonExpired_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetNonExpired(default);

		result.Should().NotBeNull();
	}
}
