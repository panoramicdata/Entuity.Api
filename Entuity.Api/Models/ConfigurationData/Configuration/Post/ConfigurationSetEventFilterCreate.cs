using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Post;

/// <summary>
/// Holds information for creating and updating an Event Filter in a Config Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840565049245-Config-Sets-Event-Filters-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetEventFilterCreate
{
	/// <summary>
	/// The name of the Incident Filter
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Array of Incidents that are permitted by this Filter
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<string>? SelectedNames { get; set; }

	/// <summary>
	/// Whether IP filters are Passed
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? Flags { get; set; }
}
