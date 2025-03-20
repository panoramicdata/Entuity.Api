namespace Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Post;

/// <summary>
/// Contains ID's of servers to be added to the server group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840499938589-Config-Sets-Servers-RESTful-API#postadd'/></para>
/// </summary>
public class ServerGroupMembershipAdd
{
	/// <summary>
	/// List of Server ID's of servers to be added to the server group
	/// </summary>
	public IEnumerable<Guid> MembersAdded { get; set; } = [];
}
