using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ViewTests(EntuityClient client)
{
	[Fact]
	public async Task GetAllViewsAsync()
	{
		var views = await client
			.Views
			.GetAllAsync(CancellationToken.None);

		views.Should().NotBeNull();
	}
}
