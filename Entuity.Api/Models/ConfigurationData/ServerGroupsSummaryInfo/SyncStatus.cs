namespace Entuity.Api.Models.ConfigurationData.ServerGroupsSummaryInfo;

/// <summary>
/// Contains information about the synchronization status of a configuration set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840342484253-Config-Sets-Summary-Info-RESTful-API#get'/></para>
/// </summary>
public class SyncStatus
{
	/// <summary>
	/// ID of the current configuration change, referred to in the table under the Sync History tab on the Multi-Server Configuration page. Each time a config set is updated, the set gains a new configuration change ID. This ID is an auto-incrementing number
	/// </summary>
	public int ConfigurationChangeId { get; set; }

	/// <summary>
	/// IDs of the servers in the config set
	/// </summary>
	public List<Guid>? MemberServerIds { get; set; }

	/// <summary>
	/// IDs of the servers currently synced
	/// </summary>
	public List<Guid>? ServerIdsAlreadySynced { get; set; }

	/// <summary>
	/// IDs of the servers currently queued to sync
	/// </summary>
	public List<Guid>? ServerIdsQueuedToSync { get; set; }

	/// <summary>
	/// IDs of the servers that have failed to sync, and the explanatory error message for each server that has failed to sync
	/// </summary>
	public List<Guid>? FailedServerIdsToErrorMsg { get; set; }

	/// <summary>
	/// If synchronization of the config set is paused
	/// </summary>
	public bool SyncPaused { get; set; }
}
