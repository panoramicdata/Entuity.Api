using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Update;

public class EventFilterUpdate
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PassIP { get; set; }
}
