using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Post;

/// <summary>
/// Holds information for creating or updating a Content Filter in a Config Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840530161309-Config-Sets-Content-Filters-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetContentFilterCreate
{
	/// <summary>
	/// The name of this Filter
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// A collection of rules defining a Filter
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetContentFilterRule>? Rules { get; set; }
}
