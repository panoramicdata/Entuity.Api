using Entuity.Api.Interfaces;
using Refit;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entuity.Api;

public class EntuityClient : IDisposable
{
	private readonly HttpClient _httpClient;
	private bool disposedValue;

	public EntuityClient(EntuityClientOptions options)
	{
		_httpClient = new HttpClient(new AuthenticatedHttpClientHandler(options))
		{
			BaseAddress = new Uri(options.Url)
		};

		var refitSettings = new RefitSettings
		{
			ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
				Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
				UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
			})
		};

		DataAccessTemplates = Refit<IDataAccessTemplates>(refitSettings);
		FlowData = Refit<IFlowData>(refitSettings);
		Information = Refit<IInformation>(refitSettings);
		Inventory = Refit<IInventory>(refitSettings);
		Events = Refit<IEvents>(refitSettings);
		EventFilters = Refit<IEventFilters>(refitSettings);
		Incidents = Refit<IIncidents>(refitSettings);
		Maintenance = Refit<IMaintenance>(refitSettings);
		Users = Refit<IUsers>(refitSettings);
		UserGroups = Refit<IUserGroups>(refitSettings);
		Servers = Refit<IServers>(refitSettings);
		Views = Refit<IViews>(refitSettings);
		Zones = Refit<IZones>(refitSettings);
	}

	private T Refit<T>(RefitSettings refitSettings)
		=> RestService.For<T>(_httpClient, refitSettings);


	public IFlowData FlowData { get; set; }

	public IInformation Information { get; set; }

	public IDataAccessTemplates DataAccessTemplates { get; set; }

	public IInventory Inventory { get; set; }

	public IEvents Events { get; set; }

	public IEventFilters EventFilters { get; set; }

	public IIncidents Incidents { get; set; }
	public IMaintenance Maintenance { get; set; }
	public IUsers Users { get; set; }
	public IUserGroups UserGroups { get; set; }
	public IServers Servers { get; set; }
	public IViews Views { get; set; }
	public IZones Zones { get; set; }

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
				_httpClient?.Dispose();
			}

			disposedValue = true;
		}
	}

	public void Dispose()
	{
		// Do not change this code. Put clean up code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
