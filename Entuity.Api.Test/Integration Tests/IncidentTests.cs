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
	public async Task IncidentsController_GetInformationIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Information, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetMinorIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Minor, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetMajorIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Major, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetSevereIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Severe, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetCriticalIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetBySeverity((int)SeverityRating.Critical, default);

		result.Should().NotBeNull();
	}
}
