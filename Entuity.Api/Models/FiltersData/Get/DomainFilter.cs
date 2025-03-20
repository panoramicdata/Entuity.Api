using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.FiltersData.Get;

public class DomainFilter : Entity<string>, IGetItem
{
	public Guid ServerId { get; set; }

	public required string Name { get; set; }
}
