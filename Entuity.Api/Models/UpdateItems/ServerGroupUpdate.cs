using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UpdateItems;

public class ServerGroupUpdate
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ServerGroupName { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncUsers { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncUserGroups { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncViews { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SyncPaused { get; set; }
}

