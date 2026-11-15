using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ViewsData.Update;
/// <summary>
/// Model for updating a new View
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829997432477-View-Details-RESTful-API#put'/></para>
/// </summary>
public class ViewUpdate : ViewBase
{
	/// <summary>
	/// Name of the View being created
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public required string? Name { get; set; }
}
