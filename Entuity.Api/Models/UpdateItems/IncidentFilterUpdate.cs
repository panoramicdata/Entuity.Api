using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UpdateItems;

public class IncidentFilterUpdate
{
	public required string Name { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool? PassIP { get; set; }
}
