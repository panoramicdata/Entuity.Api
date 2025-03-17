using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class ServerGroupSummaryInformation : IGetItem
{
	public bool SyncUsers { get; set; }

	public bool SyncUserGroups { get; set; }

	public bool SyncViews { get; set; }

	public Guid ServerGroupId { get; set; }

	public string ServerGroupName { get; set; } = string.Empty;

	public string Description { get; set; } = string.Empty;

	public int CreationTimeSec { get; set; }

	public string CreatedBy { get; set; } = string.Empty;

	public bool SyncPaused { get; set; }

	public int ConfigurationChangeId { get; set; }

	public int LastModifiedSec { get; set; }

	public string LastModifiedBy { get; set; } = string.Empty;

	public int MemberCount { get; set; }

	public required SyncStatus SyncStatus { get; set; }

	public string SyncStatusCategory { get; set; } = string.Empty;
}
