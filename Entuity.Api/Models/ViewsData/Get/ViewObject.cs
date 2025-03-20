using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ViewsData.Get;

/// <summary>
/// Holds information about a view object
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830014874909-View-Objects-RESTful-API#get'/></para>
/// </summary>
public class ViewObject : Entity<int>, IGetItem
{
	/// <summary>
	/// Entuity Server Id on which the resource resides
	/// </summary>
	public Guid ServerId { get; set; }

	/// <summary>
	/// Name of the Object type
	/// </summary>
	public string TypeName { get; set; } = string.Empty;

	/// <summary>
	/// User-Friendly name of the Object type
	/// </summary>
	public string TypeDisplayName { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Object
	/// </summary>
	public string DisplayName { get; set; } = string.Empty;
}

