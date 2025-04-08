using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Post;

/// <summary>
/// Holds information needed for creating a new Configuration Set View.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840534002461-Config-Sets-List-and-Add-Views-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetViewCreate
{
	/// <summary>
	/// Name of this View, which is assigned to a Configuration Set
	/// </summary>
	public required string ViewName { get; set; }

	/// <summary>
	/// Names of the View that form the base of this Current View
	/// </summary>
	public required IEnumerable<string> BaseViewNames { get; set; }

	/// <summary>
	/// The name of the Domain Filter that is applied to this View
	/// </summary>
	public required string DomainFilter { get; set; }

	/// <summary>
	/// The name of the Event Filter that is applied to this View
	/// </summary>
	public required string EventFilter { get; set; }

	/// <summary>
	/// The name of the Incident Filter that is applied to this View
	/// </summary>
	[JsonPropertyName("situationFilter")]
	public required string IncidentFilter { get; set; }

	/// <summary>
	/// User account that owns the User Group. Can be 'System'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Owner { get; set; }

	/// <summary>
	/// If View Content is based on Union of the Views or Intersection of the Views
	/// </summary>
	public required int BaseViewType { get; set; }

	/// <summary>
	/// If View Content is automatically (union/intersection) or manually determined
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ContentsType { get; set; }

	/// <summary>
	/// Collection of User Groups that have access to this View
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
	/// Whether the location of the View is manually set or automatically determined
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? LocationManuallySet { get; set; }
}
