using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ViewsData.Post;

/// <summary>
/// Model for creating a new View
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829756254109-View-List-RESTful-API#post'/></para>
/// </summary>
public class ViewCreate
{
	/// <summary>
	/// Name of the View being created
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Array of access objects, specifying view access permissions
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<ViewAccessGroup>? AccessGroups { get; set; }

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
	/// Forward-slash separated path of the parent view. Leave out to create a top-level view
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ParentViewPath { get; set; }

	/// <summary>
	/// Location of the View, which is used by the Map dashlet in Geographical Mode
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Location { get; set; }
}
