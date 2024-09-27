using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class Response<T> where T : Entity
{
	[JsonPropertyName("items")]
	public required ICollection<T> Items { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}