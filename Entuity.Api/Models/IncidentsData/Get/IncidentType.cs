using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IncidentsData.Get;

/// <summary>
/// Represents a type of Incident
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819715590813-Incident-Types-RESTful-API#get'/></para>
/// </summary>
public class IncidentType : IGetItem
{
	/// <summary>
	/// Name of the Incident Type
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }
}
