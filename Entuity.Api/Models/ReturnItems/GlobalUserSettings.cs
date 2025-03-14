namespace Entuity.Api.Models.ReturnItems;

public class GlobalUserSettings
{
	public int PwChangeDays { get; set; }

	public int PwdChangeNoticePeriod { get; set; }

	public int TimeoutMinutes { get; set; }

	public int LockAttempts { get; set; }

	public int LockDurationFailedAttempts { get; set; }
}
