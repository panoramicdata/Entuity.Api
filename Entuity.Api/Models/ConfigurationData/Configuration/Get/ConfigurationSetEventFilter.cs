using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Holds information about an Event Filter that are applied to a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840565049245-Config-Sets-Event-Filters-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetEventFilter : ConfigurationSetFilterBase, IGetItem
{
}
