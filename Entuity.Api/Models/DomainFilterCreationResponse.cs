namespace Entuity.Api.Models;

public class DomainFilterCreationResponse
{
	public string Name { get; set; } = string.Empty;

	public bool SystemFilter { get; set; }

	public IEnumerable<object> Rules { get; set; } = [];
}
