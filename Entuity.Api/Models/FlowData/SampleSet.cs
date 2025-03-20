using Entuity.Api.Models.FlowData.Get;

namespace Entuity.Api.Models.FlowData;

public class SampleSet
{
	public object? Keys { get; set; }

	public IEnumerable<FlowSample> Samples { get; set; } = [];
}
