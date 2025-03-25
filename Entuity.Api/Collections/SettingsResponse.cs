using Entuity.Api.Interfaces;

namespace Entuity.Api.Collections;

/// <summary>
/// Response model for AutoDiscovery data
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829479167517-Auto-Discovery-Status-RESTful-API#get'/></para>
/// </summary>
public class SettingsResponse<T> where T : IGetItem
{
	/// <summary>
	/// AutoDiscovery settings
	/// </summary>
	public IEnumerable<T> Settings { get; set; } = [];
}
