using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class ToolGroup : IGetItem
{
	public string Subgroup { get; set; } = string.Empty;

	public IEnumerable<Tool> Tools { get; set; } = [];
}
