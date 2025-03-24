using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Authentication Method for this Poller Step
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class AuthenticationDetails
{
	/// <summary>
	/// Authentication type. One of "AUTH_NONE", "AUTH_FIXED_CREDENTIALS" or "AUTH_DEVICE_CREDENTIALS"
	/// </summary>
	public string AuthType { get; set; } = string.Empty;

	/// <inheritdoc cref="AuthCredential"/>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public AuthCredential? Credential { get; set; }
}