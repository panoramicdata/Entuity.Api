using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

public class IncidentType : IReturnItem
{
	[JsonPropertyName("name")]
	public required string Name { get; set; }
}
