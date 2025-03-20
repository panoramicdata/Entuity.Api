using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.UserGroupsData.Get;

public class UserGroupTool : Entity<int>, IGetItem
{
	public string ToolName { get; set; } = string.Empty;

	public string GroupName { get; set; } = string.Empty;
}
