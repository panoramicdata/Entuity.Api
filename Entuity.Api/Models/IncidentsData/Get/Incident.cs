using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IncidentsData.Get;

/// <summary>
/// Holds information about an Incident
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819730123293-Incidents-RESTful-API#get'/></para>
/// </summary>
public class Incident : NotificationBase, IGetItem
{
	/// <summary>
	/// The state of the incident
	/// </summary>
	[JsonPropertyName("state")]
	public required string State { get; set; }

	/// <summary>
	/// The annotation of the incident
	/// </summary>
	[JsonPropertyName("annotation")]
	public required string Annotation { get; set; }

	/// <summary>
	/// number of events contributing to this incident
	/// </summary>
	[JsonPropertyName("eventCount")]
	public required int EventCount { get; set; }

	/// <summary>
	/// Any extra attribute key, value pairs for this incident
	/// </summary>
	[JsonPropertyName("extraAttribs")]
	public Dictionary<string, string>? ExtraAttribs { get; set; }
}
