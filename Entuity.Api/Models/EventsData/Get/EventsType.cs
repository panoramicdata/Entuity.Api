using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.EventsData.Get;

/// <summary>
/// Represents an event type.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819768912669-Event-Types-RESTful-API#get'/></para>
/// </summary>
public class EventsType : Entity<int>, IGetItem
{
	/// <summary>
	/// Name of the event type
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	/// <summary>
	/// Severity of the event type
	/// </summary>
	[JsonPropertyName("severity")]
	public required int Severity { get; set; }
}
