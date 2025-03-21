namespace Entuity.Api.Models.FiltersData.Post;

/// <summary>
/// Holds information used to create a new Domain Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819545732637-Filters-Domain-Content-Filters-RESTful-API#post'/></para>
/// </summary>
public class DomainFilterCreate
{
	/// <summary>
	/// Name of the Domain Filter
	/// </summary>
	public required string Name { get; set; }
}
