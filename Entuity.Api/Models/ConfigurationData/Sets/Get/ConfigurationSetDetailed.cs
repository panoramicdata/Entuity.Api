namespace Entuity.Api.Models.ConfigurationData.Sets.Get;

/// <summary>
/// Holds detailed information about a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetDetailed : ConfigurationSetModifiedBase
{
	/// <inheritdoc cref="Get.Configuration"/>
	public required ConfigurationInformation Configuration { get; set; }
}
