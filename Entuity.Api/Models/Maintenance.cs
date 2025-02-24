using System.Text.Json.Serialization;

namespace Entuity.Api.Models;
public class Maintenance : Entity<int>
{
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}
