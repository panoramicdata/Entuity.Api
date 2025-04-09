using Entuity.Api.Models.ConfigurationData.Configuration.Get;
using Entuity.Api.Models.ConfigurationData.Sets.Get;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Sets.Post;

/// <summary>
/// Holds detailed information about a Configuration Set used to populate a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetDetailedCreate
{
	/// <summary>
	/// Any Global user settings that apply to this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public object? GlobalUserSettings { get; set; }

	/// <summary>
	/// Any Password Complexity settings that apply to this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public object? PasswordComplexitySettings { get; set; }

	/// <summary>
	/// Colleciton of Users that are part of this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetUser>? Users { get; set; }

	/// <summary>
	/// Collection of User Groups that are part of this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetUserGroup>? UserGroups { get; set; }

	/// <summary>
	/// Collection of Views that are part of this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetView>? Views { get; set; }

	/// <summary>
	/// Collection of Content Filters that are part of this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetContentFilter>? ContentFilters { get; set; }

	/// <summary>
	/// Collection of Event Filters that are part of this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetEventFilter>? EventFilters { get; set; }

	/// <summary>
	/// Collection of Incident Filters that are part of this Configuration Set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ConfigurationSetIncidentFilter>? IncidentFilters { get; set; }
}
