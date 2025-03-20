using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ToolsData.Get;

public class ToolGroup : IGetItem
{
	public string Subgroup { get; set; } = string.Empty;

	public IEnumerable<Tool> Tools { get; set; } = [];
}
