using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.GetItems;

public class Zone : Entity<string>, IReturnItem
{
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}