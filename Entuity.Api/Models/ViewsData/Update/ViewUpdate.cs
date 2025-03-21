using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ViewsData.Update;
// <summary>
/// Model for updating a new View
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829997432477-View-Details-RESTful-API#put'/></para>
/// </summary>
public class ViewUpdate
{
	/// <summary>
	/// Name of the View being created
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public required string? Name { get; set; }

	/// <summary>
	/// Array of access objects, specifying view access permissions
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<AccessGroup>? AccessGroups { get; set; }

	/// <summary>
	/// A way to aggregate base views: One of NONE (default), UNION or INTERSECTION
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? BaseViewAggregation { get; set; }

	/// <summary>
	/// Array of base views
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<object>? BaseViewPaths { get; set; }

	/// <summary>
	/// Name of the domain filter to use
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? DomainFilterName { get; set; }

	/// <summary>
	/// Username of the user who will be an owner of the View. This defaults to the user making a call. Only administrators may specify a user other than themselves
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Owner { get; set; }

	/// <summary>
	/// Location of the View, which is used by the Map dashlet in Geographical Mode
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Location { get; set; }
}
