using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UsersData.Update;

/// <summary>
/// Represents the properties that can be updated on a user.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829714893085-User-Details-RESTful-API#put'/></para>
/// </summary>
public class UserUpdate
{
	/// <summary>
	/// Number of failed login attempts before locking the account. Value -1 to disable.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? LockAttempts { get; set; }

	/// <summary>
	/// Duration (minutes) the account is locked for after reaching maximum failed attempts.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? LockDurationFailedAttempts { get; set; }

	/// <summary>
	/// Unix timestamp of the date on which the account will expire. Value -1 to disable.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ExpiryDays { get; set; }

	/// <summary>
	/// Number of minutes after which session becomes inactive. Value -1 to disable.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? TimeoutMinutes { get; set; }

	/// <summary>
	/// Days to password change. Value -1 to disable.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? PwChangeDays { get; set; }

	/// <summary>
	/// Whether the user needs to change their password.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? ForcePWChange { get; set; }

	/// <summary>
	/// List of groups that this user is a member of.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<string>? Groups { get; set; }
}

