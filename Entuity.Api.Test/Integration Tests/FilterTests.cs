using Entuity.Api.Models;
using Entuity.Api.Models.FiltersData.Post;
using Entuity.Api.Models.FiltersData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;

public class FilterTests(EntuityClient client) : TestFixture
{
	private sealed record FilterApi(
		string Label,
		Func<Task<IReadOnlyList<(string Id, string? Name)>>> ListAsync,
		Func<string, Task<object>> GetAsync,
		Func<string, Task<object>> CreateAsync,
		Func<string, string, Task<object>> UpdateAsync,
		Func<string, Task<Message>> DeleteAsync);

	private FilterApi Domain => new(
		"Test Domain Filter",
		async () => (await client.Filters.GetAllDomainFiltersAsync(default)).Items.Select(i => (i.Id, (string?)i.Name)).ToList(),
		async id => await client.Filters.GetDomainFilterAsync(id, default),
		async name => await client.Filters.CreateDomainFilterAsync(new DomainFilterCreate { Name = name }, default),
		async (id, name) => await client.Filters.UpdateDomainFilterAsync(id, new DomainFilterUpdate { Name = name }, default),
		id => client.Filters.DeleteDomainFilterAsync(id, default));

	private FilterApi Incident => new(
		"Test Incident Filter",
		async () => (await client.Filters.GetAllIncidentFiltersAsync(default)).Items.Select(i => (i.Id, (string?)i.Name)).ToList(),
		async id => await client.Filters.GetIncidentFilterAsync(id, default),
		async name => await client.Filters.CreateIncidentFilterAsync(new IncidentFilterCreate { Name = name }, default),
		async (id, name) => await client.Filters.UpdateIncidentFilterAsync(id, new IncidentFilterUpdate { Name = name }, default),
		id => client.Filters.DeleteIncidentFilterAsync(id, default));

	private FilterApi Event => new(
		"Test Event Filter",
		async () => (await client.Filters.GetAllEventFiltersAsync(default)).Items.Select(i => (i.Id, (string?)i.Name)).ToList(),
		async id => await client.Filters.GetEventFilterAsync(id, default),
		async name => await client.Filters.CreateEventFilterAsync(new EventFilterCreate { Name = name }, default),
		async (id, name) => await client.Filters.UpdateEventFilterAsync(id, new EventFilterUpdate { Name = name }, default),
		id => client.Filters.DeleteEventFilterAsync(id, default));

	[Fact]
	public Task FiltersController_GetAllDomainFiltersAsync_Succeeds() => GetAllAsync(Domain);

	[Fact]
	public Task FiltersController_GetDomainFilterAsync_Succeeds() => GetEachAsync(Domain);

	[Fact]
	public Task FiltersController_CreateDomainFilterAsync_Succeeds() => CreateAsync(Domain);

	[Fact]
	public Task FiltersController_UpdateDomainFilterAsync_Succeeds() => UpdateAsync(Domain);

	[Fact]
	public Task FiltersController_DeleteDomainFilterAsync_Succeeds() => DeleteAsync(Domain);

	[Fact]
	public Task FiltersController_GetAllIncidentFiltersAsync_Succeeds() => GetAllAsync(Incident);

	[Fact]
	public Task FiltersController_CreateIncidentFilterAsync_Succeeds() => CreateAsync(Incident);

	[Fact]
	public Task FiltersController_UpdateIncidentFilterAsync_Succeeds() => UpdateAsync(Incident);

	[Fact]
	public Task FiltersController_DeleteIncidentFilterAsync_Succeeds() => DeleteAsync(Incident);

	[Fact]
	public Task FiltersController_GetIncidentFilterAsync_Succeeds() => GetEachAsync(Incident);

	[Fact]
	public Task FiltersController_GetAllEventFiltersAsync_Succeeds() => GetAllAsync(Event);

	[Fact]
	public Task FiltersController_GetEventFilterAsync_Succeeds() => GetEachAsync(Event);

	[Fact]
	public Task FiltersController_CreateEventFilterAsync_Succeeds() => CreateAsync(Event);

	[Fact]
	public Task FiltersController_UpdateEventFilterAsync_Succeeds() => UpdateAsync(Event);

	[Fact]
	public Task FiltersController_DeleteEventFilterAsync_Succeeds() => DeleteAsync(Event);

	private static async Task GetAllAsync(FilterApi api)
	{
		var items = await api.ListAsync();

		items.Should().NotBeEmpty();
	}

	private static async Task GetEachAsync(FilterApi api)
	{
		var items = await api.ListAsync();

		items.Should().NotBeEmpty();

		foreach (var (id, _) in items)
		{
			(await api.GetAsync(id)).Should().NotBeNull();
		}
	}

	private static async Task CreateAsync(FilterApi api)
	{
		var id = await CreateFilterAsync(api);

		await api.DeleteAsync(id);
	}

	private static async Task UpdateAsync(FilterApi api)
	{
		var id = await CreateFilterAsync(api);

		(await api.UpdateAsync(id, $"{api.Label} Updated {Guid.NewGuid().ToString()[..5]}")).Should().NotBeNull();

		await api.DeleteAsync(id);
	}

	private static async Task DeleteAsync(FilterApi api)
	{
		var id = await CreateFilterAsync(api);

		var deleteResult = await api.DeleteAsync(id);

		deleteResult.Should().NotBeNull();
		deleteResult.Content.Should().Be("OK");
	}

	private static async Task<string> CreateFilterAsync(FilterApi api)
	{
		var name = $"{api.Label} {Guid.NewGuid().ToString()[..10]}";

		(await api.CreateAsync(name)).Should().NotBeNull();

		var created = (await api.ListAsync()).FirstOrDefault(filter => filter.Name == name);

		created.Id.Should().NotBeNull();

		return created.Id;
	}
}
