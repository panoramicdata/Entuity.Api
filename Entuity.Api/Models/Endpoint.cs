namespace Entuity.Api.Models;

public class Endpoint
{
	public int EndpointID { get; set; }

	public int ObjectID { get; set; }

	public Guid ServerID { get; set; }

	public int PayloadMax { get; set; }

	public bool SaveEnabled { get; set; }

	public string EndpointName { get; set; } = string.Empty;

	public string GroupName { get; set; } = string.Empty;

	public int PayloadCount { get; set; }

	public string Secret { get; set; } = string.Empty;
}

