using Entuity.Api.Models.AutoDiscoveryData.Get;

namespace Entuity.Api.Collections;

public class AutoDiscoveryResponse
{
	public IEnumerable<AutoDiscovery> Settings { get; set; } = [];
}
