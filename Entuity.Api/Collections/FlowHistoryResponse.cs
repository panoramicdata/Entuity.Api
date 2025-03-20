using Entuity.Api.Models;

namespace Entuity.Api.Collections;

public class FlowHistoryResponse
{
	public required IEnumerable<SampleSet> SampleSets { get; set; } = [];
}
