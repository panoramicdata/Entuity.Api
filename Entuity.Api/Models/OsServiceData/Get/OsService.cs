using System.Text.Json.Serialization;

namespace Entuity.Api.Models.OsServiceData.Get;

/// <summary>
/// Holds information about an OS service rule
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838606626333-OS-Services-Summary-RESTful-API#get'/></para>
/// </summary>
public class OsService : Entity<int>
{
	/// <summary>
	/// The OS Service name that is being filtered for in the rule
	/// </summary>
	public string ServiceName { get; set; } = string.Empty;

	/// <summary>
	/// the description of the OS Service, as defined by the user
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// type of filter to apply to the service name, either:
	/// <list type="bullet">
	/// <item>0: Equals</item>
	/// <item>1: Contains</item>
	/// </list>
	/// </summary>
	public int FilterUsing { get; set; }

	/// <summary>
	/// operating system of the rule:
	/// <list type="bullet">
	/// <item>0: Windows</item>
	/// <item>1: Linux (currently inapplicable)</item>
	/// </list>
	/// </summary>
	public int OperatingSystem { get; set; }

	/// <summary>
	/// If the OS Service rule is currently enabled, either 'true' or 'false'
	/// </summary>
	[JsonPropertyName("enabled")]
	public bool IsEnabled { get; set; }

	public int AuditLogWriter { get; set; }
}
