using System.Text.Json.Serialization;

namespace Entuity.Api.Models.EventsData.Get;

/// <summary>
/// Represents a collection of events returned by the API.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819749116957-Events-RESTful-API#get'/></para>
/// </summary>
public class EventsResponse
{
	/// <summary>
	/// Collection of events
	/// </summary>
	[JsonPropertyName("events")]
	public required ICollection<EventItem> Events { get; set; }

	/// <summary>
	/// Event update identifier
	/// </summary>
	[JsonPropertyName("updateId")]
	public int UpdateId { get; set; }

	/// <summary>
	/// Amount of events in the Events collection
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }
}