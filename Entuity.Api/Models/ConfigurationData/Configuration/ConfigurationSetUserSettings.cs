namespace Entuity.Api.Models.ConfigurationData.Configuration;

/// <summary>
/// Individual user settings, e.g. timeout, account locking, password expiry
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840473167517-Config-Sets-Users-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetUserSettings
{
	/// <summary>
	/// Number of minutes of inactivity after which the user will be logged out
	/// </summary>
	public int TimeoutMinutes { get; set; }

	/// <summary>
	/// Number of failed attempts to log in after which the user will be locked out, -1 to disable
	/// </summary>
	public int LockAttempts { get; set; }

	/// <summary>
	/// Number of minutes for which the user will be locked out after exceeding the lockAttempts figure. -1 disables this, and it will revert to global settings, if any
	/// </summary>
	public int LockDurationFailedAttempts { get; set; }

	/// <summary>
	/// Number of days after which the user account will expire. -1 disables this
	/// </summary>
	public int ExpiryDays { get; set; }

	/// <summary>
	/// Number of days until password change. -1 disables this
	/// </summary>
	public int PwChangeDays { get; set; }

	/// <summary>
	/// How many days' notice during which a password expiration warning will be displayed before the password expires
	/// </summary>
	public int PasswordExpiryNoticePeriod { get; set; }

	/// <summary>
	/// If the global user password settings are overriden, either 'true' or 'false'
	/// </summary>
	public bool OverridePasswordSettings { get; set; }

	/// <summary>
	/// Specify whether to force the user to change their password the next time they log in, either 'true' or 'false'
	/// </summary>
	public bool ForcePWChange { get; set; }
}