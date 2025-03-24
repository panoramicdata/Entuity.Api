using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Update;

/// <summary>
/// Holds Optional data for updating a RestPoller
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838655745565-User-Defined-REST-Poller-Details-RESTful-API#put'/></para>
/// </summary>
public class RestPollerUpdate
{
	/// <summary>
	/// Type of poller. Currently only "API" is supported, but "SNMP" may be supported in future versions
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? PollerType { get; set; }

	/// <summary>
	/// Sub-type of poller. Currently only "ASSOCIATED_COMPONENT" is supported
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? PollerCollectorType { get; set; }

	/// <summary>
	/// StormWorks type name of the type of object this poller will connect to. This will be a device or associated device type such as "DeviceEx", "PingOnlyDevice" or "MerakiDevice"
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ContextTypeName { get; set; }

	/// <summary>
	/// Specifies details of the component type of object(s) that will be created by the poller. For ASSOCIATED_COMPONENT pollers (the only ones currently supported) the typeName field should be the same as the pollerName, and a typeDisplayName field should also be supplied to specify the display name for the single associated object
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public ComponentTypeDetails? ComponentTypeDetails { get; set; }

	/// <summary>
	/// Optional number determining collector priority. Can be omitted
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Priority { get; set; }

	/// <summary>
	/// Determines which of the applicable objects the poller will actually be applied to. Can be omitted or left null to apply to all of them
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public FilterDefinition? FilterDefinition { get; set; }

	/// <summary>
	/// Frequency (in seconds) that the data will be polled at. Usually restricted to the following values: 60, 300, 600, 900, 1200, 1800, 3600, 21600, 43200, 86400
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ObtainRate { get; set; }

	/// <summary>
	/// Length of time (in seconds) which polled data will be retained. Usually restricted to the following values: 3600, 86400, 604800, 1209600, 3024000, 16934400
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? KeepTime { get; set; }

	/// <summary>
	/// List of the poller steps within this poller
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<PollerStep>? Steps { get; set; }
}
