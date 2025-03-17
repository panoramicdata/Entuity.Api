using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.Collections;

/// <summary>
/// A model that represents a multiple item response
/// </summary>
/// <typeparam name="T">The Type that is returned in Items e.g. Server</typeparam>
public class Response<T> where T : IGetItem
{
	[JsonPropertyName("items")]
	public required ICollection<T> Items { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }
}