using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Holds information about a View assigned to a Configuration Set.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840534002461-Config-Sets-List-and-Add-Views-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetView : IGetItem
{
	/// <summary>
	/// Name of the View assigned to this config Set
	/// </summary>
	public string ViewName { get; set; } = string.Empty;

	/// <summary>
	/// If View content is based on the univon of the Views or intersection of the Views
	/// </summary>
	public int BaseViewType { get; set; }

	/// <summary>
	/// Names of the View that form the base of this current View
	/// </summary>
	public IEnumerable<string> BaseViewNames { get; set; } = [];

	/// <summary>
	/// If View content is automatically (union/intersection) or manually determined
	/// </summary>
	public int? ContentsType { get; set; }

	/// <summary>
	/// Name of the Domain Filter applied to this View
	/// </summary>
	public string DomainFilter { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Event Filter applied to this View
	/// </summary>
	public string EventFilter { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Incident Filter applied to this View
	/// </summary>
	[JsonPropertyName("situationFilter")]
	public string IncidentFilter { get; set; } = string.Empty;

	/// <summary>
	/// User account that owns the user group
	/// </summary>
	public string Owner { get; set; } = string.Empty;

	/// <inheritdoc cref="ConfigurationSetViewUsergroup"/>
	public IEnumerable<ConfigurationSetViewUsergroup> UserGroups { get; set; } = [];

	/// <summary>
	/// Longitude of the View's location, as specified for Geographical Map mode
	/// </summary>
	public float Longitude { get; set; }

	/// <summary>
	/// Latitude of the View's location, as specified for Geographical Map mode
	/// </summary>
	public float Latitude { get; set; }

	/// <summary>
	/// Name of the View's location, as specified for Geographical Map mode
	/// </summary>
	public string LocationName { get; set; } = string.Empty;

	/// <summary>
	/// If the View's location is manually set
	/// </summary>
	public bool LocationManuallySet { get; set; }

	/// <summary>
	/// Unique universal identifier of the View
	/// </summary>
	public string ViewUUID { get; set; } = string.Empty;
}
