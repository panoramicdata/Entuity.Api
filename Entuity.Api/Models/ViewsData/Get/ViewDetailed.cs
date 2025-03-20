using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ViewsData.Get;

/// <summary>
/// Holds detailed information about a view
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829997432477-View-Details-RESTful-API#get'/></para>
/// </summary>
public class ViewDetailed : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity Server Id on which the resource resides
	/// </summary>
	public Guid ServerId { get; set; }

	/// <summary>
	/// View path
	/// </summary>
	public string Path { get; set; } = string.Empty;

	/// <summary>
	/// The name of the View
	/// </summary>
	public string DisplayName { get; set; } = string.Empty;

	/// <summary>
	/// One of:
	/// <list type="bullet">
	/// <item>NONE</item>
	/// <item>UNION</item>
	/// <item>INTERSECTION</item>
	/// </list>
	/// </summary>
	public string BaseViewAggregation { get; set; } = string.Empty;

	/// <summary>
	/// Array of base view paths
	/// </summary>
	public IEnumerable<string> BaseViewPaths { get; set; } = [];

	/// <summary>
	/// Domain filter name	
	/// </summary>
	public string DomainFilterName { get; set; } = string.Empty;

	/// <summary>
	/// If contents of the View are populated manually, either 'true' or 'false'
	/// </summary>
	public bool ManuallyPopulated { get; set; }

	/// <summary>
	/// Name of the Event Filter
	/// </summary>
	public string EventFilterName { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Incident Filter
	/// </summary>
	public string IncidentFilterName { get; set; } = string.Empty;

	/// <summary>
	/// User who owns the view
	/// </summary>
	public string Owner { get; set; } = string.Empty;

	/// <summary>
	/// Group Access Permissions
	/// </summary>
	public IEnumerable<AccessGroup> AccessGroups { get; set; } = [];

	/// <summary>
	/// Groups having implicit access by virtue of inheriting access through other group permissions, such as having access to the parent View. This may be indirect, e.g. access to the grandparent or great-grandparent
	/// </summary>
	public IEnumerable<object> ImplicitAccessGroups { get; set; } = [];

	/// <summary>
	/// Users having implicit access by virtue of inheriting access through other user permissions, such as having access to the parent View. This may be indirect, e.g. access to the grandparent or great-grandparent
	/// </summary>
	public IEnumerable<object> ImplicitAccessUsers { get; set; } = [];

	/// <summary>
	/// Geographical location of the View, used by the map dashlet in Geographical Mode. If the string is left empty, the location value will be removed from the View
	/// </summary>
	public string Location { get; set; } = string.Empty;

	/// <summary>
	/// Latitude of the location. If latitude is specified, then a location must be specified
	/// </summary>
	public float Lat { get; set; }

	/// <summary>
	/// Longitude of the location. If longitude is specified, then a location must be specified
	/// </summary>
	public float Lng { get; set; }
}
