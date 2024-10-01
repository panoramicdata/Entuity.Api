using System.Text.Json.Serialization;

namespace Entuity.Api.Models;
public class ServerResponse
{
	[JsonPropertyName("items")]
	public ICollection<Server> Items { get; set; } = [];

	[JsonPropertyName("count")]
	public int Count { get; set; }
}
