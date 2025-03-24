using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.ServerGroupsSummaryInfo.Get;

/// <summary>
/// Provides summary information for a Config Set
/// <para>See <a href=''/></para>
/// </summary>
public class ServerGroupSummaryInformation : IGetItem
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

	/// <summary>
	/// D of the current configuration change, referred to in the table under the Sync History tab on the Multi-Server Configuration page. Each time a config set is updated, the set gains a new configuration change ID. This ID is an auto-incrementing number
	/// </summary>
	public int ConfigurationChangeId { get; set; }

	/// <summary>
	/// Timestamp of when the config set was last modified
	/// </summary>
	public int LastModifiedSec { get; set; }

	/// <summary>
	/// User who last modified the config set
	/// </summary>
	public string LastModifiedBy { get; set; } = string.Empty;

	/// <summary>
	/// Number of servers in the config set
	/// </summary>
	public int MemberCount { get; set; }

	/// <inheritdoc cref="ServerGroupsSummaryInfo.SyncStatus"/>
	public required SyncStatus SyncStatus { get; set; }

	/// <summary>
	/// Description of the config set's current sync status
	/// </summary>
	public string SyncStatusCategory { get; set; } = string.Empty;
}
