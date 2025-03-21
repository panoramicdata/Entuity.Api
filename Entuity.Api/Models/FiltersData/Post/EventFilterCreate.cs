using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Post;

/// <summary>
/// Holds information used to create a new Event Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819629894813-Filters-Event-Filters-RESTful-API#post'/></para>
/// </summary>
public class EventFilterCreate
{
	/// <summary>
	/// Name of this Event Filter
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Whether this filter should include devices not under management
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool? PassIP { get; set; }
}
