using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Post;

/// <summary>
/// Represents the data required to create an Incident Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819609078045-Filters-Incident-Filters-RESTful-API#post'/></para>
/// </summary>
public class IncidentFilterCreate
{
	/// <summary>
	/// Name of the Filter
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Whether the filter should include devices not under management
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PassIP { get; set; }
}
