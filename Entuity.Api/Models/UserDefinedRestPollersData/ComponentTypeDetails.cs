using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Specifies details of the component type of object(s) that will be created by the poller. For ASSOCIATED_COMPONENT pollers (the only ones currently supported) the typeName field should be the same as the pollerName, and a typeDisplayName field should also be supplied to specify the display name for the single associated object
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class ComponentTypeDetails
{
	/// <summary>
	/// Unique StormWorks type name for the component type
	/// </summary>
	public string TypeName { get; set; } = string.Empty;

	/// <summary>
	/// Display name that will be given to the associated object of the device. It can have spaces in the name. It does not need to be unique but it is best if it is
	/// </summary>
	public string TypeDisplayName { get; set; } = string.Empty;

	/// <summary>
	/// Description of the association
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Visibility level for this attribute. Can be one of "SHORTLISTED", "VISIBLE", "ADVANCED" or "HIDDEN"
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Visibility { get; set; } = string.Empty;
}