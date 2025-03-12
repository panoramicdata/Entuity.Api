using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class FilterTests(EntuityClient client)
{

	[Fact]
	public async Task FiltersController_GetAllDomainFiltersAsync_Succeeds()
	{
		var result = await client
			.Filters
			.GetAllDomainFiltersAsync(default);

		result.Should().NotBeNull();
		result.Items.Should().NotBeEmpty();
	}

	[Fact]
	public async Task FiltersController_GetAllIncidentFiltersAsync_Succeeds()
	{
		var result = await client
		.Filters
		.GetAllIncidentFiltersAsync(default);

		result.Should().NotBeNull();
		result.Items.Should().NotBeEmpty();
	}

	[Fact]
	public async Task FiltersController_GetAllEventFiltersAsync_Succeeds()
	{
		var result = await client
		.Filters
		.GetAllEventFiltersAsync(default);

		result.Should().NotBeNull();
		result.Items.Should().NotBeEmpty();
	}
}
