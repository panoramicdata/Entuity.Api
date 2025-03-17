using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class DomainFilter : Entity<string>, IReturnItem
{
	public Guid ServerId { get; set; }

	public required string Name { get; set; }
}
