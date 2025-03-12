namespace Entuity.Api.Models;

public class FlowHistoryResponse
{
	public required IEnumerable<SampleSet> SampleSets { get; set; } = [];
}
