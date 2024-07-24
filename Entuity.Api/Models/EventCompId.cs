using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class EventCompId
{
	[JsonPropertyName("ids")]
	public required ICollection<int> Ids { get; set; }
}
