using Entuity.Api.Models.PostItems;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class DataAccessTemplatesTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task DataAccessTemplatesController_GetAllAsync_Succeeds()
	{
		// Arrange
		var result = await client
			.DataAccessTemplates
			.GetAllAsync(default);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task DataAccessTemplatesController_CreateAsync_Succeeds()
	{
		var dataAccessTemplateCreate = new DataAccessTemplateCreate
		{
			Name = "Test Template"
		};

		var result = await client
			.DataAccessTemplates
			.CreateAsync(dataAccessTemplateCreate, default);

		result.Should().NotBeNull();

		// Attempt delete
		await client
			.DataAccessTemplates
			.DeleteAsync(dataAccessTemplateCreate.Name, default);
	}

	[Fact]
	public async Task DataAccessTemplatesController_DeleteAsync_Succeeds()
	{
		var dataAccessTemplateCreate = new DataAccessTemplateCreate
		{
			Name = "Test Template"
		};

		var result = await client
			.DataAccessTemplates
			.CreateAsync(dataAccessTemplateCreate, default);

		result.Should().NotBeNull();

		// Attempt delete
		var response = await client
			.DataAccessTemplates
			.DeleteAsync(dataAccessTemplateCreate.Name, default);

		response.IsSuccessStatusCode.Should().BeTrue();
	}
}
