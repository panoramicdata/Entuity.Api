namespace Entuity.Api.Models.OsServiceData.Get;

/// <summary>
/// Holds information about all OS service rules
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838606626333-OS-Services-Summary-RESTful-API#get'/></para>
/// </summary>
public class OsServiceResponse
{
	/// <summary>
	/// The OS Service rules that are currently in place
	/// </summary>
	public IEnumerable<OsService> ServiceRules { get; set; } = [];
}
