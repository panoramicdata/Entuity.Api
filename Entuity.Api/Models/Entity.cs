using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

/// <summary>
/// Represents a data entity.
/// </summary>
/// <typeparam name="T">The type of ID this entity has</typeparam>
public abstract class Entity<T>
{
	[JsonPropertyName("id")]
	public required T Id { get; set; }
}
