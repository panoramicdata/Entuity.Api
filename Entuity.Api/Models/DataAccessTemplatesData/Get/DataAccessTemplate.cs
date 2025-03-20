using Entuity.Api.Enums;
using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.DataAccessTemplatesData.Get;

/// <summary>
/// Data Access Templates are used to access internal DsKernal data
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830425214749-Data-Access-Templates-Management-Listing-and-Creating-RESTful-API#get'/></para>
/// </summary>
public class DataAccessTemplate : IGetItem
{
	/// <summary>
	/// Name of the template
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Type of the template (either “USER” or “SYSTEM”)
	/// </summary>
	[JsonPropertyName("$type")]
	public required TemplateType Type { get; set; }

	/// <summary>
	/// Description of the template
	/// </summary>
	public string Description { get; set; } = string.Empty;
}
