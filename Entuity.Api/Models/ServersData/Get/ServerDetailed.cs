using System.Text.Json.Serialization;

namespace Entuity.Api.Models.Servers.Get;

/// <summary>
/// Holds detailed information about a Server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829704875677-Server-Details-RESTful-API#get'/></para>
/// </summary>
public class ServerDetailed
{
	/// <summary>
	/// Unique server identifier
	/// </summary>
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	/// <summary>
	/// Role of the server: Polling, FlowCollector, ESPServer
	/// </summary>
	[JsonPropertyName("role")]
	public string Role { get; set; } = string.Empty;

	/// <summary>
	/// If this server is the one servicing the request: True or False
	/// </summary>
	[JsonPropertyName("local")]
	public bool Local { get; set; }

	/// <summary>
	/// Port number of the web server
	/// </summary>
	[JsonPropertyName("webPort")]
	public int WebPort { get; set; }

	/// <summary>
	/// If the server is licensed: True or False
	/// </summary>
	[JsonPropertyName("licensed")]
	public bool Licensed { get; set; }

	/// <summary>
	/// If the server is configured to use Secure Socket Layer: True or False
	/// </summary>
	[JsonPropertyName("ssl")]
	public bool Ssl { get; set; }

	/// <summary>
	/// If the server provides results in a multi server system: True or False
	/// </summary>
	[JsonPropertyName("included")]
	public bool Included { get; set; }

	/// <summary>
	/// If the server is a Central Server, either 'true' or 'false'
	/// </summary>
	[JsonPropertyName("centralServer")]
	public bool CentralServer { get; set; }

	/// <summary>
	/// Name of the server
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}