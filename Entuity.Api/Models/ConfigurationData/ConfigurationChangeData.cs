namespace Entuity.Api.Models.ConfigurationData;

/// <summary>
/// Represents the data returned from a configuration change
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840473167517-Config-Sets-Users-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationChangeData
{
	/// <summary>
	/// ID of the current configuration change, referred to in the table under the Sync History tab on the Multi-Server Configuration page. Each time a config set is updated, the set gains a new configuration change ID. This ID is an auto-incrementing number
	/// </summary>
	public int? ConfigurationChangeId { get; set; }

	/// <summary>
	/// ID of the config set that was changed
	/// </summary>
	public Guid? ServerGroupId { get; set; }

	/// <summary>
	/// When this change occurred
	/// </summary>
	public int? TimestampSec { get; set; }

	/// <summary>
	/// User who made this change
	/// </summary>
	public string? ModifiedBy { get; set; }
}