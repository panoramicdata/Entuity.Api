namespace Entuity.Api.Models;

public class IncidentFilter : Entity<string>
{
	public Guid ServerId { get; set; }

	public string? Name { get; set; }
}
