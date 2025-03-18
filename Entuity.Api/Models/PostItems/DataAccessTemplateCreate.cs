using System.Text.Json.Serialization;

namespace Entuity.Api.Models.PostItems;

public class DataAccessTemplateCreate
{
	public required string Name { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }
}
