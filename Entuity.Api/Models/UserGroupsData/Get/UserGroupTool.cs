using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.UserGroupsData.Get;

/// <summary>
/// Represents a User Group Tool
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829721504285-User-Group-Permissions-RESTful-API#get'/></para>
/// </summary>
public class UserGroupTool : Entity<int>, IGetItem
{
	/// <summary>
	/// Name of the Tool
	/// </summary>
	public string ToolName { get; set; } = string.Empty;

	/// <summary>
	/// Name of the subgroup that given tool belongs to
	/// </summary>
	public string GroupName { get; set; } = string.Empty;
}
