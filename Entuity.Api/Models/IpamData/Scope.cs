namespace Entuity.Api.Models.IpamData;

public class Scope
{
	public string Name { get; set; } = string.Empty;

	public string IpRange { get; set; } = string.Empty;

	public bool Active { get; set; }
}
