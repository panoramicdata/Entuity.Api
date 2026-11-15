using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ConfigurationData.Configuration.Get;

/// <summary>
/// Holds information about an Incident Filter that are applied to a Configuration Set
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840530161309-Config-Sets-Content-Filters-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetIncidentFilter : ConfigurationSetFilterBase, IGetItem
{
}
