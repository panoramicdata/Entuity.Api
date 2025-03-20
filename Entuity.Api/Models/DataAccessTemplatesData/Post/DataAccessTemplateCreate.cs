using System.Text.Json.Serialization;

namespace Entuity.Api.Models.DataAccessTemplatesData.Post;

/// <summary>
/// Data model for creating a new data access template
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830425214749-Data-Access-Templates-Management-Listing-and-Creating-RESTful-API#post'/></para>
/// </summary>
public class DataAccessTemplateCreate
{
	/// <summary>
	/// Name of the template
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Description of the template
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }
}
