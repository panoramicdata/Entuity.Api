using System.Collections;

namespace Entuity.Api.Models.ConfigurationData.ServerGroupConfig;

public class UserGroupView
{
	public string ViewName { get; set; } = string.Empty;

	public int BaseViewType { get; set; }

	public IEnumerable? BaseViewNames { get; set; }

	public int ContentsType { get; set; }

	public string DomainFilter { get; set; } = string.Empty;

	public string EventFilter { get; set; } = string.Empty;

	public string SituationFilter { get; set; } = string.Empty;

	public string Owner { get; set; } = string.Empty;

	public IEnumerable<AccessGroup> UserGroups { get; set; } = [];

	public float Longitude { get; set; }

	public float Latitude { get; set; }

	public object? LocationName { get; set; }

	public bool LocationManuallySet { get; set; }

	public string ViewUUID { get; set; } = string.Empty;
}
