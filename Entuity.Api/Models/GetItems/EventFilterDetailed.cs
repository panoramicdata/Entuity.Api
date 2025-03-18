namespace Entuity.Api.Models.GetItems;

public class EventFilterDetailed
{
	public string Name { get; set; } = string.Empty;

	public IEnumerable<string>? SelectedNames { get; set; }

	public bool SystemFilter { get; set; }

	public bool PassIP { get; set; }
}

