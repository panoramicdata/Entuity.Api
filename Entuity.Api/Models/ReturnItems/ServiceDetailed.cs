using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ReturnItems;


public class ServiceDetailed : IReturnItem
{
	public required ServiceInfo Info { get; set; }

	public required ServiceComponentId[] ComponentIds { get; set; }
}
