using System.Runtime.Serialization;

namespace Entuity.Api.Enums;
public enum TemplateType
{
	[EnumMember(Value = "USER")]
	USER,
	[EnumMember(Value = "SYSTEM")]
	SYSTEM
}
