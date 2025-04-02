namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Represents a SNMPv2 Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class SnmpV2Credential
{
	/// <summary>
	/// The Community String
	/// </summary>
	public required string Community { get; set; }

	/// <summary>
	/// The Write Community String
	/// </summary>
	public required string WriteCommunity { get; set; }
}
