using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.Sets.Get;

public class ConfigurationSetUserGroup : IGetItem
{
	public required string UserGroupName { get; set; }

	public IEnumerable<string> Members { get; set; } = [];

	public object? Tools { get; set; }

	public object? DefaultReportPermission { get; set; }

	public object? ReportURLToPermission { get; set; }

	public object? ReportFolderToPermission { get; set; }

	public object? DefaultTaskPermission { get; set; }

	public object? TaskNameToPermission { get; set; }
}
