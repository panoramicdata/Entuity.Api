using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IFilters
{
	[Get("/api/domainFilters")]
	Task<Response<string, DomainFilter>> GetAllDomainFiltersAsync(CancellationToken cancellationToken);
}
