using System.Text.Json.Serialization;

namespace Entuity.Api.Models.PostItems;

public class IncidentFilterCreate
{
	public required string Name { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PassIP { get; set; }
}
