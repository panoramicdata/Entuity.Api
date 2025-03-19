using Entuity.Api.Enums;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models;

/// <summary>
/// An Object that describes a schedule
/// </summary>
public class MaintenanceSchedule
{
	/// <summary>
	/// Time in which the schedule starts in seconds
	/// </summary>
	public required int Begins { get; set; }

	/// <summary>
	/// Time in which the schedule stops in seconds
	/// </summary>
	public required int Ends { get; set; }

	/// <summary>
	/// If false, the schedule will be active throughout the time between "begins" and "ends". If true, follows a recurrence of periods given by the below values, but only between "begins" and "ends"
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? Recurs { get; set; }

	/// <summary>
	/// Time of day the maintenance schedule should start being active in seconds. (Hours * 3600 + Minutes * 60 + Seconds) (e.g. 0 = 0000 hours (12 AM), 3600 = 0100 (1 AM), 34200 = 0930 (9:30AM))
	/// </summary>
	/// <remarks>
	/// If "daysSecondsFrom" = 0 and "daysSecondsTo" = 86400 (24 hours), then it will be active the whole day
	/// </remarks>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? DaysSecondsFrom { get; set; }

	/// <summary>
	/// time of day it should stop being active in seconds. Must be larger than "daysSecondsFrom"
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? DaysSecondsTo { get; set; }

	/// <inheritdoc cref="Enums.RecurrenceKind"/>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public RecurrenceKind? RecurrenceKind { get; set; }

	/// <summary>
	/// String description of valid days. Section of days are separated by a comma ",", and if there are 2 or more consecutive days then the first and last days are given with a hyphen "-" in between (e.g. "1, 5, 6-7, 10-22").
	/// <para>When setting this field, it is valid to contain consecutive days separately. If there are values greater than the maximum, those values will be ignored (e.g. 8 for "WEEK_DAYS").</para>
	/// <para>
	/// f "recurrenceKIND" is "WEEK_DAYS", this describes the week days on which the schedule should be active (max 7). (e.g. 1 = Monday, 7 = Sunday)
	/// </para>
	/// <para>
	/// If "recurrenceKind" is "MONTH_DAYS", this describes the days in a month on which the schedule should be active (max 31) (e.g. 3 = 3rd of every month, 31 = 31st of every month that has a 31st day)
	/// </para>
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ValidDays { get; set; }

	/// <summary>
	/// String description of valid months (e.g. 1 = January, 6 = June)
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ValidMonths { get; set; }

	/// <summary>
	/// If true, this maintenance will be active when outside of the given schedule.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? Invert { get; set; }
}

