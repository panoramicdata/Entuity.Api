using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

/// <summary>
/// Object Key Consists of:
/// <list type="bullet">
/// <item>swId StormWorks Identifier (integer)</item>
/// <item>compId Classic component identifier (4 integers)</item>
/// </list>
/// </summary>
public class ObjectKey
{
	[JsonPropertyName("swId")]
	public required int SwId { get; set; }

	[JsonPropertyName("compId")]
	public required EventCompId CompId { get; set; }
}
