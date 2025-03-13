using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ReturnItems;

public class DhcpServer : Entity<int>, IReturnItem
{
	/// <summary>
	/// User-specified name of the DHCP server.
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// IP address of the DHCP server.
	/// </summary>
	public string IpAddress { get; set; } = string.Empty;

	/// <summary>
	/// Zone of the DHCP server, if applicable.
	/// </summary>
	public int ZoneID { get; set; }

	/// <summary>
	/// Type of DHCP server, either 0 (Windows (WinRM)) or 1 (ISC (SSH)).
	/// </summary>
	[JsonPropertyName("$type")]
	public int Type { get; set; }

	/// <summary>
	/// ID of the shared credential set used for the DHCP server.
	/// </summary>
	public int CredID { get; set; }

	/// <summary>
	/// Port used to connect to the DHCP server.
	/// </summary>
	public int Port { get; set; }

	/// <summary>
	/// Timestamp of the last scan on the DHCP server.
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

	public object? Scopes { get; set; }
}

