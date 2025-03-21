using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Get;

/// <summary>
/// Represents a REST poller specified on the Entuity server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#get'/></para>
/// </summary>
public class RestPoller : IGetItem
{
	/// <summary>
	/// Unique identifier for the REST poller
	/// </summary>
	public int PollerId { get; set; }

	/// <summary>
	/// Type of poller. Currently only "API" is supported, but "SNMP" may be supported in future versions
	/// </summary>
	public string PollerType { get; set; } = string.Empty;

	/// <summary>
	/// Unique poller name, without spaces. Alpha numeric characters and underscores are allowed but other characters are invalid. Should start with udp_ and this will be added if missing
	/// </summary>
	public string PollerName { get; set; } = string.Empty;

	/// <summary>
	/// Unix timestamp for when this poller was first created
	/// </summary>
	public int CreationTime { get; set; }

	/// <summary>
	/// Name of Entuity user that created this poller
	/// </summary>
	public required string CreatedBy { get; set; }

	/// <summary>
	/// Unix timestamp for when this poller was last modified
	/// </summary>
	public int LastModified { get; set; }

	/// <summary>
	/// User that last modified this poller
	/// </summary>
	public required string ModifiedBy { get; set; }

	/// <summary>
	/// Version number
	/// </summary>
	public double Version { get; set; }

	/// <summary>
	/// Revision number. This is incremented each time the user edits this poller
	/// </summary>
	public int Revision { get; set; }

	/// <summary>
	/// Number determining collector priority
	/// </summary>
	public double Priority { get; set; }

	/// <summary>
	/// This field is currently redundant and will always be null
	/// </summary>
	public Guid? ServerId { get; set; }

	/// <summary>
	/// Number of errors while creating this poller. Should be zero or null for a successful poller
	/// </summary>
	public int? ErrorCount { get; set; }

	/// <summary>
	/// Whether the poller is enabled or not
	/// </summary>
	public bool Enabled { get; set; }

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
