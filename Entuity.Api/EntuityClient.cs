using Entuity.Api.Interfaces.Controllers;
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

		AutoDiscovery = Refit<IAutoDiscovery>(refitSettings);
		Configuration = Refit<IConfiguration>(refitSettings);
		DataAccessTemplates = Refit<IDataAccessTemplates>(refitSettings);
		FlowData = Refit<IFlowData>(refitSettings);
		Filters = Refit<IFilters>(refitSettings);
		Information = Refit<IInformation>(refitSettings);
		Ipam = Refit<IIpam>(refitSettings);
		Inventory = Refit<IInventory>(refitSettings);
		Events = Refit<IEvents>(refitSettings);
		Incidents = Refit<IIncidents>(refitSettings);
		LicenseInformation = Refit<ILicenseInfo>(refitSettings);
		Maintenance = Refit<IMaintenance>(refitSettings);
		Users = Refit<IUsers>(refitSettings);
		UserGroups = Refit<IUserGroups>(refitSettings);
		UserDefinedRestPollers = Refit<IUserDefinedRestPollers>(refitSettings);
		Settings = Refit<ISettings>(refitSettings);
		Servers = Refit<IServers>(refitSettings);
		Services = Refit<IServices>(refitSettings);
		Tools = Refit<ITools>(refitSettings);
		Views = Refit<IViews>(refitSettings);
		WebHooks = Refit<IWebHooks>(refitSettings);
		Zones = Refit<IZones>(refitSettings);
	}

	private T Refit<T>(RefitSettings refitSettings)
		=> RestService.For<T>(_httpClient, refitSettings);

	public IAutoDiscovery AutoDiscovery { get; set; }

	public IConfiguration Configuration { get; set; }

	public IFlowData FlowData { get; set; }

	public IFilters Filters { get; set; }

	public IIpam Ipam { get; set; }

	public IInformation Information { get; set; }

	public IDataAccessTemplates DataAccessTemplates { get; set; }

	public IInventory Inventory { get; set; }

	public IEvents Events { get; set; }

	public IIncidents Incidents { get; set; }

	public ITools Tools { get; set; }

	public ILicenseInfo LicenseInformation { get; set; }

	public IMaintenance Maintenance { get; set; }

	public IUsers Users { get; set; }

	public IUserGroups UserGroups { get; set; }

	public IUserDefinedRestPollers UserDefinedRestPollers { get; set; }

	public IServers Servers { get; set; }

	public IServices Services { get; set; }

	public ISettings Settings { get; set; }

	public IViews Views { get; set; }

	public IWebHooks WebHooks { get; set; }

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
