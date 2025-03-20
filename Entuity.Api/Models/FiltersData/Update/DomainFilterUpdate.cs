using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Update;

public class DomainFilterUpdate
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }
}
