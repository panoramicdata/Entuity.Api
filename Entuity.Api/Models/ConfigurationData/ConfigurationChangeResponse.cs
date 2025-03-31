namespace Entuity.Api.Models.ConfigurationData;

/// <summary>
/// Information returned from changing configuration
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840473167517-Config-Sets-Users-RESTful-API#post'/></para>
/// </summary>
public class ConfigurationChangeResponse
{
	/// <summary>
	/// Code for the change outcome, e.g. 'Success'
	/// </summary>
	public string ErrorCode { get; set; } = string.Empty;

	/// <summary>
	/// Details of an error, if applicable
	/// </summary>
	public string ErrorDetails { get; set; } = string.Empty;

	/// <inheritdoc cref="ConfigurationChangeData"/>
	public ConfigurationChangeData? Data { get; set; }
}
