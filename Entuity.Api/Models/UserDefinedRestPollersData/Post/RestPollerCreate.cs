using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Post;

/// <summary>
/// Information needed to create a new REST poller.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class RestPollerCreate
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
	/// Unique poller name, without spaces. Alpha numeric characters and underscores are allowed but other characters are invalid. Should start with udp_ and this will be added if missing
	/// </summary>
	public string PollerName { get; set; } = string.Empty;

	/// <summary>
	/// StormWorks type name of the type of object this poller will connect to. This will be a device or associated device type such as "DeviceEx", "PingOnlyDevice" or "MerakiDevice"
	/// </summary>
	public string ContextTypeName { get; set; } = string.Empty;

	/// <summary>
	/// Specifies details of the component type of object(s) that will be created by the poller. For ASSOCIATED_COMPONENT pollers (the only ones currently supported) the typeName field should be the same as the pollerName, and a typeDisplayName field should also be supplied to specify the display name for the single associated object
	/// </summary>
	public required ComponentTypeDetails ComponentTypeDetails { get; set; }

	/// <summary>
	/// Optional number determining collector priority. Can be omitted
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Priority { get; set; }

	/// <summary>
	/// Determines which of the applicable objects the poller will actually be applied to. Can be omitted or left null to apply to all of them
	/// </summary>
	public required FilterDefinition FilterDefinition { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ObtainRate { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? KeepTime { get; set; }

	/// <summary>
	/// List of the poller steps within this poller
	/// </summary>
	public IEnumerable<PollerStep> Steps { get; set; } = [];
}
