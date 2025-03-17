using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.GetItems;

public class UserGroup : Entity<string>, IGetItem
{
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	[JsonPropertyName("name")]
	public required string Name { get; set; }
}

