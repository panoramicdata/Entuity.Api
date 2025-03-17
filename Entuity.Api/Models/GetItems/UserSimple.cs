using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.GetItems;

public class UserSimple : Entity<string>, IReturnItem
{
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	[JsonPropertyName("name")]
	public required string Name { get; set; }
}

