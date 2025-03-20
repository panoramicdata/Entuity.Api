using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.FiltersData.Get;

public class IncidentFilterSimple : Entity<string>, IGetItem
{
	public Guid ServerId { get; set; }

	public string? Name { get; set; }
}
