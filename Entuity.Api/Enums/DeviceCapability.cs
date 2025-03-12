using System.Runtime.Serialization;

namespace Entuity.Api.Enums;

public enum DeviceCapability
{
	[EnumMember(Value = "routing")]
	Routing,

	[EnumMember(Value = "switching")]
	Switching,

	[EnumMember(Value = "switching & routing")]
	SwitchingAndRouting,
}
