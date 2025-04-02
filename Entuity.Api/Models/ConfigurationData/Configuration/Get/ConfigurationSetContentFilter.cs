using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Holds information about a Content Filter that are applied to a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840530161309-Config-Sets-Content-Filters-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetContentFilter : IGetItem
{
	/// <summary>
	/// The Unique Identifier of this Filter
	/// </summary>
	public string FilterUUID { get; set; } = string.Empty;

	/// <summary>
	/// The Unique Name of this Filter
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Collection of rules that this filter refers to
	/// </summary>
	public IEnumerable<ConfigurationSetContentFilterRule>? Rules { get; set; }
}
