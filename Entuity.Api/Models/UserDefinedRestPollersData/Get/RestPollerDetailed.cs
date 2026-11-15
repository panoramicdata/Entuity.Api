using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Get;
/// <summary>
/// Holds detailed information about a REST poller specified on the Entuity server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838655745565-User-Defined-REST-Poller-Details-RESTful-API#get'/></para>
/// </summary>
public class RestPollerDetailed : RestPollerBase
{
	/// <inheritdoc cref="UserDefinedRestPollersData.PollerDefinition"/>/>
	[JsonPropertyName("pollerDef")]
	public required PollerDefinition PollerDefinition { get; set; }
}
