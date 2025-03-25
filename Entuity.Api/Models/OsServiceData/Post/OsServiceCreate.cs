using System.Text.Json.Serialization;

namespace Entuity.Api.Models.OsServiceData.Post;

/// <summary>
/// Holds information for creating a new OS service rule.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838606626333-OS-Services-Summary-RESTful-API#post'/></para>
/// </summary>
public class OsServiceCreate
{
	/// <summary>
	/// The OS Service name that is being filtered for in the rule
	/// </summary>
	public required string ServiceName { get; set; }

	/// <summary>
	/// Description of the OS Service, as entered by the user
	/// </summary>
	public required string Description { get; set; }

	/// <summary>
	/// type of filter to apply to the service name, either:
	/// <list type="bullet">
	/// <item>0: Equals</item>
	/// <item>1: Contains</item>
	/// </list>
	/// </summary>
	public required int FilterUsing { get; set; }

	/// <summary>
	/// Operating system of the rule:
	/// <list type="bullet">
	/// <item>0: Windows</item>
	/// <item>1: Linux (currently inapplicable)</item>
	/// </list>
	/// </summary>
	public required int OperatingSystem { get; set; }

	/// <summary>
	/// If the OS Service rule is currently enabled, either 'true' or 'false'
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? Enabled { get; set; }
}
