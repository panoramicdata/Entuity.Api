namespace Entuity.Api.Models;

public class SampleSet
{
	public object? Keys { get; set; }

	public IEnumerable<FlowSample> Samples { get; set; } = [];
}
