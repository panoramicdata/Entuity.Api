namespace Entuity.Api.Models;
public class ZoneDetails
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public int Flags { get; set; }
	public string Description { get; set; } = string.Empty;
	public string V4Interface { get; set; } = string.Empty;
	public string V6Interface { get; set; } = string.Empty;
	public string DomainSuffix { get; set; } = string.Empty;
	public string Proxy { get; set; } = string.Empty;
	public string DevicePrefix { get; set; } = string.Empty;
	public string HostFile { get; set; } = string.Empty;
	public IEnumerable<string> DnsServers { get; set; } = [];
}
