namespace Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Post;

/// <summary>
/// Contains ID's of servers to be removed from the server group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840499938589-Config-Sets-Servers-RESTful-API#postremove'/></para>
/// </summary>
public class ServerGroupMembershipRemove
{
	/// <summary>
	/// List of Server ID's of servers to be removed from the server group
	/// </summary>
	public IEnumerable<Guid> MembersRemoved { get; set; } = [];
}
