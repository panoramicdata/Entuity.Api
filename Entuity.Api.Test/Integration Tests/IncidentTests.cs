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
	public async Task IncidentsController_GetInfoIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetInfoIncidents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetMinorIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetMinorIncidents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetMajorIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetMajorIncidents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetSevereIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetSevereIncidents(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetCriticalIncidents_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetCriticalIncidents(default);

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

	[Fact]
	public async Task IncidentsController_GetOpenedFrom_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetOpenedFrom(1727442360, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetOpenedTo_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetOpenedTo(1727447521, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetClosedFrom_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetClosedFrom(1727419871, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetClosedTo_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetClosedTo(1727419871, default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task IncidentsController_GetOpenedBetween_Succeeds()
	{
		// Arrange
		var result = await client
			.Incidents
			.GetOpenedBetween(1727419871, 1727442360, default);

		result.Should().NotBeNull();
	}
}
