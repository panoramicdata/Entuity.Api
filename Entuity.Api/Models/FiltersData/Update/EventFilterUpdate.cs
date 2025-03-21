using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Update;

/// <summary>
/// Holds information that can be used to update an Event Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819654646557-Filters-Event-Filter-Details-RESTful-API#put'/></para>
/// </summary>
public class EventFilterUpdate
{
	/// <summary>
	/// The name of the Event Filter
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }

	/// <summary>
	/// Whether this filter should include devices not under management
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PassIP { get; set; }
}
