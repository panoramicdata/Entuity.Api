namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Holds a Username and Password Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class UserAndPasswordCredential
{
	/// <summary>
	/// The Username
	/// </summary>
	public required string Username { get; set; }

	/// <summary>
	/// The Password
	/// </summary>
	public required string Password { get; set; }
}
