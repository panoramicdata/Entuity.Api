using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.WebhooksData.Get;

/// <summary>
/// Represents a container of endpoints returned from a get webhook group endpoints http method
/// </summary>
public class EndpointContainer : IGetItem
{
	public int ContainerID { get; set; }

	public string ContainerName { get; set; } = string.Empty;

	public IEnumerable<Endpoint> Endpoints { get; set; } = [];
}
