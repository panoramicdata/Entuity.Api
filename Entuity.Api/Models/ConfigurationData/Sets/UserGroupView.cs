using Entuity.Api.Models.ConfigurationData.Configuration;
using System.Collections;

namespace Entuity.Api.Models.ConfigurationData.Sets;

/// <summary>
/// Holds information about a User Group
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840304434077-Config-Sets-Config-Set-Details-RESTful-API#get'/></para>
/// </summary>
public class UserGroupView : ConfigurationViewBase
{
	/// <summary>
	/// Names of the View that form the base of this current View
	/// </summary>
	public IEnumerable? BaseViewNames { get; set; }

	/// <summary>
	/// Name of the incident filter applied to this View
	/// </summary>
	public string SituationFilter { get; set; } = string.Empty;

	/// <summary>
	/// Name of the View's location, as specified for Geographical Map mode
	/// </summary>
	public object? LocationName { get; set; }
}
