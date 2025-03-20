namespace Entuity.Api.Models.ConfigurationData.ServerGroupConfig;

/// <summary>
/// Represents a User in the system.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#get'/></para>
/// </summary>
public class User
{
	/// <summary>
	/// Username of a user in the config set
	/// </summary>
	public string UserName { get; set; } = string.Empty;

	/// <summary>
	/// The user's password
	/// </summary>
	public string Password { get; set; } = string.Empty;

	/// <summary>
	/// Individual user settings, e.g. timeout, account locking, password expiry
	/// </summary>
	public object? Settings { get; set; }

	/// <summary>
	/// ID of the change that created the current password
	/// </summary>
	public int PasswordChangeId { get; set; }
}
