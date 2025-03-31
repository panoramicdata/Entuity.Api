namespace Entuity.Api.Models.ConfigurationData.ServerGroupConfig.Get;

/// <summary>
/// Holds Settings for the server group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationInformation
{
	/// <summary>
	/// Any global user settings that apply to this config set
	/// </summary>
	public object? GlobalUserSettings { get; set; }

	/// <summary>
	/// Any password complexity settings that apply to this config set
	/// </summary>
	public object? PasswordComplexitySettings { get; set; }

	/// <summary>
	/// Collection of users
	/// </summary>
	public IEnumerable<ConfigurationSetUser> Users { get; set; } = [];

	/// <summary>
	/// Collection of user groups
	/// </summary>
	public IEnumerable<object> UserGroups { get; set; } = [];

	/// <summary>
	/// Collection of views
	/// </summary>
	public IEnumerable<UserGroupView> Views { get; set; } = [];

	/// <summary>
	/// Collection of content filters
	/// </summary>
	public IEnumerable<object> ContentFilters { get; set; } = [];

	/// <summary>
	/// Collection of event filters
	/// </summary>
	public IEnumerable<object> EventFilters { get; set; } = [];

	/// <summary>
	/// Collection of incident filters
	/// </summary>
	public IEnumerable<object> IncidentFilters { get; set; } = [];
}
