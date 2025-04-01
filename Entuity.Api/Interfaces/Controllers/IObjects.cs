using Entuity.Api.Collections;
using Entuity.Api.Models.ObjectsData.Get;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IObjects
{
	/// <summary>
	/// Get all Associations for a specific Object
	/// </summary>
	/// <remarks>For more information about this endpoint, see this <a href='https://support.entuity.com/hc/en-us/articles/13830049508637-Object-Associations-RESTful-API#get'>documentation</a></remarks>
	/// <param name="swID">StormWorks ID</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/objects/{swID}/associations")]
	public Task<BasicResponse<string>> GetObjectAssociationsAsync(int swID, CancellationToken cancellationToken);

	/// <summary>
	/// Get detailed information about an Object Association
	/// </summary>
	/// <param name="swID">StormWorks ID</param>
	/// <param name="associationName">Name of the Association</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/objects/{swID}/associations/{associationName}")]
	public Task<Response<ObjectAssociationDetailed>> GetObjectAssociationDetailsAsync(int swID, string associationName, CancellationToken cancellationToken);

	/// <summary>
	/// Get all Attributes for a specific Object
	/// </summary>
	/// <remarks>For more information about this endpoint, see this <a href='https://support.entuity.com/hc/en-us/articles/13830000316189-Object-Attributes-RESTful-API#get'>documentation</a></remarks>
	/// <param name="swID">StormWorks ID</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/objects/{swID}/attributes")]
	public Task<BasicResponse<string>> GetObjectAttributesAsync(int swID, CancellationToken cancellationToken);
}
