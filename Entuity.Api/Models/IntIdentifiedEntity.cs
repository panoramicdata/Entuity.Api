using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public abstract class IntIdentifiedEntity
{
	[JsonPropertyName("id")]
	public required int Id { get; set; }
}
