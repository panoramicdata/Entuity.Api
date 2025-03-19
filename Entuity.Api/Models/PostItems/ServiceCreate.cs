using Entuity.Api.Enums;

namespace Entuity.Api.Models.PostItems;

/// <summary>
/// Holds the required and optional properties used to create a new Service
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838522122269-Services-Hierarchy-RESTful-API#post'/></para>
/// </summary>
public class ServiceCreate
{
	/// <summary>
	/// User-specified name of service.
	/// </summary>
	public required string ServiceName { get; set; }

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
	public int? ServiceType { get; set; }

	/// <summary>
	/// If the service logic type (serviceType) is 4 At Least, the serviceAtLeastValue specifies the minimum number of components that should be OK for the service to be considered OK
	/// </summary>
	public int? ServiceAtLeastValue { get; set; }

	/// <summary>
	/// Value in which the service will be considered to be degraded
	/// </summary>
	public int? ServiceDegradedThreshold { get; set; }

	/// <summary>
	/// If the service will raise events upon a state change, either true or false.
	/// </summary>
	public bool? RaiseEvents { get; set; }

	/// <summary>
	/// SLA Availability goal in % (e.g. 99.0 = 99%)
	/// </summary>
	public float? ServiceSlaGoal { get; set; }

	/// <summary>
	/// User-specified description of service
	/// </summary>
	public string? DescriptiveAlias { get; set; }

	/// <summary>
	/// If traffic across all ports is aggregated
	/// </summary>
	public bool? AggregateEnable { get; set; }

	/// <inheritdoc cref="Enums.ServiceTag"/>
	public ServiceTag? ServiceTag { get; set; }

	/// <summary>
	/// User-specified short name of service
	/// </summary>
	public string? ShortServiceName { get; set; }
}

