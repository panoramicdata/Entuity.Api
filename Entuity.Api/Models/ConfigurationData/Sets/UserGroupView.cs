using Entuity.Api.Models.ConfigurationData.Configuration;
using System.Collections;

namespace Entuity.Api.Models.ConfigurationData.Sets;

/// <summary>
/// Holds information about a User Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#get'/></para>
/// </summary>
public class UserGroupView
{
	/// <summary>
	/// Name of the view assigned to this config set
	/// </summary>
	public string ViewName { get; set; } = string.Empty;

	/// <summary>
	/// If View content is based on union of the Views or intersection of the Views
	/// </summary>
	public int BaseViewType { get; set; }

	/// <summary>
	/// Names of the View that form the base of this current View
	/// </summary>
	public IEnumerable? BaseViewNames { get; set; }

	/// <summary>
	/// If View content is automatically (union/intersection) or manually determined
	/// </summary>
	public int? ContentsType { get; set; }

	/// <summary>
	/// Name of the domain filter applied to this View
	/// </summary>
	public string DomainFilter { get; set; } = string.Empty;

	/// <summary>
	/// Name of the event filter applied to this View
	/// </summary>
	public string EventFilter { get; set; } = string.Empty;

	/// <summary>
	/// Name of the incident filter applied to this View
	/// </summary>
	public string SituationFilter { get; set; } = string.Empty;

	/// <summary>
	/// User account that owns the user group. Can be 'system'
	/// </summary>
	public string Owner { get; set; } = string.Empty;

	/// <summary>
	/// User groups that have access to this view
	/// </summary>
	public IEnumerable<ConfigurationSetViewUserGroup> UserGroups { get; set; } = [];

	/// <summary>
	/// Longitude of the View, as specified for Geographical Map mode
	/// </summary>
	public float Longitude { get; set; }

	/// <summary>
	/// Latitude of the View, as specified for Geographical Map mode
	/// </summary>
	public float Latitude { get; set; }

	/// <summary>
	/// Name of the View's location, as specified for Geographical Map mode
	/// </summary>
	public object? LocationName { get; set; }

	/// <summary>
	/// Has the View's location been manually set?
	/// </summary>
	public bool LocationManuallySet { get; set; }

	/// <summary>
	/// Unqiue universal identifier for the View
	/// </summary>
	public string ViewUUID { get; set; } = string.Empty;
}
