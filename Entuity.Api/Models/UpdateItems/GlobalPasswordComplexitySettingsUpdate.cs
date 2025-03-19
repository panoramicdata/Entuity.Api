using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UpdateItems;

/// <summary>
/// Holds details that can be updated for Global Password Complexity Settings.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829770850845-Users-Global-Password-Complexity-Settings-RESTful-API#put'/></para>
/// </summary>
public class GlobalPasswordComplexitySettingsUpdate
{
	/// <summary>
	/// Prevent recent previous passwords from being reused (limit 10).
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? PwdHistoryLimit { get; set; }

	/// <summary>
	/// Minimum length of password.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? PwdMinLength { get; set; }

	/// <summary>
	/// Specifies if password needs numeric characters.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PwdReqNumeric { get; set; }

	/// <summary>
	/// Specifies if password needs lowercase.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PwdReqLowerCase { get; set; }

	/// <summary>
	/// Specifies if password needs uppercase.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PwdReqUpperCase { get; set; }

	/// <summary>
	/// Specifies if password needs special characters.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PwdReqSpecial { get; set; }

	/// <summary>
	/// When a user is created, the password is automatically expired.
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? PwdReqOTP { get; set; }
}
