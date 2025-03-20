using Entuity.Api.Enums;
using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.InventoryData.Get;

public class InventoryItemDetailed : Entity<string>, IGetItem
{
	/// <summary>
	/// Device Capabilities: routing, switching, switching and routing
	/// </summary>
	/// <remarks>Left Null if not applicable</remarks>
	public DeviceCapability? Capabilities { get; set; }

	/// <summary>
	/// If the Device has been certified
	/// </summary>
	[JsonPropertyName("certified")]
	public string? IsCertified { get; set; }

	/// <summary>
	/// ID of the config management credential set
	/// </summary>
	public int? CmCredentialId { get; set; }

	/// <summary>
	/// Name of the config management credential - this name will only be displayed if it is a shared credential (i.e not a local credential)
	/// </summary>
	public string? CmCredentialName { get; set; }

	/// <summary>
	/// If Configuration Management is enabled (true) or disabled (false)
	/// </summary>
	public bool? ConfigManagementLicense { get; set; }

	public object? Context { get; set; }

	/// <summary>
	/// ID of the shared credential set, used for SNMP and virtualization assets. The credential must be a valid credential for the specified device type. credentialId is based on the credentials you have created and therefore can be any value. E.g. if credentialId = 1 is an SNMP credential, and the device requires an API Key credential, the request will then fail
	/// </summary>
	public int? CredentialId { get; set; }

	public string? CredentialName { get; set; }

	/// <summary>
	/// Device type.
	/// </summary>
	public string? DeviceType { get; set; }

	public string? DeviceName { get; set; }

	/// <summary>
	/// Device’s stormworks identifier.
	/// </summary>
	public int? DsObjectId { get; set; }

	/// <summary>
	/// connection method used to the hardware asset, which is the collector name based on the device type being added, from the following:
	/// </summary>
	public string? HwConnMethod { get; set; }

	/// <summary>
	/// Connection port used to the hardware asset.
	/// </summary>
	public string? HwConnPort { get; set; }

	/// <summary>
	/// ID of the hardware asset credential set.
	/// </summary>
	public int? HwCredentialId { get; set; }

	/// <summary>
	/// Name of the hardware credential - this name will only be displayed if it is a shared credential (i.e. not a local credential).
	/// </summary>
	public string? HwCredentialName { get; set; }

	/// <summary>
	/// Management IP address.
	/// </summary>
	public string? ManagementIP { get; set; }

	public string? ManagementLevel { get; set; }

	/// <summary>
	/// Device Name
	/// </summary>
	public string? Name { get; set; } = string.Empty;

	/// <inheritdoc cref="Enums.NameUsing"/>
	public NameUsing? NameUsing { get; set; }

	/// <inheritdoc cref="ConnectionMethod"/>
	public string? OsConnMethod { get; set; }

	/// <summary>
	/// Connection port used to the OS.
	/// </summary>
	public int? OsConnPort { get; set; }

	/// <summary>
	/// ID of the OS credential set.
	/// </summary>
	public int? OsCredentialId { get; set; }

	/// <summary>
	/// Name of the OS credential - this name will only be displayed if it is a shared credential (i.e. not a local credential).
	/// </summary>
	public string? OsCredentialName { get; set; }

	/// <summary>
	/// DNS name or IP Address.
	/// </summary>
	public string? PolledName { get; set; }

	/// <summary>
	/// Transport protocol: IPv4 or IPv6.
	/// </summary>
	public TransportProtocol Protocol { get; set; }

	/// <summary>
	/// Server identifier.
	/// </summary>
	public Guid? ServerId { get; set; }

	/// <summary>
	/// Whether SNMPBulkGet is used ('true' or 'false', by default false).
	/// </summary>
	public bool? SnmpBulk { get; set; }

	/// <summary>
	/// Maximum size of SNMP PDU, where 0 = system default.
	/// </summary>
	public int? SnmpPDUSize { get; set; }

	/// <summary>
	/// SNMP port number (if omitted, the default value will be used).
	/// </summary>
	public int? SnmpPort { get; set; }

	/// <summary>
	/// Number of SNMP retries, where 0 = system default.
	/// </summary>
	public int? SnmpRetry { get; set; }

	/// <summary>
	/// SNMP timeout in seconds, where 0 = system default.
	/// </summary>
	public int? SnmpTimeout { get; set; }

	/// <summary>
	/// SNMP version: v1, v2, v3 or v1/2. For a non-SNMP device, this will be 'none'.
	/// </summary>
	public string? SnmpType { get; set; }

	/// <summary>
	/// SNMP description field.
	/// </summary>
	public string? SysDescription { get; set; }

	/// <summary>
	/// SNMP retrieved system Location field.
	/// </summary>
	public string? SysLocation { get; set; }

	/// <summary>
	/// SNMP system identifier field.
	/// </summary>
	public string? SysOid { get; set; }

	public int? UdCredentialId { get; set; }


	public string? UdCredentialName { get; set; }
	/// <summary>
	/// Connection method used to the user defined object.
	/// </summary>
	public object? UdConnMethod { get; set; }

	/// <summary>
	/// Connection port used to the user defined object.
	/// </summary>
	public int? UdConnPort { get; set; }

	/// <summary>
	/// SNMP v3 user name.
	/// </summary>
	public string? Username { get; set; }

	/// <summary>
	/// Virtual platform URL (non-Amazon virtual platforms).
	/// </summary>
	public string? WebURL { get; set; }

	public string? WebPlatformType { get; set; }

	/// <summary>
	/// The ID of a zone.
	/// </summary>
	public int? ZoneId { get; set; }
}
