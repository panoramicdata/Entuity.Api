using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Post;

public class NetworkCreate
{
	public required string Name { get; set; }

	public required string IpRange { get; set; }

	public required string Description { get; set; }

	public required int UsageMedium { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Role { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ZoneID { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? DhcpServer { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Scans { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ParentID { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? UsageHigh { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SkipNetwork { get; set; }
}
