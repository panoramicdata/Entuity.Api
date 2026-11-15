namespace Entuity.Api.Models.IpamData.Post;

/// <summary>
/// Holds the required and optional Properties to create a new Network
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839913797661-IPAM-Networks-RESTful-API#post'/></para>
/// </summary>
public class NetworkCreate : IpamNetworkBase
{
	/// <summary>
	/// % threshold value in which the usage will be yellow, by default a global value
	/// </summary>
	public required int UsageMedium { get; set; }
}
