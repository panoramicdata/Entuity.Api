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

		Inventory = RestService.For<IInventory>(_httpClient, refitSettings);
		Events = RestService.For<IEvents>(_httpClient, refitSettings);
		Incidents = RestService.For<IIncidents>(_httpClient, refitSettings);
		Servers = RestService.For<IServers>(_httpClient, refitSettings);

	}

	public IInventory Inventory { get; set; }

	public IEvents Events { get; set; }

	public IIncidents Incidents { get; set; }

	public IServers Servers { get; set; }

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
