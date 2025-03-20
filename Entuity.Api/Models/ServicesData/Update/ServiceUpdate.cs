using Entuity.Api.Enums;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ServicesData.Update;

/// <summary>
/// A Model that contains optional properties used to update a Service.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838553899165-Service-Detail-RESTful-API#put'/></para>
/// </summary>
public class ServiceUpdate
{
	/// <summary>
	/// User-specified service name.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ServiceName { get; set; }

	/// <summary>
	/// Type of service logic:
	/// <list type="bullet">
	/// <item>0 None</item>
	/// <item>1 And</item>
	/// <item>2 Or</item>
	/// <item>3 Not</item>
	/// <item>4 At Least</item>
	/// </list>
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ServiceType { get; set; }

	/// <summary>
	/// If the service logic type (serviceType) is 4 At Least, the serviceAtLeastValue specifies the minimum number of components that should be OK for the service to be considered OK
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ServiceAtLeastValue { get; set; }

	/// <summary>
	/// If the service logic type (serviceType) is 4 At Least,  the serviceDegradedThreshold value specifies the value at which the service will be considered to be degraded
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ServiceDegradedThreshold { get; set; }

	/// <summary>
	/// Whether the service will raise events upon state change, either true or false
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? RaiseEvents { get; set; }

	/// <summary>
	/// SLA availability goal in % (e.g. 99.0 = 99%)
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public float? ServiceSlaGoal { get; set; }

	/// <summary>
	/// User-specified description of service
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? DescriptiveAlias { get; set; }

	/// <summary>
	/// If traffic across all ports is aggregated
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? AggregateEnable { get; set; }

	/// <inheritdoc cref="Enums.ServiceTag"/>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public ServiceTag? ServiceTag { get; set; }

	/// <summary>
	/// User-specified short name of service
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ShortServiceName { get; set; }
}

