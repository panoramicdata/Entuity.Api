using System.Runtime.Serialization;

namespace Entuity.Api.Enums;
public enum IncidentState
{
	[EnumMember(Value = "open")]
	Open,

	[EnumMember(Value = "closed")]
	Closed,

	[EnumMember(Value = "expire")]
	Expire,

	[EnumMember(Value = "all")]
	All
}
