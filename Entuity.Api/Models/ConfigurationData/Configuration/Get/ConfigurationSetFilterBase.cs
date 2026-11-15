namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Common information about a filter that is applied to a Configuration Set
/// </summary>
public abstract class ConfigurationSetFilterBase
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
	/// Array of names permitted by the filter. Left null if there is no data
	/// </summary>
	public IEnumerable<string>? SelectedNames { get; set; }

	/// <summary>
	/// If the filter should include devices not under management
	/// </summary>
	public bool PassIP { get; set; }
}
