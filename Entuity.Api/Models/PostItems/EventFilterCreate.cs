using System.Text.Json.Serialization;

namespace Entuity.Api.Models.PostItems;

public class EventFilterCreate
{
	public required string Name { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool? PassIP { get; set; }
}
