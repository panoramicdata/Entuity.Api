using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.InventoryData.Get;

public class InventoryItemSimple : Entity<string>, IGetItem
{
	[JsonPropertyName("serverId")]
	public required Guid ServerId { get; set; }

	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("objectId")]
	public required int ObjectId { get; set; }

	[JsonPropertyName("added")]
	public required bool Added { get; set; }

	[JsonPropertyName("polledName")]
	public string? PolledName { get; set; }
}