namespace Entuity.Api.Models.FiltersData.Get;

/// <summary>
/// Holds information about a Domain Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819563623453-Filters-Domain-Content-Filter-Details-RESTful-API#get'/></para>
/// </summary>
public class DomainFilterDetailed
{
	/// <summary>
	/// Domain Filter Name
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Whether the filter is a system filter
	/// </summary>
	public bool SystemFilter { get; set; }

	/// <summary>
	/// Array of rules defining a filter
	/// </summary>
	public IEnumerable<FilterRule> Rules { get; set; } = [];
}
