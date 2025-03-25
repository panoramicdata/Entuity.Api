using System.Text.Json.Serialization;

namespace Entuity.Api.Models.DataAccessTemplatesData.Get;

/// <summary>
/// Holds detailed information about a Data Access Template
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830443905565-Data-Access-Templates-Management-Operations-on-a-Single-Template-RESTful-API#get'/></para>
/// </summary>
public class DataAccessTemplateDetailed
{
	public required string Name { get; set; }

	[JsonPropertyName("$type")]
	public required string Type { get; set; }

	public required string Description { get; set; }

	public IEnumerable<Node> Nodes { get; set; } = [];
}
