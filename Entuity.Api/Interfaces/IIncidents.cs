using Entuity.Api.Models;
using Refit;

namespace Entuity.Api.Interfaces;

public interface IIncidents
{
	[Get("/api/incidents")]
	Task<IncidentResponse> GetAllAsync(CancellationToken cancellationToken);

	[Get("/api/incidentTypes")]
	Task<IncidentTypeResponse> GetAllTypesAsync(CancellationToken cancellationToken);
}