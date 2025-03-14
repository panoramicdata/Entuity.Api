using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ViewTests(EntuityClient client)
{
	[Fact]
	public async Task ViewsController_GetAllViewsAsync_Succeeds()
	{
		var views = await client
			.Views
			.GetAllAsync(default);

		views.Should().NotBeNull();
	}

	[Fact]
	public async Task ViewsController_GetAsync_Succeeds()
	{
		var views = await client
			.Views
			.GetAllAsync(default);

		foreach (var view in views.Items)
		{
			var viewDetailed = await client
				.Views
				.GetAsync(view.Id, default);

			viewDetailed.Should().NotBeNull();
		}
	}
}
