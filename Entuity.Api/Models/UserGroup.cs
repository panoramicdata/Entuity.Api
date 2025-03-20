namespace Entuity.Api.Models;
public class UserGroup
{
	public string UserGroupName { get; set; } = string.Empty;

	public IEnumerable<string> Members { get; set; } = [];

	public object? Tools { get; set; }

	public object? DefaultReportPermission { get; set; }

	public object? ReportURLToPermission { get; set; }

	public object? ReportFolderToPermission { get; set; }

	public object? DefaultTaskPermission { get; set; }

	public object? TaskNameToPermission { get; set; }
}
