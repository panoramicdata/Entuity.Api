using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

public class IncidentFilterSimple : Entity<string>, IReturnItem
{
	public Guid ServerId { get; set; }

	public string? Name { get; set; }
}
