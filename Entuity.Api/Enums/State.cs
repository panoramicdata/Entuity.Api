using System.Runtime.Serialization;

namespace Entuity.Api.Enums;
public enum State
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
