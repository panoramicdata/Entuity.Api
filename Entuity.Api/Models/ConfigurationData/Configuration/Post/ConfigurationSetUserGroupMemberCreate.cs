using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Post;

/// <summary>
/// Holds information for adding a new user to a User Group on a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840517468957-Config-Sets-User-Group-Membership-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetUserGroupMemberCreate
{
	/// <summary>
	/// The username of the user group
	/// </summary>
	[JsonPropertyName("userName")]
	public required string Username { get; set; }

	/// <summary>
	/// The password for the user
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Password { get; set; }
}
