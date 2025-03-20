using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;

/// <summary>
/// 
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
