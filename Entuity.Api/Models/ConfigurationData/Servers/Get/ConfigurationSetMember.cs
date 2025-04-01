using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.Servers.Get;

/// <summary>
/// Represents a server that is a member to a specific Config Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840499938589-Config-Sets-Servers-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetMember : IGetItem
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
