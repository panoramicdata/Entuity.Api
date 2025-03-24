namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Information on the attributes added by this step
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class AttributeMappings
{
	public required NameToMapping NameToMapping { get; set; }
}