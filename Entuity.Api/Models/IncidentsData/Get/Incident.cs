using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IncidentsData.Get;

/// <summary>
/// Holds information about an Incident
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819730123293-Incidents-RESTful-API#get'/></para>
/// </summary>
public class Incident : Entity<int>, IGetItem
{
	/// <summary>
	/// Description of the Incident
	/// </summary>
	[JsonPropertyName("description")]
	public required string Description { get; set; }

	/// <summary>
	/// Details of the Incident
	/// </summary>
	[JsonPropertyName("details")]
	public required string Details { get; set; }

	/// <inheritdoc cref="ObjectKey"/>
	[JsonPropertyName("objectKeyInfo")]
	public required ObjectKey ObjectKeyInfo { get; set; }

	/// <summary>
	/// The severity of the incident in integer form. The severity levels are as follows:
	/// <list type="bullet">
	/// <item>2 = Information</item>
	/// <item>4 = Minor</item>
	/// <item>6 = Major</item>
	/// <item>8 = Severe</item>
	/// <item>10 = Critical</item>
	/// </list>
	/// </summary>
	[JsonPropertyName("severity")]
	public required int Severity { get; set; }

	/// <summary>
	/// Description of the source of the incident
	/// </summary>
	[JsonPropertyName("sourceDescription")]
	public required string SourceDescription { get; set; }

	/// <summary>
	/// Description of the impact of the incident
	/// </summary>
	[JsonPropertyName("impactDescription")]
	public required string ImpactDescription { get; set; }

	/// <summary>
	/// When the incident took place
	/// </summary>
	[JsonPropertyName("timeStamp")]
	public required int TimeStamp { get; set; }

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
