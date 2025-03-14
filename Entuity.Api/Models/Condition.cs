namespace Entuity.Api.Models;

public class Condition
{
	public int EventConditionID { get; set; }

	public string FieldToTest { get; set; } = string.Empty;

	public string ValueToMatch { get; set; } = string.Empty;

	public string Operator { get; set; } = string.Empty;

	public string TransformType { get; set; } = string.Empty;

	public bool Result { get; set; }
}

