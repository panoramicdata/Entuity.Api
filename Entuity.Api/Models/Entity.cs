using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public abstract class Entity
{
	[JsonPropertyName("id")]
	public required string Id { get; set; }
}
