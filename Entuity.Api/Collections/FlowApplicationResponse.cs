using Entuity.Api.Models;

namespace Entuity.Api.Collections;

public class FlowApplicationResponse
{
	public IEnumerable<FlowApplication> Applications { get; set; } = [];
}
