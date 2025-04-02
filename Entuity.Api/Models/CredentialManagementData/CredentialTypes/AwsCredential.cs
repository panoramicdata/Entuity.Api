namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Represents an Amazon Web Services Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class AwsCredential
{
	/// <summary>
	/// The AWS Access Key
	/// </summary>
	public required string AccessKey { get; set; }

	/// <summary>
	/// The AWS Secret Key
	/// </summary>
	public required string SecretKey { get; set; }
}
