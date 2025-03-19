using System.Runtime.Serialization;

namespace Entuity.Api.Enums;

/// <summary>
/// Enum for the recurrence kind of a maintenance schedule, includes:
/// <list type="bullet">
/// <item>EveryDay</item>
/// <item>WeekDays</item>
/// <item>MonthDays</item>
/// </list>
/// </summary>
public enum RecurrenceKind
{
	[EnumMember(Value = "EVERY_DAY")]
	EveryDay,

	[EnumMember(Value = "WEEK_DAYS")]
	WeekDays,

	[EnumMember(Value = "MONTH_DAYS")]
	MonthDays
}
