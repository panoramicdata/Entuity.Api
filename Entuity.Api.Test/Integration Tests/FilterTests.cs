using Entuity.Api.Models.PostItems;
using Entuity.Api.Models.UpdateItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class FilterTests(EntuityClient client) : TestFixture
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
	public async Task FiltersController_GetDomainFilterAsync_Succeeds()
	{
		var result = await client
			.Filters
			.GetAllDomainFiltersAsync(default);

		result.Should().NotBeNull();
		result.Items.Should().NotBeEmpty();

		foreach (var item in result.Items)
		{
			var detailedResult = await client
			.Filters
			.GetDomainFilterAsync(item.Id, default);

			detailedResult.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task FiltersController_CreateDomainFilterAsync_Succeeds()
	{
		var newDomainFilter = new DomainFilterCreate { Name = "Test Domain Filter" };

		var result = await client
			.Filters
			.CreateDomainFilterAsync(newDomainFilter, default);

		result.Should().NotBeNull();

		// Get Domain Filter ID
		var allDomainFilters = await client
			.Filters.GetAllDomainFiltersAsync(default);

		var createdDomainFilter = allDomainFilters.Items.FirstOrDefault(filter => filter.Name == newDomainFilter.Name);

		createdDomainFilter.Should().NotBeNull();

		// Attempt delete
		var deleteResult = await client
			.Filters
			.DeleteDomainFilterAsync(createdDomainFilter!.Id, default);
	}

	[Fact]
	public async Task FiltersController_UpdateDomainFilterAsync_Succeeds()
	{
		var newDomainFilter = new DomainFilterCreate { Name = "Test Domain Filter" };

		var result = await client
			.Filters
			.CreateDomainFilterAsync(newDomainFilter, default);

		result.Should().NotBeNull();

		// Get Domain Filter ID
		var allDomainFilters = await client
			.Filters.GetAllDomainFiltersAsync(default);

		var createdDomainFilter = allDomainFilters.Items.FirstOrDefault(filter => filter.Name == newDomainFilter.Name);

		createdDomainFilter.Should().NotBeNull();

		// Update
		var updatedDomainFilter = new DomainFilterUpdate { Name = "Updated Domain Filter" };

		var response = client
			.Filters
			.UpdateDomainFilterAsync(createdDomainFilter!.Id, updatedDomainFilter, default);

		// Attempt delete
		var deleteResult = await client
			.Filters
			.DeleteDomainFilterAsync(createdDomainFilter!.Id, default);
	}

	[Fact]
	public async Task FiltersController_DeleteDomainFilterAsync_Succeeds()
	{
		var newDomainFilter = new DomainFilterCreate { Name = "Test Domain Filter" };

		var result = await client
			.Filters
			.CreateDomainFilterAsync(newDomainFilter, default);

		result.Should().NotBeNull();

		// Get Domain Filter ID
		var allDomainFilters = await client
			.Filters.GetAllDomainFiltersAsync(default);

		var createdDomainFilter = allDomainFilters.Items.FirstOrDefault(filter => filter.Name == newDomainFilter.Name);

		createdDomainFilter.Should().NotBeNull();

		// Attempt delete
		var deleteResult = await client
			.Filters
			.DeleteDomainFilterAsync(createdDomainFilter!.Id, default);

		deleteResult.Should().NotBeNull();
		deleteResult.Content.Should().Be("OK");
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
	public async Task FiltersController_GetIncidentFilterAsync_Succeeds()
	{
		var result = await client
		.Filters
		.GetAllIncidentFiltersAsync(default);

		result.Should().NotBeNull();
		result.Items.Should().NotBeEmpty();

		foreach (var item in result.Items)
		{
			var detailedResult = await client
			.Filters
			.GetIncidentFilterAsync(item.Id, default);

			detailedResult.Should().NotBeNull();
		}
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
