namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Holds information about an Event Filter that are applied to a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840565049245-Config-Sets-Event-Filters-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetEventFilter
{
	/// <summary>
	/// The Unique Identifier of this Filter
	/// </summary>
	public string FilterUUID { get; set; } = string.Empty;

	/// <summary>
	/// The name of this Filter
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Array of incidents permitted by the filter. Left null if there is no data
	/// </summary>
	public IEnumerable<string>? SelectedNames { get; set; }

	/// <summary>
	/// If the filter should include devices not under management
	/// </summary>
	public bool PassIP { get; set; }
}
