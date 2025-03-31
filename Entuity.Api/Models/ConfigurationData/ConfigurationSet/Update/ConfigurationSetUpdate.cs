using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.ConfigurationSet.Update;

/// <summary>
/// Update a server group.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840302882845-Config-Sets-Update-and-Delete-Config-Sets-RESTful-API#put1'/></para>
/// </summary>
public class ConfigurationSetUpdate
{
	/// <summary>
	/// Name of the config set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ServerGroupName { get; set; }

	/// <summary>
	/// If sync of users is enabled in this config set, either 'true' or 'false'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncUsers { get; set; }

	/// <summary>
	/// If sync of user groups is enabled in this config set, either 'true' or 'false'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncUserGroups { get; set; }

	/// <summary>
	/// If sync of Views is enabled in this config set, either 'true' or 'false'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncViews { get; set; }

	/// <summary>
	/// Description of the config set
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }

	/// <summary>
	/// If sync of devices is enabled in this config set, either 'true' or 'false'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncPaused { get; set; }
}

