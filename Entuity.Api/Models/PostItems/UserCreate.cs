namespace Entuity.Api.Models.PostItems;

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
