using System.Text.Json.Serialization;

namespace Entuity.Api.Models.EventsData;

/// <summary>
/// Represents an event.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819749116957-Events-RESTful-API'/></para>
/// </summary>
public class EventItem : Entity<int>
{
	/// <summary>
	/// Event Description
	/// </summary>
	[JsonPropertyName("description")]
	public required string Description { get; set; }

	/// <summary>
	/// Event Details
	/// </summary>
	[JsonPropertyName("details")]
	public required string Details { get; set; }

	/// <inheritdoc cref="ObjectKey"/>
	[JsonPropertyName("objectKeyInfo")]
	public required ObjectKey ObjectKeyInfo { get; set; }

	/// <summary>
	/// Event Severity where:
	/// <list type="bullet">
	/// <item>2 = Information</item>
	/// <item>4 = minor</item>
	/// <item>6 = major</item>
	/// <item>8 = severe</item>
	/// <item>10 = critical</item>
	/// </list>
	/// </summary>
	[JsonPropertyName("severity")]
	public required int Severity { get; set; }

	/// <summary>
	/// Source description.
	/// </summary>
	[JsonPropertyName("sourceDescription")]
	public required string SourceDescription { get; set; }

	/// <summary>
	/// Impact description.
	/// </summary>
	[JsonPropertyName("impactDescription")]
	public required string ImpactDescription { get; set; }

	/// <summary>
	/// Event TimeStamp
	/// </summary>
	[JsonPropertyName("timeStamp")]
	public required int TimeStamp { get; set; }

	/// <summary>
	/// Event Number
	/// </summary>
	[JsonPropertyName("eventNumber")]
	public required int EventNumber { get; set; }
}
