using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Get;

/// <summary>
/// Represents a detailed DHCP server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840170481437-IPAM-DHCP-Server-Details-RESTful-API#get'/></para>
/// </summary>
public class DhcpServerDetailed : Entity<int>, IGetItem
{
	/// <summary>
	/// User-Specified name of the DHCP server
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// IP address of the DHCP server
	/// </summary>
	public string IpAddress { get; set; } = string.Empty;

	/// <summary>
	/// Zone of the DHCP server, if applicable. This column is hidden if there are no zones
	/// </summary>
	public int ZoneID { get; set; }

	/// <summary>
	/// Type of DHCP server, either 0 (Windows (WinRM)) or 1 (ISC (SSH))
	/// </summary>
	[JsonPropertyName("$type")]
	public int Type { get; set; }

	/// <summary>
	/// ID of the shared credential set used for the DHCP server
	/// </summary>
	[JsonPropertyName("credID")]
	public int CredentialID { get; set; }

	/// <summary>
	/// Port used to connect to the DHCP server
	/// </summary>
	public int Port { get; set; }

	/// <summary>
	/// Timestamp of the last scan on the DHCP server
	/// </summary>
	public int LastScanned { get; set; }

	/// <summary>
	/// Current status of the connection to the server, one of the following:
	/// <list type="bullet">
	/// <item>0 - OK</item>
	/// <item>1 - No Response (e.g. offline or credentials invalid)</item>
	/// <item>2 - No DHCP (e.g. no DHCP installed)</item>
	/// </list>
	/// </summary>
	public int Status { get; set; }

	/// <summary>
	/// List of scopes
	/// </summary>
	public IEnumerable<Scope> Scopes { get; set; } = [];
}

