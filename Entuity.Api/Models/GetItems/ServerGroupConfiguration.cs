namespace Entuity.Api.Models.GetItems;

public class ServerGroupConfiguration
{
	public bool SyncUsers { get; set; }

	public bool syncUserGroups { get; set; }

	public bool SyncViews { get; set; }

	public Guid ServerGroupId { get; set; }

	public string ServerGroupName { get; set; } = string.Empty;

	public string Description { get; set; } = string.Empty;

	public int CreationTimeSec { get; set; }

	public string CreatedBy { get; set; } = string.Empty;

	public bool SyncPaused { get; set; }

	public required Configuration Configuration { get; set; }

	public int ConfigurationChangeId { get; set; }

	public int LastModifiedSec { get; set; }

	public string LastModifiedBy { get; set; } = string.Empty;
}
