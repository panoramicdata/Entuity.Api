using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Get;

[JsonConverter(typeof(IpamSettingsAndStatusResponseConverter))]
public class IpamSettingsAndStatusResponse
{
	public List<string> Statuses { get; set; } = null!;

	public IpamSettings Settings { get; set; } = null!;
}
