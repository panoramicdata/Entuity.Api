namespace Entuity.Api.Models.DataAccessTemplatesData.Update;

/// <summary>
/// Represents the data required to update a DataAccessTemplate
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830443905565-Data-Access-Templates-Management-Operations-on-a-Single-Template-RESTful-API#put'/></para>
/// </summary>
public class DataAccessTemplateUpdate
{
	public required string Name { get; set; }

	public required string Type { get; set; }

	public required string Description { get; set; }

	public IEnumerable<Node> Nodes { get; set; } = [];
}
