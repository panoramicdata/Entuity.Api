namespace Entuity.Api.Models.ConfigurationData.Sets.Post;

/// <summary>
/// Holds details about the Configuration Set.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationSetDetailedCreateResponse
{
	/// <summary>
	/// ID of the current Configuration Change, Referred to in the table under the Sync History tav on the Multi-Server Configuration Page. Each time a change is made, the set gains a new Configuration Change ID.
	/// </summary>
	/// <remarks>This ID is an auto-incrementing Number</remarks>
	public int ConfigurationChangeId { get; set; }

	/// <summary>
	/// Unique identifier for the configuration set
	/// </summary>
	public Guid ServerGroupId { get; set; }

	/// <summary>
	/// Timestamp of the last change to the configuration set
	/// </summary>
	public int TimestampSec { get; set; }

	/// <summary>
	/// Who made the last change to the configuration set
	/// </summary>
	public required string ModifiedBy { get; set; }

	/// <inheritdoc cref="ConfigurationInformation"/>
	public required ConfigurationInformation ServerConfiguration { get; set; }
}
