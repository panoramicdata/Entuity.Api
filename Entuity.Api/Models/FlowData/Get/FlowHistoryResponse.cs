namespace Entuity.Api.Models.FlowData.Get;

public class FlowHistoryResponse
{
	public required IEnumerable<SampleSet> SampleSets { get; set; } = [];
}
