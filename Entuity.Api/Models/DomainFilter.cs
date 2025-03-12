namespace Entuity.Api.Models;

public class DomainFilter : Entity<string>
{
	public Guid ServerId { get; set; }

	public required string Name { get; set; }
}
