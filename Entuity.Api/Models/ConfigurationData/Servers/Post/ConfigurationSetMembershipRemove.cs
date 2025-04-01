namespace Entuity.Api.Models.ConfigurationData.Servers.Post;

/// <summary>
/// Contains ID's of servers to be removed from a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840499938589-Config-Sets-Servers-RESTful-API#postremove'/></para>
/// </summary>
public class ConfigurationSetMembershipRemove
{
	/// <summary>
	/// List of Server ID's of servers to be removed from the server group
	/// </summary>
	public IEnumerable<Guid> MembersRemoved { get; set; } = [];
}
