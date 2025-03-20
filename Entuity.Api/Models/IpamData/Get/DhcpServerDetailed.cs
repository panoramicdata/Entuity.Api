using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Get;


public class DhcpServerDetailed : Entity<int>, IGetItem
{
	public string Name { get; set; } = string.Empty;

	public string IpAddress { get; set; } = string.Empty;

	public int ZoneID { get; set; }

	[JsonPropertyName("$type")]
	public int Type { get; set; }

	public int CredID { get; set; }

	public int Port { get; set; }

	public int LastScanned { get; set; }

	public int Status { get; set; }

	public IEnumerable<Scope> Scopes { get; set; } = [];
}

