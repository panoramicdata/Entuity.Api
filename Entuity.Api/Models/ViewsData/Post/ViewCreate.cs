using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ViewsData.Post;

/// <summary>
/// Model for creating a new View
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829756254109-View-List-RESTful-API#post'/></para>
/// </summary>
public class ViewCreate : ViewBase
{
	/// <summary>
	/// Name of the View being created
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Forward-slash separated path of the parent view. Leave out to create a top-level view
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? ParentViewPath { get; set; }
}
