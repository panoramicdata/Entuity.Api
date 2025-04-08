using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Update;

/// <summary>
/// Holds information for updating a View on a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840513258269-Config-Sets-Update-Rename-and-Delete-Views-RESTful-API#putupdate'/></para>
/// </summary>
public class ConfigurationSetViewUpdate
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

	/// <summary>
	/// The User Account that owns the User Group. Can be 'System'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Owner { get; set; }

	/// <summary>
	/// Collection of User Groups assigned to this View
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetViewUserGroup>? UserGroups { get; set; }

	/// <summary>
	/// Longitude of the View, as specified for Geographical Map mode
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public float? Longitude { get; set; }

	/// <summary>
	/// Latitude of the View, as specified for Geographical Map mode
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public float? Latitude { get; set; }

	/// <summary>
	/// Location name of the View, as specified for Geographical Map mode
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? LocationName { get; set; }

	/// <summary>
	/// If the View's Location is set manually
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? LocationManuallySet { get; set; }
}
