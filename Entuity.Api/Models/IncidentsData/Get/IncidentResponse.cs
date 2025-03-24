using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IncidentsData.Get;

/// <summary>
/// Represents a response containing a collection of Incidents as well as metadata about the response
/// </summary>
public class IncidentResponse
{
	/// <summary>
	/// Collection of Incidents
	/// </summary>
	[JsonPropertyName("incidents")]
	public required ICollection<Incident> Incidents { get; set; }

	/// <summary>
	/// Incident update identifier, use the updateId from the last result set to get new incidents
	/// </summary>
	[JsonPropertyName("updateId")]
	public int UpdateId { get; set; }

	/// <summary>
	/// Count of the amount of incidents in this response
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }
}