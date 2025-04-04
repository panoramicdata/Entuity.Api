namespace Entuity.Api.Models.ConfigurationData.Configuration.Update;

/// <summary>
/// Holds information that can be used to update a user in a configuration set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840524641821-Config-Sets-User-Details-RESTful-API#put'/></para>
/// </summary>
public class ConfigurationSetUserUpdate
{
	/// <summary>
	/// The new password for the users
	/// </summary>
	public required string Password { get; set; }
}
