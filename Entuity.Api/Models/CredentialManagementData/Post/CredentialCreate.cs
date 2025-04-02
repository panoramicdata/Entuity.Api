using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.Post;

/// <summary>
/// Holds the information needed to create a new new credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#post'/></para>
/// </summary>
/// <typeparam name="TCredentialAttributes"></typeparam>
public class CredentialCreate<TCredentialAttributes>
	where TCredentialAttributes : ICredentialAttributeSet
{
	/// <summary>
	/// The name of the Credential
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// A Description of the Credential
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }

	/// <summary>
	/// The attributes of the new Credential
	/// </summary>
	public required TCredentialAttributes Attributes { get; set; }
}
