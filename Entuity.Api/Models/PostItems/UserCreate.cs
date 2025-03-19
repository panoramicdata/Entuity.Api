namespace Entuity.Api.Models.PostItems;

/// <summary>
/// Represents the properties required to create a user.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829697694877-Users-RESTful-API#post'/></para>
/// </summary>
public class UserCreate
{
	/// <summary>
	/// Username
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// User's Password
	/// </summary>
	public required string Password { get; set; }
}
