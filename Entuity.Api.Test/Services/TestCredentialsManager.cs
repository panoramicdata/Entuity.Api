namespace Entuity.Api.Test.Services;


/// <summary>
/// A Container for holding sensitive information for tests
/// </summary>
public class TestCredentialsManager
{
	/// <summary>
	/// A server Id that can be used to test if functionality works on a specific Id basis
	/// </summary>
	public string TestServerId { get; set; } = string.Empty;

}
