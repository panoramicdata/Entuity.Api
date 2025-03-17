using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.GetItems;

public class EventsType : Entity<int>, IReturnItem
{
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("severity")]
	public required int Severity { get; set; }
}
