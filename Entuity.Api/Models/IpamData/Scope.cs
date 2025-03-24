using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData;

/// <summary>
/// Represents a scope
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840170481437-IPAM-DHCP-Server-Details-RESTful-API#get'/></para>
/// </summary>
public class Scope
{
	/// <summary>
	/// Name of the IP range
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// IP range of the Scope
	/// </summary>
	public string IpRange { get; set; } = string.Empty;

	/// <summary>
	/// If the IP range is active, either 'true' or 'false'
	/// </summary>
	[JsonPropertyName("active")]
	public bool IsActive { get; set; }
}
