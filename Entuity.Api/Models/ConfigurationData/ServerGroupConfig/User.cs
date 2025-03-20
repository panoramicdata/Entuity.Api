namespace Entuity.Api.Models.ConfigurationData.ServerGroupConfig;
public class User
{
	public string UserName { get; set; } = string.Empty;

	public string Password { get; set; } = string.Empty;

	public object? Settings { get; set; }

	public int PasswordChangeId { get; set; }
}
