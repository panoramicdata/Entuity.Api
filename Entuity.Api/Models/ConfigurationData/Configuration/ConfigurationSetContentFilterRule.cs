using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration;

/// <summary>
/// Holds information about a Content Filter Rule that is applied to a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840530161309-Config-Sets-Content-Filters-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetContentFilterRule
{
	/// <summary>
	/// Object source type to which this filter affects. One of the following:
	/// <list type="bullet">
	/// <item>1024 - application</item>
	/// <item>4 - device</item>
	/// <item>1 - port</item>
	/// <item>65536 - service</item>
	/// <item>8 - VLAN</item>
	/// </list>
	/// </summary>
	[JsonPropertyName("SRCTYPE")]
	public string Srctype { get; set; } = string.Empty;

	/// <summary>
	/// The device type to which this filter affects
	/// </summary>
	[JsonPropertyName("DEVTYPE")]
	public string? Devtype { get; set; }

	/// <summary>
	/// The port type to which this filter affects
	/// </summary>
	[JsonPropertyName("PORTTYPE")]
	public string? Porttype { get; set; }
}
