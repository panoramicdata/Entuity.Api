using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IncidentsData.Get;

public class IncidentType : IGetItem
{
	[JsonPropertyName("name")]
	public required string Name { get; set; }
}
