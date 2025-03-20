using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ServicesData.Get;


public class ServiceDetailed : IGetItem
{
	public required ServiceInfo Info { get; set; }

	public required ServiceComponentId[] ComponentIds { get; set; }
}
