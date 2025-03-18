using Entuity.Api.Models.GetItems;

namespace Entuity.Api.Models;

public class DataAccessTemplateCreationResponse : DataAccessTemplate
{
	public IEnumerable<object> Nodes { get; set; } = [];
}
