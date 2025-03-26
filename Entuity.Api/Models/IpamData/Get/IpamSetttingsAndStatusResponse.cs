using Entuity.Api.JsonConverters;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IpamData.Get;

[JsonConverter(typeof(IpamSettingsAndStatusResponseConverter))]
public class IpamSettingsAndStatusResponse
{
	/// <summary>
	/// A List of statuses for:
	/// <list type="bullet">
	/// <item>Store</item>
	/// <item>Service</item>
	/// <item>Scanner</item>
	/// <item>Scheduler</item>
	/// </list>
	/// </summary>
	public List<string> Statuses { get; set; } = null!;

	/// <inheritdoc cref="IpamSettings"/>
	public IpamSettings Settings { get; set; } = null!;
}
