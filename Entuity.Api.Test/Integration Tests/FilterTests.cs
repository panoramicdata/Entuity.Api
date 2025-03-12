using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class FilterTests(EntuityClient client)
{

	[Fact]
	public async Task FiltersController_GetAllDomainFiltersAsync_Succeeds()
	{
		var result = await
			client.Filters
			.GetAllDomainFiltersAsync(default);

		result.Should().NotBeNull();
		result.Items.Should().NotBeEmpty();
	}
}
