using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Get;

/// <summary>
/// Represents a detailed DHCP server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840170481437-IPAM-DHCP-Server-Details-RESTful-API#get'/></para>
/// </summary>
public class DhcpServerDetailed : DhcpServerBase, IGetItem
{
	/// <summary>
	/// ID of the shared credential set used for the DHCP server
	/// </summary>
	[JsonPropertyName("credID")]
	public int CredentialID { get; set; }

	/// <summary>
	/// List of scopes
	/// </summary>
	public IEnumerable<Scope> Scopes { get; set; } = [];
}

