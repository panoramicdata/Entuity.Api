using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UsersData.Get;

public class UserDetailed : Entity<int>
{
	/// <summary>
	/// Name of the user.
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Number of failed login attempts before locking the account. Value -1 to disable.
	/// </summary>
	public int LockAttempts { get; set; }

	/// <summary>
	/// Duration (minutes) the account is locked for after reaching maximum failed attempts.
	/// </summary>
	public int LockDurationFailedAttempts { get; set; }

	/// <summary>
	/// Unix timestamp of the date on which the account will expire. Value -1 to disable.
	/// </summary>
	public int ExpiryDays { get; set; }

	/// <summary>
	/// Number of minutes after which session becomes inactive. Value -1 to disable.
	/// </summary>
	public int TimeoutMinutes { get; set; }

	/// <summary>
	/// Days to password change. Value -1 to disable.
	/// </summary>
	public int PwChangeDays { get; set; }

	/// <summary>
	/// Whether the user needs to change their password.
	/// </summary>
	public bool ForcePWChange { get; set; }

	/// <summary>
	/// Number of days to display a warning before a password change is required. Value 0 to disable.
	/// </summary>
	public int PasswordExpiryNoticePeriod { get; set; }

	/// <summary>
	/// List of groups that this user is a member of.
	/// </summary>
	public IEnumerable<string> Groups { get; set; } = [];

	/// <summary>
	/// “locked” status of the user.
	/// </summary>
	[JsonPropertyName("locked")]
	public bool IsLocked { get; set; }

	/// <summary>
	/// Is the user account expired.
	/// </summary>
	[JsonPropertyName("expired")]
	public bool IsExpired { get; set; }

	/// <summary>
	/// Is the user is admin.
	/// </summary>
	[JsonPropertyName("admin")]
	public bool IsAdmin { get; set; }
}
