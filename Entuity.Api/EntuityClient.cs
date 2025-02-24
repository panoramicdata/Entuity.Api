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

		DataAccessTemplates = RestService.For<IDataAccessTemplates>(_httpClient, refitSettings);
		Information = RestService.For<IInformation>(_httpClient, refitSettings);
		Inventory = RestService.For<IInventory>(_httpClient, refitSettings);
		Events = RestService.For<IEvents>(_httpClient, refitSettings);
		EventFilters = RestService.For<IEventFilters>(_httpClient, refitSettings);
		Incidents = RestService.For<IIncidents>(_httpClient, refitSettings);
		Maintenance = RestService.For<IMaintenance>(_httpClient, refitSettings);
		Users = RestService.For<IUsers>(_httpClient, refitSettings);
		UserGroups = RestService.For<IUserGroups>(_httpClient, refitSettings);
		Servers = RestService.For<IServers>(_httpClient, refitSettings);
		Views = RestService.For<IViews>(_httpClient, refitSettings);
		Zones = RestService.For<IZones>(_httpClient, refitSettings);
	}
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
