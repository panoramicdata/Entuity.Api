namespace Entuity.Api.Models.GetItems;

/// <summary>
/// Holds details about Global User Settings.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829745428637-Users-Global-User-Settings-RESTful-API#get'/></para>
/// </summary>
public class GlobalUserSettings
{
	/// <summary>
	/// Days to password change. Value -1 to disable
	/// </summary>
	public int PwChangeDays { get; set; }

	/// <summary>
	/// Number of days to display a warning before a password change is required. Value 0 to disable
	/// </summary>
	public int PwdChangeNoticePeriod { get; set; }

	/// <summary>
	/// Number of minutes after which session becomes inactive. Value -1 to disable
	/// </summary>
	public int TimeoutMinutes { get; set; }

	/// <summary>
	/// Number of failed login attempts before locking the account. Value -1 to disable
	/// </summary>
	public int LockAttempts { get; set; }

	/// <summary>
	/// Duration (minutes) the account is locked for after reaching maximum failed attempts
	/// </summary>
	public int LockDurationFailedAttempts { get; set; }
}
