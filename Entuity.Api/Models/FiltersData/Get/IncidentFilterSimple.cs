using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.FiltersData.Get;

/// <summary>
/// Represents an incident filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819609078045-Filters-Incident-Filters-RESTful-API#get'/></para>
/// </summary>
public class IncidentFilterSimple : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity Server Id on which this resource is present
	/// </summary>
	public Guid ServerId { get; set; }

	/// <summary>
	/// Name of the incident Filter
	/// </summary>
	public string? Name { get; set; }
}
