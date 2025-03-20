using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.ServerGroupMembership.Get;

/// <summary>
/// Server group membership
/// </summary>
public class ServerGroupMembership : IGetItem
{
	/// <summary>
	/// Unique server identifier
	/// </summary>
	public Guid ServerId { get; set; }

	/// <summary>
	/// Config set ID
	/// </summary>
	public Guid ServerGroupId { get; set; }
}
