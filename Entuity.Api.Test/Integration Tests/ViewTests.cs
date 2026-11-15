using Entuity.Api.Models.ViewsData.Post;
using Entuity.Api.Models.ViewsData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ViewTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task ViewsController_GetAllViewsAsync_Succeeds()
	{
		var views = await client.Views.GetAllAsync(default);

		views.Should().NotBeNull();
	}

	[Fact]
	public async Task ViewsController_GetAsync_Succeeds()
	{
		var views = await client.Views.GetAllAsync(default);

		foreach (var view in views.Items)
		{
			(await client.Views.GetAsync(view.Id, default)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ViewsController_CreateAsync_Succeeds()
	{
		var id = await CreateViewAsync();

		await client.Views.DeleteAsync(id, default);
	}

	[Fact]
	public async Task ViewsController_UpdateAsync_Succeeds()
	{
		var id = await CreateViewAsync();

		var updateResponse = await client.Views.UpdateAsync(id, new ViewUpdate { Name = "Updated Test View" }, default);

		updateResponse.Should().NotBeNull();

		await client.Views.DeleteAsync(id, default);
	}

	[Fact]
	public async Task ViewsController_DeleteAsync_Succeeds()
	{
		var id = await CreateViewAsync();

		var deleteResponse = await client.Views.DeleteAsync(id, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
	}

	[Fact]
	public async Task ViewsController_GetObjectsAsync_Succeeds()
	{
		var views = await client.Views.GetAllAsync(default);

		foreach (var view in views.Items)
		{
			(await client.Views.GetObjectsAsync(view.Id, default)).Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ViewsController_UpdateObjectsAsync_Succeeds()
	{
		var id = await CreateViewAsync();

		(await client.Views.UpdateObjectsAsync(id, [1, 2, 3], default)).Should().NotBeNull();

		await client.Views.DeleteAsync(id, default);
	}

	[Fact]
	public async Task ViewsController_DeleteObjectsAsync_Succeeds()
	{
		var id = await CreateViewAsync();

		(await client.Views.UpdateObjectsAsync(id, [1, 2, 3], default)).Should().NotBeNull();

		var deleteResponse = await client.Views.DeleteObjectsAsync(id, [1, 2], default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.Items.Should().HaveCount(1);

		await client.Views.DeleteAsync(id, default);
	}

	private async Task<string> CreateViewAsync()
	{
		var newView = new ViewCreate
		{
			Name = $"Test View {Guid.NewGuid().ToString()[..10]}"
		};

		var response = await client.Views.CreateAsync(newView, default);

		response.Should().NotBeNull();

		var id = response.Items.FirstOrDefault(item => item.DisplayName.Contains(newView.Name))?.Id;

		id.Should().NotBeNull();

		return id!;
	}
}
