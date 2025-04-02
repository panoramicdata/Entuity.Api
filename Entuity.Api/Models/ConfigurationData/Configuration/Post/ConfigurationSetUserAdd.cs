using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Post;

/// <summary>
/// Holds information to add a User to a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840473167517-Config-Sets-Users-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetUserAdd
{
	// <summary>
	/// Username of a user in the config set
	/// </summary>
	public required string UserName { get; set; }

	/// <summary>
	/// The user's password
	/// </summary>
	public required string Password { get; set; }

	/// <inheritdoc cref="ConfigurationSetUserSettings"/>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public ConfigurationSetUserSettings? Settings { get; set; }
}
