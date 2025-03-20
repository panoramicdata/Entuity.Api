using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.ServerGroups.Post;

/// <summary>
/// Server Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840299631005-Config-Sets-List-and-Create-Config-Sets-RESTful-API#post'/></para>
/// </summary>
public class ServerGroupCreate
{
	/// <summary>
	/// Name of the config set
	/// </summary>
	public required string ServerGroupName { get; set; }

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
	/// Description of the config set, if any
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }

	/// <summary>
	/// If sync is paused in this config set, either 'true' or 'false'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncPaused { get; set; }
}

