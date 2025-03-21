namespace Entuity.Api.Models.ServicesData;

/// <summary>
/// Holds information about the Service
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838553899165-Service-Detail-RESTful-API#get'/></para>
/// </summary>
public class ServiceInfo
{
	/// <summary>
	/// Unique identifier of the Service
	/// </summary>
	public int ServiceId { get; set; }

	/// <summary>
	/// User-Specified name of the service
	/// </summary>
	public string ServiceName { get; set; } = string.Empty;

	/// <summary>
	/// type of service logic
	/// <list type="bullet">
	/// <item>0 None</item>
	/// <item>1 And</item>
	/// <item>2 Or</item>
	/// <item>3 Not</item>
	/// <item>4 At Least</item>
	/// </list>
	/// </summary>
	public int ServiceType { get; set; }

	/// <summary>
	/// If the service logic type (serviceType) is 4 At Least, the serviceAtLeastValue specifies the minimum number of components that should be OK for the service to be considered OK
	/// </summary>
	public int ServiceAtLeastValue { get; set; }

	/// <summary>
	/// If the service logic type (serviceType) is 4 At Least,  the serviceDegradedThreshold value specifies the value at which the service will be considered to be degraded
	/// </summary>
	public int ServiceDegradedThreshold { get; set; }

	/// <summary>
	/// Whether the service will raise events upon state change, either true or false
	/// </summary>
	public bool RaiseEvents { get; set; }

	/// <summary>
	/// Whether the service will treat Unknown statuses as Down, either true or false
	/// </summary>
	public bool TreatUnknownAsDown { get; set; }

	/// <summary>
	/// SLA availability goal in % (e.g. 99.0 = 99%)
	/// </summary>
	public float ServiceSlaGoal { get; set; }

	/// <summary>
	/// not used
	/// </summary>
	public int ServiceWebImage { get; set; }

	/// <summary>
	/// User-specified description of service
	/// </summary>
	public string DescriptiveAlias { get; set; } = string.Empty;

	/// <summary>
	/// String ID of the user who owns the service
	/// </summary>
	public string OwnerId { get; set; } = string.Empty;

	/// <summary>
	/// If the service was created by an Admin user (meaning that the service has access to components that may be admin only), either true or false
	/// </summary>
	public bool HasAdminPermission { get; set; }

	/// <summary>
	/// List of external (remote) servers that the server accesses
	/// </summary>
	public IEnumerable<object>? AvailableEyeServers { get; set; }

	/// <summary>
	/// Default server from list of external (remote) servers
	/// </summary>
	public IEnumerable<object>? DefaultEyeServerId { get; set; }

	/// <summary>
	/// List of users that have access to this service. Consists of the username and their ID
	/// </summary>
	public IEnumerable<ServiceUser> Users { get; set; } = [];

	/// <summary>
	/// If traffic across all ports is aggregated
	/// </summary>
	public bool AggregateEnable { get; set; }

	/// <summary>
	/// service tags for reports. Can be:
	/// <list type="bullet">
	/// <item>Standard</item>
	/// <item>Branch</item>
	/// <item>CIO</item>
	/// </list>
	/// </summary>
	public string ServiceTag { get; set; } = string.Empty;

	/// <summary>
	/// "OK" if no error occurred, otherwise the error message will appear here
	/// </summary>
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// User friendly name of the service
	/// </summary>
	public string ShortServiceName { get; set; } = string.Empty;

	public int AuditLogWriter { get; set; }
}

