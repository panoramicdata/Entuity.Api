namespace Entuity.Api.Models.FlowData.Get;

/// <summary>
/// Represents an application that is configured to support flow
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835520186525-Flow-Data-Listing-Applications-Supporting-Flow-RESTful-API#get'/></para>
/// </summary>
public class FlowApplication
{
	/// <summary>
	/// Name of the application
	/// </summary>
	public string Name { get; set; } = string.Empty;
}
