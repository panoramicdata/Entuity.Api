using System.Text.Json.Serialization;

namespace Entuity.Api.Models.EventsData.Post;

/// <summary>
/// Holds information for an event to be created.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819749116957-Events-RESTful-API#post'/></para>
/// </summary>
public class EventCreate
{
	/// <summary>
	/// The Event Type ID
	/// </summary>
	[JsonPropertyName("id")]
	public int EventTypeId { get; set; }

	/// <summary>
	/// The Reason for the Event
	/// </summary>
	public required string Reason { get; set; }

	/// <summary>
	/// The Name of the Event
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Name to display for the event source field
	/// </summary>
	public required string Source { get; set; }

	/// <summary>
	/// Description of the Impact of the Event
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ImpactDescription { get; set; }

	/// <summary>
	/// Event Severity:
	/// <list type="bullet">
	/// <item>2 = Information</item>
	/// <item>4 = minor</item>
	/// <item>6 = major</item>
	/// <item>8 = severe</item>
	/// <item>10 = critical</item>
	/// </list>
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Severity { get; set; }

	/// <inheritdoc cref="ObjectKey"/>
	public required ObjectKey ObjectKeyInfo { get; set; }

	/// <summary>
	/// Extra identifier that can be included to the event, e.g. a custom event attribute.This is a string field.
	/// </summary>
	public required string ExternalId { get; set; }
}
