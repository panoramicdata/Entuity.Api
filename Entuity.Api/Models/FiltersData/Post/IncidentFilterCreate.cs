using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Post;

public class IncidentFilterCreate
{
	public required string Name { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PassIP { get; set; }
}
