using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Collections;

/// <summary>
/// Represents a Multi Item response consisting of:
/// <list type="bullet">
/// <item>Items - The collection of items</item>
/// <item>Count - The amount of items in this response</item>
/// </list>
/// </summary>
/// <typeparam name="T">The Type that is returned in Items e.g. Server</typeparam>
public class Response<T> where T : IGetItem
{
	[JsonPropertyName("items")]
	public required ICollection<T> Items { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}