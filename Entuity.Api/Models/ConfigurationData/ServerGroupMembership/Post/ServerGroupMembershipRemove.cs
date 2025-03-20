namespace Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Post;

/// <summary>
/// Contains ID's of servers to be removed from the server group
/// </summary>
public class ServerGroupMembershipRemove
{
	public IEnumerable<Guid> MembersRemoved { get; set; } = [];
}
