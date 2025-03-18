namespace Entuity.Api.Models.GetItems;

public class DomainFilterDetailed
{
	public string Name { get; set; } = string.Empty;

	public bool SystemFilter { get; set; }

	public IEnumerable<object> Rules { get; set; } = [];
}
