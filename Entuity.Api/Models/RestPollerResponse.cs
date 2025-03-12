namespace Entuity.Api.Models;

public class RestPollerResponse
{
	public IEnumerable<RestPoller> Items { get; set; } = [];

	public int Count { get; set; }
}
