using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Update;

/// <summary>
/// Holds the data required to update an IPAM network.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13839898833437-IPAM-Network-Details-RESTful-API#put'/></para>
/// </summary>
public class IpamNetworkUpdate : IpamNetworkBase
{
	/// <summary>
	/// % threshold value in which the usage will be yellow, by default a global value
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? UsageMedium { get; set; }
}
