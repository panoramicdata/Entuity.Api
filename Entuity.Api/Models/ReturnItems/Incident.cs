using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ReturnItems;

public class Incident : Entity<int>, IReturnItem
{
	[JsonPropertyName("description")]
	public required string Description { get; set; }

	[JsonPropertyName("details")]
	public required string Details { get; set; }

	[JsonPropertyName("objectKeyInfo")]
	public required EventObjectKeyInfo ObjectKeyInfo { get; set; }

	[JsonPropertyName("severity")]
	public required int Severity { get; set; }

	[JsonPropertyName("sourceDescription")]
	public required string SourceDescription { get; set; }

	[JsonPropertyName("impactDescription")]
	public required string ImpactDescription { get; set; }

	[JsonPropertyName("timeStamp")]
	public required int TimeStamp { get; set; }

	[JsonPropertyName("state")]
	public required string State { get; set; }

	[JsonPropertyName("annotation")]
	public required string Annotation { get; set; }

	[JsonPropertyName("eventCount")]
	public required int EventCount { get; set; }

	[JsonPropertyName("extraAttribs")]
	public Dictionary<string, string>? ExtraAttribs { get; set; }

}
