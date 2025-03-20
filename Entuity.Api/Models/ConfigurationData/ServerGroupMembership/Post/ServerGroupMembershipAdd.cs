namespace Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Post;

/// <summary>
/// Contains ID's of servers to be added to the server group
/// </summary>
public class ServerGroupMembershipAdd
{
	public IEnumerable<Guid> MembersAdded { get; set; } = [];
}
