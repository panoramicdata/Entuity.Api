using Entuity.Api.Models.PostItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class ViewTests(EntuityClient client) : TestFixture
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

	[Fact]
	public async Task ViewsController_CreateAsync_Succeeds()
	{
		var newView = new ViewCreate
		{
			Name = "Test View"
		};

		var response = await client
			.Views
			.CreateAsync(newView, default);

		response.Should().NotBeNull();

		// Get the Id of the created view
		var id = response.Items.FirstOrDefault(item => item.DisplayName.Contains(newView.Name))?.Id;

		id.Should().NotBeNull();

		// Clean up
		await client
			.Views
			.DeleteAsync(id!, default);
	}

	[Fact]
	public async Task ViewsController_DeleteAsync_Succeeds()
	{
		var newView = new ViewCreate
		{
			Name = "Test View"
		};

		var response = await client
			.Views
			.CreateAsync(newView, default);

		response.Should().NotBeNull();

		// Get the Id of the created view
		var id = response.Items.FirstOrDefault(item => item.DisplayName.Contains(newView.Name))?.Id;

		id.Should().NotBeNull();

		// Clean up
		var deleteResponse = await client
			.Views
			.DeleteAsync(id!, default);

		deleteResponse.IsSuccessStatusCode.Should().BeTrue();
	}

	[Fact]
	public async Task ViewsController_GetObjectsAsync_Succeeds()
	{
		var views = await client
		.Views
		.GetAllAsync(default);

		foreach (var view in views.Items)
		{
			var viewObjects = await client
				.Views
				.GetObjectsAsync(view.Id, default);

			viewObjects.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task ViewsController_UpdateObjectsAsync_Succeeds()
	{
		var newView = new ViewCreate
		{
			Name = "Test View"
		};

		var response = await client
			.Views
			.CreateAsync(newView, default);

		response.Should().NotBeNull();

		// Get the Id of the created view
		var id = response
			.Items
			.FirstOrDefault(item => item.DisplayName.Contains(newView.Name))?.Id;

		id.Should().NotBeNull();


		// Update the view
		var updateResponse = await client
			.Views
			.UpdateObjectsAsync(id!, [1, 2, 3], default);

		updateResponse.Should().NotBeNull();

		// Clean up
		await client
			.Views
			.DeleteAsync(id!, default);
	}

	[Fact]
	public async Task ViewsController_DeleteObjectsAsync_Succeeds()
	{
		var newView = new ViewCreate
		{
			Name = "Test View"
		};

		var response = await client
			.Views
			.CreateAsync(newView, default);

		response.Should().NotBeNull();

		// Get the Id of the created view
		var id = response
			.Items
			.FirstOrDefault(item => item.DisplayName.Contains(newView.Name))?.Id;

		id.Should().NotBeNull();


		// Update the view
		var updateResponse = await client
			.Views
			.UpdateObjectsAsync(id!, [1, 2, 3], default);

		updateResponse.Should().NotBeNull();


		// Delete the objects 1 and 2
		var deleteResponse = await client
			.Views
			.DeleteObjectsAsync(id!, [1, 2], default);

		deleteResponse.Should().NotBeNull();
		deleteResponse.Items.Should().HaveCount(1);

		// Clean up
		await client
			.Views
			.DeleteAsync(id!, default);
	}
}
