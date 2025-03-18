using System.Text.Json.Serialization;

namespace Entuity.Api.Models.PostItems;

public class DhcpServerCreate
{
	public required string Name { get; set; }

	public required string IpAddress { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public int ZoneId { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public int Type { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public int CredId { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public int Port { get; set; }
}
