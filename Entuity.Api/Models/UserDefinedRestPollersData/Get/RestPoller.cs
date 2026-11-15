using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Get;

/// <summary>
/// Represents a REST poller specified on the Entuity server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#get'/></para>
/// </summary>
public class RestPoller : RestPollerBase, IGetItem
{
	/// <summary>
	/// StormWorks type name of the type of object this poller will connect to. This will be a device or associated device type such as "DeviceEx", "PingOnlyDevice" or "MerakiDevice"
	/// </summary>
	public required string ContextTypeName { get; set; }

	/// <summary>
	/// 
	/// </summary>
	public string? ExtendedTypeName { get; set; }

	/// <summary>
	/// Unique StormWorks type name for the component type
	/// </summary>
	public required string ComponentTypeName { get; set; }

	/// <summary>
	/// Description of the association
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Count of the number of steps in the poller
	/// </summary>
	public int StepCount { get; set; }

	/// <summary>
	/// Names of the steps in the poller
	/// </summary>
	public string StepNames { get; set; } = string.Empty;

	public IEnumerable<int>? ServerIds { get; set; } = [];

	public IEnumerable<int> MissingServerIds { get; set; } = [];

	/// <summary>
	/// Sub-type of poller. Currently only "ASSOCIATED_COMPONENT" is supported
	/// </summary>
	public string PollerCollectorType { get; set; } = string.Empty;
}
