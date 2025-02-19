using System.Text.Json.Serialization;

namespace Entuity.Api.Models;
public class DataAccessTemplatesResponse
{
	[JsonPropertyName("items")]
	public IEnumerable<DataAccessTemplate> Items { get; set; } = [];

	[JsonPropertyName("count")]
	public int Count { get; set; }
}
