namespace Entuity.Api.Models.ConfigurationData.Configuration.Update;

/// <summary>
/// Holds the data for a user group membership update
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840517468957-Config-Sets-User-Group-Membership-RESTful-API#put'/></para>
/// </summary>
public class ConfigurationSetUserGroupMembershipUpdate
{
	/// <summary>
	/// List of members to be overwritten
	/// </summary>
	public required IEnumerable<string> Members { get; set; }
}
