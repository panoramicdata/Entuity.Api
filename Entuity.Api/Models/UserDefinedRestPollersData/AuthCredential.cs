namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// An object that holds authentication credentials for a REST poller step. Only needed if the <see cref="AuthenticationDetails.AuthType">AuthType</see> is "AUTH_FIXED_CREDENTIALS"
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class AuthCredential : Entity<object>
{
	/// <summary>
	/// Name of the credential set to be used
	/// </summary>
	public string Name { get; set; } = string.Empty;
}