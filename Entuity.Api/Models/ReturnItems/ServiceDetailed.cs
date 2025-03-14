namespace Entuity.Api.Models.ReturnItems;


public class ServiceDetailed
{
	public required ServiceInfo Info { get; set; }

	public required ServiceComponentId[] ComponentIds { get; set; }
}
