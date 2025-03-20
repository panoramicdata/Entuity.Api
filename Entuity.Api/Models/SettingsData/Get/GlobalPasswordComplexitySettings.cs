namespace Entuity.Api.Models.SettingsData.Get;

/// <summary>
/// Holds details about Global Password Complexity Settings.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829770850845-Users-Global-Password-Complexity-Settings-RESTful-API#get'/></para>
/// </summary>
public class GlobalPasswordComplexitySettings
{
	/// <summary>
	/// Prevent recent previous passwords from being reused (limit 10).
	/// </summary>
	public int PwdHistoryLimit { get; set; }

	/// <summary>
	/// Minimum length of password.
	/// </summary>
	public int PwdMinLength { get; set; }

	/// <summary>
	/// Specifies if password needs numeric characters.
	/// </summary>
	public bool PwdReqNumeric { get; set; }

	/// <summary>
	/// Specifies if password needs lowercase.
	/// </summary>
	public bool PwdReqLowerCase { get; set; }

	/// <summary>
	/// Specifies if password needs uppercase.
	/// </summary>
	public bool PwdReqUpperCase { get; set; }

	/// <summary>
	/// Specifies if password needs special characters.
	/// </summary>
	public bool PwdReqSpecial { get; set; }

	/// <summary>
	/// When a user is created, the password is automatically expired.
	/// </summary>
	public bool PwdReqOTP { get; set; }
}

