namespace Entuity.Api.Models.FlowData.Get;

/// <summary>
/// Represents a response that contains the applications that are configured to support flow
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835520186525-Flow-Data-Listing-Applications-Supporting-Flow-RESTful-API#get'/></para>
/// </summary>
public class FlowApplicationResponse
{
	/// <summary>
	/// The applications that are configured to support flow
	/// </summary>
	public IEnumerable<FlowApplication> Applications { get; set; } = [];
}
