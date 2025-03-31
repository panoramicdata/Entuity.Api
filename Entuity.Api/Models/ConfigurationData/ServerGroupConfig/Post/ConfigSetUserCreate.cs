using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.ServerGroupConfig.Post;
public class ConfigSetUserCreate
{
	// <summary>
	/// Username of a user in the config set
	/// </summary>
	public required string UserName { get; set; }

	/// <summary>
	/// The user's password
	/// </summary>
	public required string Password { get; set; }

	/// <inheritdoc cref="ConfigSetUserSettings"/>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public ConfigSetUserSettings? Settings { get; set; }
}
