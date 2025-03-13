using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models;
public class Maintenance : Entity<int>, IReturnItem
{
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}
