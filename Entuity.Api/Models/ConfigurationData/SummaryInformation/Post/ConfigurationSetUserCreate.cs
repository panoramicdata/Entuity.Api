using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.SummaryInformation.Post;

public class ConfigurationSetUserCreate
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
