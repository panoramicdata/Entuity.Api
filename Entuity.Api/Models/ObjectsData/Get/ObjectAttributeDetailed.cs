namespace Entuity.Api.Models.ObjectsData.Get;

/// <summary>
/// Outlines detailed information about an Object's attribute
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830003492509-Object-Attributes-Details-RESTful-API#get'/></para>
/// </summary>
public class ObjectAttributeDetailed
{
	/// <summary>
	/// Value of the "name" attribute of the device
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Value of the "displayName" attribute of the device
	/// </summary>
	public string DisplayName { get; set; } = string.Empty;

	/// <summary>
	/// Whether this attribute can be modified by a user
	/// </summary>
	public bool UserEditable { get; set; }

	/// <summary>
	/// Whether this attribute is set to polled or user-defined value
	/// </summary>
	public bool UserOverriden { get; set; }

	/// <summary>
	/// List of values for this attribute
	/// </summary>
	public IEnumerable<string> Values { get; set; } = [];
}
