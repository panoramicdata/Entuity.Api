using Entuity.Api.Interfaces;
using System.Collections;

namespace Entuity.Api.Models.ServicesData.Get;


public class Service : IGetItem
{
	/// <summary>
	/// Object ID of this service. This is also referenced as 'serviceid' in other RESTful API calls.
	/// </summary>
	public int ObjectId { get; set; }

	/// <summary>
	/// Server ID of the server on which this service exists.
	/// </summary>
	public Guid ServerId { get; set; }


	public string ServiceName { get; set; } = string.Empty;

	/// <summary>
	/// User-specified name of service.
	/// </summary>
	public string ShortServiceName { get; set; } = string.Empty;

	/// <summary>
	/// User-specified short name of the service.
	/// </summary>
	public string DescriptiveAlias { get; set; } = string.Empty;

	/// <summary>
	/// User-specified description of service.
	/// </summary>
	public int ServiceStatus { get; set; }

	/// <summary>
	/// gives the current status of the service.
	/// <list type="bullet">
	/// <item>-1 None</item>
	/// <item>0 Down</item>
	/// <item>1 Up</item>
	/// <item>2 Unknown</item>
	/// <item>3 Degraded</item>
	/// </list>
	/// </summary>
	public int? Children { get; set; }

	/// <summary>
	/// Lists any children services associated with this service.
	/// </summary>
	public IEnumerable? SubServices { get; set; }
}

