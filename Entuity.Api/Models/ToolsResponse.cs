namespace Entuity.Api.Models;

public class ToolsResponse
{
	public IEnumerable<ToolGroup> Items { get; set; } = [];

	public int Count { get; set; }
}
