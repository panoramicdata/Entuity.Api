using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.Servers.Get;

/// <summary>
/// Server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829672195869-Servers-RESTful-API#get'/></para>
/// </summary>
public class Server : Entity<string>, IGetItem
{
	/// <summary>
	/// Unique identifier for the server
	/// </summary>
	[JsonPropertyName("serverId")]
	public Guid ServerId { get; set; }

	/// <summary>
	/// Name of the server
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}