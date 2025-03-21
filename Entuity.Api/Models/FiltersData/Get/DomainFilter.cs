using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.FiltersData.Get;

/// <summary>
/// Holds information about a Domain Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819545732637-Filters-Domain-Content-Filters-RESTful-API#get'/></para>
/// </summary>
public class DomainFilter : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity Server ID on which this Domain Filter resides
	/// </summary>
	public Guid ServerId { get; set; }

	/// <summary>
	/// Name of the Domain Filter
	/// </summary>
	public required string Name { get; set; }
}
