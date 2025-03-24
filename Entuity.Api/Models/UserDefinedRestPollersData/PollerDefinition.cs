namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Holds details of this poller's definition
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838655745565-User-Defined-REST-Poller-Details-RESTful-API#get'/></para>
/// </summary>
public class PollerDefinition
{
	/// <summary>
	/// Type of poller. Currently only "API" is supported, but "SNMP" may be supported in future versions
	/// </summary>
	public string PollerType { get; set; } = string.Empty;

	/// <summary>
	/// Sub-type of poller. Currently only "ASSOCIATED_COMPONENT" is supported
	/// </summary>
	public string PollerCollectorType { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier for the REST poller
	/// </summary>
	public int PollerId { get; set; }

	/// <summary>
	/// Unique poller name, without spaces. Alpha numeric characters and underscores are allowed but other characters are invalid. Should start with udp_ and this will be added if missing
	/// </summary>
	public string PollerName { get; set; } = string.Empty;

	/// <summary>
	/// The version of the poller
	/// </summary>
	public double Version { get; set; }

	/// <summary>
	/// The revision number of the poller. This is incremented each time a user edits this poller
	/// </summary>
	public int Revision { get; set; }

	/// <summary>
	/// Optional number determining collector priority. Can be omitted
	/// </summary>
	public double Priority { get; set; }

	/// <summary>
	/// StormWorks type name of the type of object this poller will connect to. This will be a device or associated device type such as "DeviceEx", "PingOnlyDevice" or "MerakiDevice"
	/// </summary>
	public string ContextTypeName { get; set; } = string.Empty;

	/// <summary>
	/// Specifies details of the component type of object(s) that will be created by the poller. For ASSOCIATED_COMPONENT pollers (the only ones currently supported) the typeName field should be the same as the pollerName, and a typeDisplayName field should also be supplied to specify the display name for the single associated object
	/// </summary>
	public required ComponentTypeDetails ComponentTypeDetails { get; set; }

	/// <summary>
	/// Determines which of the applicable objects the poller will actually be applied to. Can be omitted or left null to apply to all of them
	/// </summary>
	public required FilterDefinition FilterDefinition { get; set; }

	/// <summary>
	/// Frequency (in seconds) that the data will be polled at. Usually restricted to the following values: 60, 300, 600, 900, 1200, 1800, 3600, 21600, 43200, 86400
	/// </summary>
	public int ObtainRate { get; set; }

	/// <summary>
	/// Length of time (in seconds) which polled data will be retained. Usually restricted to the following values: 3600, 86400, 604800, 1209600, 3024000, 16934400
	/// </summary>
	public int KeepTime { get; set; }

	/// <summary>
	/// List of the poller steps within this poller
	/// </summary>
	public required IEnumerable<PollerStep> Steps { get; set; }
}