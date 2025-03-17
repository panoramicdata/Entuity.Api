using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.GetItems;

public class ZoneDetailed : IReturnItem
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("flags")]
	public int Flags { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; } = string.Empty;

	[JsonPropertyName("v4Interface")]
	public string V4Interface { get; set; } = string.Empty;

	[JsonPropertyName("v6Interface")]
	public string V6Interface { get; set; } = string.Empty;

	[JsonPropertyName("domainSuffix")]
	public string DomainSuffix { get; set; } = string.Empty;

	[JsonPropertyName("proxy")]
	public string Proxy { get; set; } = string.Empty;

	[JsonPropertyName("devicePrefix")]
	public string DevicePrefix { get; set; } = string.Empty;

	[JsonPropertyName("hostFile")]
	public string HostFile { get; set; } = string.Empty;

	[JsonPropertyName("dnsServers")]
	public IEnumerable<string> DnsServers { get; set; } = [];
}
