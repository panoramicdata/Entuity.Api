using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Holds information about a View assigned to a Configuration Set.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840534002461-Config-Sets-List-and-Add-Views-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetView : ConfigurationViewBase, IGetItem
{
	/// <summary>
	/// Names of the View that form the base of this current View
	/// </summary>
	public IEnumerable<string> BaseViewNames { get; set; } = [];

	/// <summary>
	/// Name of the Incident Filter applied to this View
	/// </summary>
	[JsonPropertyName("situationFilter")]
	public string IncidentFilter { get; set; } = string.Empty;

	/// <summary>
	/// Name of the View's location, as specified for Geographical Map mode
	/// </summary>
	public string LocationName { get; set; } = string.Empty;
}
