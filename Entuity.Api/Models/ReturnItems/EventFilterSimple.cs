using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ReturnItems;

public class EventFilterSimple : Entity<string>, IReturnItem
{
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}

