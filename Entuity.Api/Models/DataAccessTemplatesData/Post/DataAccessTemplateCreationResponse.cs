using Entuity.Api.Models.DataAccessTemplatesData.Get;

namespace Entuity.Api.Models.DataAccessTemplatesData.Post;

/// <summary>
/// Data model for data returned from a POST request to create a new data access template
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830425214749-Data-Access-Templates-Management-Listing-and-Creating-RESTful-API#post'/></para>
/// </summary>
public class DataAccessTemplateCreationResponse : DataAccessTemplate
{
	/// <summary>
	/// Nodes that are associated with the template
	/// </summary>
	public IEnumerable<object> Nodes { get; set; } = [];
}
