using Entuity.Api.Interfaces;

namespace Entuity.Api.Models;

public class IncidentFilter : Entity<string>, IReturnItem
{
	public Guid ServerId { get; set; }

	public string? Name { get; set; }
}
