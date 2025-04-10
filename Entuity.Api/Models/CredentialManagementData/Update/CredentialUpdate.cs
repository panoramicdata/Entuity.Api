using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.CredentialManagementData.Update;

/// <summary>
/// Holds the information used to update a credential
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838476426525-Credential-Management-RESTful-API#put'/></para>
/// </summary>
/// <typeparam name="TCredentialAttributes"></typeparam>
public class CredentialUpdate<TCredentialAttributes>
	where TCredentialAttributes : ICredentialAttributeSet
{
	/// <summary>
	/// The name of the Credential
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }

	/// <summary>
	/// A Description of the Credential
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }

	/// <summary>
	/// The attributes of the Credential
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TCredentialAttributes? Attributes { get; set; }
}