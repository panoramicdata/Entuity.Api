namespace Entuity.Api.Models.ConfigurationData.Sets.Get;

/// <summary>
/// Common information about a Configuration Set, including how it was last changed
/// </summary>
public abstract class ConfigurationSetModifiedBase : ConfigurationSetBase
{
	/// <summary>
	/// ID of the current configuration change, referred to in the table under the Sync History tab on the Multi-Server Configuration page. Each time a config set is updated, the set gains a new configuration change ID. This ID is an auto-incrementing number
	/// </summary>
	public int ConfigurationChangeId { get; set; }

	/// <summary>
	/// Timestamp of when the config set was last modified
	/// </summary>
	public int LastModifiedSec { get; set; }

	/// <summary>
	/// User who last modified the config set
	/// </summary>
	public string LastModifiedBy { get; set; } = string.Empty;
}
