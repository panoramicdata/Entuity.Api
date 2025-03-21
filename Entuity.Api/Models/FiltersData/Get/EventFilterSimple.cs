using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData.Get;

/// <summary>
/// Holds simple information about an Event Filter
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819629894813-Filters-Event-Filters-RESTful-API#get'/></para>
/// </summary>
public class EventFilterSimple : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity Server Id on which this resource resides
	/// </summary>
	[JsonPropertyName("serverId")]
	public required Guid ServerId { get; set; }

	/// <summary>
	/// Name of this Event Filter
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}

