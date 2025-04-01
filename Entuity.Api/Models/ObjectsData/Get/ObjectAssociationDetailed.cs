using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ObjectsData.Get;

/// <summary>
/// Holds detailed information about an Object Association
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830051863709-Object-Association-Details-RESTful-API#get'/></para>
/// </summary>
public class ObjectAssociationDetailed : IGetItem
{
	/// <summary>
	/// The unique StormWorks ID of the associated Object
	/// </summary>
	public int ObjectId { get; set; }

	/// <summary>
	/// Type of the associated Object
	/// </summary>
	public string TypeName { get; set; } = string.Empty;

	/// <summary>
	/// The display name of the associated Object
	/// </summary>
	public string DisplayName { get; set; } = string.Empty;

	/// <summary>
	/// The display type of the associated Object
	/// </summary>
	public string DisplayType { get; set; } = string.Empty;

	/// <summary>
	/// Indicates whether the object has service status
	/// </summary>
	public bool HasServiceStatus { get; set; }
}
