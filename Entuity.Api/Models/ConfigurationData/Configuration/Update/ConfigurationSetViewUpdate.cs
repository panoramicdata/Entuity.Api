using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Update;

/// <summary>
/// Holds information for updating a View on a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840513258269-Config-Sets-Update-Rename-and-Delete-Views-RESTful-API#putupdate'/></para>
/// </summary>
public class ConfigurationSetViewUpdate : ConfigurationSetViewWriteBase
{
	/// <summary>
	/// The name of the View
	/// </summary>
	public required string ViewName { get; set; }

	/// <summary>
	/// Name of the Event Filter applied to this View
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? EventFilter { get; set; }

	/// <summary>
	/// Name of the Incident Filter applied to this View
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("situationFilter")]
	public string? IncidentFilter { get; set; }
}
