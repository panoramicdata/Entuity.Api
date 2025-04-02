using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.CredentialManagementData.Get;

/// <summary>
/// Holds information about a Credential in the Entuity system
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#get'/></para>
/// </summary>
public class Credential : Entity<int>, IGetItem
{
	/// <summary>
	/// Unique Identifier of the Device
	/// </summary>
	public int DeviceId { get; set; }

	/// <summary>
	/// The Kind of Credential
	/// </summary>
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// THe name of the Credential
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// A description of the Credential
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// A Collection of attributes for this Credential
	/// </summary>
	public required Dictionary<string, object> Attributes { get; set; }
}
