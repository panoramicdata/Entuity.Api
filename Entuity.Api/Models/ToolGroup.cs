namespace Entuity.Api.Models;

public class ToolGroup
{
	public string Subgroup { get; set; } = string.Empty;

	public IEnumerable<Tool> Tools { get; set; } = [];
}
