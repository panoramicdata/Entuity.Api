using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ReturnItems;


public class IncidentFilterDetailed : IReturnItem
{
	public string Name { get; set; } = string.Empty;

	public IEnumerable<string>? SelectedNames { get; set; }

	public bool SystemFilter { get; set; }

	public bool PassIP { get; set; }
}

