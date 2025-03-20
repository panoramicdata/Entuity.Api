using Entuity.Api.Models.DataAccessTemplatesData.Get;

namespace Entuity.Api.Models.DataAccessTemplatesData.Post;

public class DataAccessTemplateCreationResponse : DataAccessTemplate
{
	public IEnumerable<object> Nodes { get; set; } = [];
}
