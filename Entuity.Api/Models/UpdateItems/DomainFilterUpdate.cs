using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UpdateItems;

public class DomainFilterUpdate
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }
}
