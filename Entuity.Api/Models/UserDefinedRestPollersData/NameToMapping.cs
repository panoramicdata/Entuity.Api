namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Map from attribute name to attribute definition. The key for each entry should be unique and match the value of the swAttrName in the value part. Attribute names must start with udp_ and this will be added automatically if omitted
/// </summary>
public class NameToMapping : Dictionary<string, StepInformation>;