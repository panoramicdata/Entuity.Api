using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.EventsData.Get;

/// <summary>
/// 
/// </summary>
public class EventsType : Entity<int>, IGetItem
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("severity")]
	public required int Severity { get; set; }
}
