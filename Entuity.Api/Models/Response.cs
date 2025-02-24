using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

/// <summary>
/// A model that represents a multiple item response
/// </summary>
/// <typeparam name="TId">The type of ID the item will have e.g. GUID or int</typeparam>
/// <typeparam name="T">The Type that is returned in Items e.g. Server</typeparam>
public class Response<TId, T> where T : Entity<TId>
{
	[JsonPropertyName("items")]
	public required ICollection<T> Items { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}