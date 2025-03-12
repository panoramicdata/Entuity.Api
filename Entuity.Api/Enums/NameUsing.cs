using System.Runtime.Serialization;

namespace Entuity.Api.Enums;

/// <summary>
/// Device Name is determined using either:
/// <list type="bullet">
/// <item>CUSTOMNAME</item>
/// <item>IPADDRESS</item>
/// <item>POLLEDNAME</item>
/// <item>RESOLVABLENAME</item>
/// <item>RESOLVABLENAMEFQ</item>
/// <item>SYSTEMNAME</item>
/// </list>
/// </summary>
public enum NameUsing
{
	[EnumMember(Value = "CUSTOMNAME")]
	CustomName,

	[EnumMember(Value = "IPADDRESS")]
	IpAddress,

	[EnumMember(Value = "POLLEDNAME")]
	PolledName,

	[EnumMember(Value = "RESOLVABLENAME")]
	ResolvableName,

	[EnumMember(Value = "RESOLVABLENAMEFQ")]
	ResolvableNameFq,

	[EnumMember(Value = "SYSTEMNAME")]
	SystemName
}
