using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class ViewDetailed : Entity<string>, IReturnItem
{
	public Guid ServerId { get; set; }

	public string Path { get; set; } = string.Empty;

	public string DisplayName { get; set; } = string.Empty;

	public string BaseViewAggregation { get; set; } = string.Empty;

	public IEnumerable<string> BaseViewPaths { get; set; } = [];

	public string DomainFilterName { get; set; } = string.Empty;

	public bool ManuallyPopulated { get; set; }

	public string EventFilterName { get; set; } = string.Empty;

	public string IncidentFilterName { get; set; } = string.Empty;

	public string Owner { get; set; } = string.Empty;

	public IEnumerable<AccessGroup> AccessGroups { get; set; } = [];

	public IEnumerable<object> ImplicitAccessGroups { get; set; } = [];

	public IEnumerable<object> ImplicitAccessUsers { get; set; } = [];

	public string Location { get; set; } = string.Empty;

	public float Lat { get; set; }

	public float Lng { get; set; }
}
