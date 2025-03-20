using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Post;

public class EventFilterCreate
{
	public required string Name { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool? PassIP { get; set; }
}
