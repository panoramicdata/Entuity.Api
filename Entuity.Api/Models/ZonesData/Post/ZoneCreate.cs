namespace Entuity.Api.Models.ZonesData.Post;

/// <summary>
/// Holds required and optional information to create a Zone
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830161498909-Zones-RESTful-API#post'/></para>
/// </summary>
public class ZoneCreate : ZoneBase
{
	/// <summary>
	/// Name of the Zone
	/// </summary>
	public required string Name { get; set; }
}
