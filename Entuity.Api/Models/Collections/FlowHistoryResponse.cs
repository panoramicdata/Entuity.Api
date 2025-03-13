namespace Entuity.Api.Models.Collections;

public class FlowHistoryResponse
{
	public required IEnumerable<SampleSet> SampleSets { get; set; } = [];
}
