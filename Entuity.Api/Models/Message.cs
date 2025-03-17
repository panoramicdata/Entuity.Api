using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

/// <summary>
/// Holds a message returned from the API
/// </summary>
public class Message
{
	[JsonPropertyName("message")]
	public string Content { get; set; } = string.Empty;
}
