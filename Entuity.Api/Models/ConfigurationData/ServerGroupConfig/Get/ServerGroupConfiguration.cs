namespace Entuity.Api.Models.ConfigurationData.ServerGroupConfig.Get;

/// <summary>
/// Holds Configuration for a Server Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#get'/></para>
/// </summary>
public class ServerGroupConfiguration
{
	/// <summary>
	/// If sync of users is enabled in this config set, either 'true' or 'false'.
	/// </summary>
	public bool SyncUsers { get; set; }

	/// <summary>
	/// If sync of user groups is enabled in this config set, either 'true' or 'false'.
	/// </summary>
	public bool SyncUserGroups { get; set; }

	/// <summary>
	/// If sync of views is enabled in this config set, either 'true' or 'false'.
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

	/// <inheritdoc cref="Get.Configuration"/>
	public required Configuration Configuration { get; set; }

	/// <summary>
	/// ID of the current configuration change, referred to in the table under the Sync History tab on the Multi-Server Configuration page. Each time a config set is updated, the set gains a new configuration change ID. This ID is an auto-incrementing number
	/// </summary>
	public int ConfigurationChangeId { get; set; }

	/// <summary>
	/// timestamp of when the config set was last modified
	/// </summary>
	public int LastModifiedSec { get; set; }

	/// <summary>
	/// User who last modified the config set
	/// </summary>
	public string LastModifiedBy { get; set; } = string.Empty;
}
