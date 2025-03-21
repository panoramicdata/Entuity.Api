using Refit;

namespace Entuity.Api.QueryParameters;
/// <summary>
/// Holds Query Parameters for filtering services
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838522122269-Services-Hierarchy-RESTful-API#get'/></para>
/// </summary>
public class ServicesFilter
{
	/// <summary>
	/// The View path to get services from
	/// </summary>
	[AliasAs("viewpath")]
	public string? ViewPath { get; set; }

	/// <summary>
	/// If true, will also return services in child Views of the given View
	/// </summary>
	[AliasAs("indirect")]
	public bool? Indirect { get; set; }

	/// <summary>
	/// If true, will also include subservices associated with retrieved services
	/// </summary>
	[AliasAs("subservices")]
	public bool? SubServices { get; set; }

	/// <summary>
	/// If true, will also retrieve service information from remote servers
	/// </summary>
	[AliasAs("consolidate")]
	public bool? Consolidate { get; set; }

	/// <summary>
	/// Maximum depth of child services to retrieve. If not set, this will default to 3
	/// </summary>
	[AliasAs("maxdepth")]
	public int? MaxDepth { get; set; }
}
