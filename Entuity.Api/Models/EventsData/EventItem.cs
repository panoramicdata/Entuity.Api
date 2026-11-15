using System.Text.Json.Serialization;

namespace Entuity.Api.Models.EventsData;

/// <summary>
/// Represents an event.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819749116957-Events-RESTful-API'/></para>
/// </summary>
public class EventItem : NotificationBase
{
	/// <summary>
	/// Event Number
	/// </summary>
	[JsonPropertyName("eventNumber")]
	public required int EventNumber { get; set; }
}
