using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class UserGroupTool : Entity<int>, IReturnItem
{
	public string ToolName { get; set; } = string.Empty;

	public string GroupName { get; set; } = string.Empty;
}
