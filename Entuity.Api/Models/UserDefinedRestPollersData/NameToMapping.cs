namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Map from attribute name to attribute definition. The key for each entry should be unique and match the value of the swAttrName in the value part. Attribute names must start with udp_ and this will be added automatically if omitted
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838655745565-User-Defined-REST-Poller-Details-RESTful-API#get'/></para>
/// </summary>
public class NameToMapping : Dictionary<string, StepInformation>;