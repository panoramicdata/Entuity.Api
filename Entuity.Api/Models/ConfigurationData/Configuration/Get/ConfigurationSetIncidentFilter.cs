namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Holds information about an Incident Filter that are applied to a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840530161309-Config-Sets-Content-Filters-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetIncidentFilter
{
	/// <summary>
	/// The Unique Identifier of this Filter
	/// </summary>
	public string FilterUUID { get; set; } = string.Empty;

	/// <summary>
	/// The Name of this Filter
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Array of incidents permitted by the filter. Left null if there is no data
	/// </summary>
	public IEnumerable<string>? SelectedNames { get; set; }

	/// <summary>
	/// Should the filter include devices not under management
	/// </summary>
	public bool PassIP { get; set; }
}
