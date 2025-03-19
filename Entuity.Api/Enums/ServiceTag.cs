using System.Runtime.Serialization;

namespace Entuity.Api.Enums;

/// <summary>
/// Service tag for reports. Can be:
/// <list type="bullet">
/// <item>'Standard'</item>
/// <item>'Branch'</item>
/// <item>'CIO'</item>
/// </list>
/// </summary>
public enum ServiceTag
{
	[EnumMember(Value = "Standard")]
	Standard,

	[EnumMember(Value = "Branch")]
	Branch,

	[EnumMember(Value = "CIO")]
	CIO
}
