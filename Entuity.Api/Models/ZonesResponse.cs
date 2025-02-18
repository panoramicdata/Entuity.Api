using System.Text.Json.Serialization;

namespace Entuity.Api.Models;
public class ZonesResponse
{
	[JsonPropertyName("items")]
	public ICollection<Zone> Items { get; set; } = [];

	[JsonPropertyName("count")]
	public int Count { get; set; }
}
