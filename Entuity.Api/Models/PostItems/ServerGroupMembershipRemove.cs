namespace Entuity.Api.Models.PostItems;

/// <summary>
/// Contains ID's of servers to be removed from the server group
/// </summary>
public class ServerGroupMembershipRemove
{
	public IEnumerable<Guid> MembersRemoved { get; set; } = [];
}
