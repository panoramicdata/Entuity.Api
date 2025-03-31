using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.ConfigurationSet.Get;

/// <summary>
/// Holds simple information about a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840299631005-Config-Sets-List-and-Create-Config-Sets-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSet : IGetItem
{
	/// <summary>
	/// If sync of users is enabled in this config set, either 'true' or 'false'
	/// </summary>
	public bool SyncUsers { get; set; }

	/// <summary>
	/// If sync of user groups is enabled in this config set, either 'true' or 'false'
	/// </summary>
	public bool SyncUserGroups { get; set; }

	/// <summary>
	/// If sync of Views is enabled in this config set, either 'true' or 'false'
	/// </summary>
	public bool SyncViews { get; set; }

	/// <summary>
	/// ID of the config set
	/// </summary>
	public Guid ServerGroupId { get; set; }

	/// <summary>
	/// Name of the config set
	/// </summary>
	public string ServerGroupName { get; set; } = string.Empty;

	/// <summary>
	/// Description of the config set, if any
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp of when the config set was created
	/// </summary>
	public int CreationTimeSec { get; set; }

	/// <summary>
	/// User who created the config set
	/// </summary>
	public string CreatedBy { get; set; } = string.Empty;

	/// <summary>
	/// If synchronization of the config set is paused
	/// </summary>
	public bool SyncPaused { get; set; }
}

