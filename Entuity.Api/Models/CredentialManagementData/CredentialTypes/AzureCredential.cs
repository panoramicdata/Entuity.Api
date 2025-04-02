namespace Entuity.Api.Models.CredentialManagementData.CredentialTypes;

/// <summary>
/// Represents a Azure Credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
public class AzureCredential
{
	/// <summary>
	/// Unique Client Identity
	/// </summary>
	public required string ClientId { get; set; }

	/// <summary>
	/// Azure vault Secret Key
	/// </summary>
	public required string SecretKey { get; set; }

	/// <summary>
	/// Tenant Identity (GUID)
	/// </summary>
	public required Guid TenantId { get; set; }
}
