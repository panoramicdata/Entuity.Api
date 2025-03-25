namespace Entuity.Api.Models.OsServiceData.Post;
/// <summary>
/// Holds Os Service rules to be created.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838606626333-OS-Services-Summary-RESTful-API#post'/></para>
/// </summary>
public class OsServiceCollectionCreate
{
	/// <summary>
	/// Holds Os Service rules to be created.
	/// </summary>
	public required IEnumerable<OsServiceCreate> ServiceRules { get; set; }
}
