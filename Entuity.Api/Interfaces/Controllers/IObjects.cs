using Entuity.Api.Collections;
using Refit;

namespace Entuity.Api.Interfaces.Controllers;
public interface IObjects
{

	/// <summary>
	/// Get all Associations for a specific Object
	/// </summary>
	/// <remarks>For more information about this endpoint, see this <a href='https://support.entuity.com/hc/en-us/articles/13830049508637-Object-Associations-RESTful-API#get'>documentation</a></remarks>
	/// <param name="swID"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/api/objects/{swID}/associations")]
	public Task<BasicResponse<string>> GetObjectAssociations(int swID, CancellationToken cancellationToken);
}
