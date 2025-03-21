using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.ServicesData.Get;

/// <summary>
/// Holds detailed information about a service in the Entuity system
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838553899165-Service-Detail-RESTful-API#get'/></para>
/// </summary>
public class ServiceDetailed : IGetItem
{
	/// <summary>
	/// Holds information about the Service
	/// </summary>
	public required ServiceInfo Info { get; set; }

	/// <summary>
	/// Holds list of Component Ids
	/// </summary>
	public required IEnumerable<ServiceComponentId> ComponentIds { get; set; }
}
