using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class ToolGroup : IReturnItem
{
	public string Subgroup { get; set; } = string.Empty;

	public IEnumerable<Tool> Tools { get; set; } = [];
}
