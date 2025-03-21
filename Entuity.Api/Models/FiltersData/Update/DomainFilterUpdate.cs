using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Update;

/// <summary>
/// Represents the Information to Update a Domain Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819545732637-Filters-Domain-Content-Filters-RESTful-API#put'/></para>
/// </summary>
public class DomainFilterUpdate
{
	/// <summary>
	/// Name of the Domain Filter
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }
}
