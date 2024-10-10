using System.Runtime.Serialization;

namespace Entuity.Api.Enums;
public enum EventState
{
	[EnumMember(Value = "open")]
	Open,

	[EnumMember(Value = "closed")]
	Closed,

	[EnumMember(Value = "finalized")]
	Finalized,

	[EnumMember(Value = "all")]
	All
}
