using System.Text.Json.Serialization;

namespace Entuity.Api.Models.FiltersData;

/// <summary>
/// Represents a Filter Rule
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819563623453-Filters-Domain-Content-Filter-Details-RESTful-API#get'/></para>
/// </summary>
public class FilterRule
{
	/// <summary>
	/// source type, one of the following (case-insensitive):
	/// <list type="bullet">
	/// <item>PORT</item>
	/// <item>DEVICE</item>
	/// <item>VLAN</item>
	/// <item>APPLICATION</item>
	/// <item>SERVICE</item>
	/// </list>
	/// </summary>
	/// <remarks>Left Null if there is no value to Deserialize</remarks>
	[JsonPropertyName("SRCTYPE")]
	public string? SrcType { get; set; }

	/// <summary>
	/// Device type to which this filter refers
	/// </summary>
	/// <remarks>Left Null if there is no value to Deserialize</remarks>
	[JsonPropertyName("DEVTYPE")]
	public string? DevType { get; set; }

	/// <summary>
	/// Name of an object (port, device, application etc)
	/// </summary>
	/// <remarks>Left Null if there is no value to Deserialize</remarks>
	[JsonPropertyName("DEVNAME")]
	public string? DevName { get; set; }

	/// <summary>
	/// Name of a zone
	/// </summary>
	/// <remarks>Left Null if there is no value to Deserialize</remarks>
	[JsonPropertyName("ZONENAME")]
	public string? ZoneName { get; set; }

	/// <summary>
	/// IP low-end, used for defining IP ranges
	/// </summary>
	/// <remarks>Left Null if there is no value to Deserialize</remarks>
	[JsonPropertyName("IPLE")]
	public string? IpLe { get; set; }

	/// <summary>
	/// IP high-end, used for defining IP ranges
	/// </summary>
	/// <remarks>Left Null if there is no value to Deserialize</remarks>
	[JsonPropertyName("IPHE")]
	public string? IpHe { get; set; }

	/// <summary>
	/// Management IP Only
	/// </summary>
	/// <remarks>Left Null if there is no value to Deserialize</remarks>
	[JsonPropertyName("MANAGEMENT_ONLY")]
	public string? ManagementOnly { get; set; }

	/// <summary>
	/// Port type to which this filter refers
	/// </summary>
	[JsonPropertyName("PORTTYPE")]
	public string? PortType { get; set; }
}