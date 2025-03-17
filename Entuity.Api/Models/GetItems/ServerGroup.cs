using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class ServerGroup : IGetItem
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
}

