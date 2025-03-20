namespace Entuity.Api.Models.ConfigurationData.ServerGroupsSummaryInfo;

public class SyncStatus
{
	public int ConfigurationChangeId { get; set; }

	public List<Guid>? MemberServerIds { get; set; }

	public List<Guid>? ServerIdsAlreadySynced { get; set; }

	public List<Guid>? ServerIdsQueuedToSync { get; set; }

	public List<Guid>? FailedServerIdsToErrorMsg { get; set; }

	public bool SyncPaused { get; set; }
}
