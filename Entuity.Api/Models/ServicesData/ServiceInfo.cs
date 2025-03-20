namespace Entuity.Api.Models.ServicesData;

public class ServiceInfo
{
	public int ServiceId { get; set; }

	public string ServiceName { get; set; } = string.Empty;

	public int ServiceType { get; set; }

	public int ServiceAtLeastValue { get; set; }

	public int ServiceDegradedThreshold { get; set; }

	public bool RaiseEvents { get; set; }

	public bool TreatUnknownAsDown { get; set; }

	public float ServiceSlaGoal { get; set; }

	public int ServiceWebImage { get; set; }

	public string DescriptiveAlias { get; set; } = string.Empty;

	public string OwnerId { get; set; } = string.Empty;

	public bool HasAdminPermission { get; set; }

	public IEnumerable<object>? AvailableEyeServers { get; set; }

	public IEnumerable<object>? DefaultEyeServerId { get; set; }

	public IEnumerable<ServiceUser> Users { get; set; } = [];

	public bool AggregateEnable { get; set; }

	public string ServiceTag { get; set; } = string.Empty;

	public string Message { get; set; } = string.Empty;

	public string ShortServiceName { get; set; } = string.Empty;

	public int AuditLogWriter { get; set; }
}

