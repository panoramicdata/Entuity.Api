using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.IpamData.Get;

/// <summary>
/// Represents a DHCP server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840169160093-IPAM-DHCP-Servers-RESTful-API#get'/></para>
/// </summary>
public class DhcpServer : DhcpServerBase, IGetItem
{
	/// <summary>
	/// ID of the shared credential set used for the DHCP server.
	/// </summary>
	public int CredID { get; set; }

	public object? Scopes { get; set; }
}

