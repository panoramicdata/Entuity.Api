using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Update;

/// <summary>
/// Represents the data that can be updated on an Incident Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819599936797-Filters-Incident-Filter-Details-RESTful-API#put'/></para>
/// </summary>
public class IncidentFilterUpdate
{
	/// <summary>
	/// The name of the Filter
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public string? Name { get; set; }

	/// <summary>
	/// Whether the filter should include devices not under management
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool? PassIP { get; set; }
}
