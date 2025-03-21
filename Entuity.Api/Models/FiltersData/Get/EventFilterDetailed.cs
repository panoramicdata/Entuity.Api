namespace Entuity.Api.Models.FiltersData.Get;

/// <summary>
/// Holds detailed information about an Event Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819654646557-Filters-Event-Filter-Details-RESTful-API#get'/></para>
/// </summary>
public class EventFilterDetailed
{
	/// <summary>
	/// Name of the Filter
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Array of Filter Names
	/// </summary>
	public IEnumerable<string>? SelectedNames { get; set; }

	/// <summary>
	/// Whether this filter is a system filter
	/// </summary>
	public bool SystemFilter { get; set; }

	/// <summary>
	/// Whether this filter should include devices not under management
	/// </summary>
	public bool PassIP { get; set; }
}

