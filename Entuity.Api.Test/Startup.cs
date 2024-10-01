using Entuity.Api.Test.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit.DependencyInjection.Logging;

namespace Entuity.Api.Test;

public class Startup
{
	public static void ConfigureServices(IServiceCollection services)
	{
		// Load config
		var config = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", true)
			.AddEnvironmentVariables()
			.AddUserSecrets<Startup>()
			.Build();

		services
			.AddLogging(lb => lb
				.AddDebug()
				.AddFilter(level => level >= LogLevel.Debug)
				.AddXunitOutput()
			)
			.AddTransient(s =>
				new EntuityClient(new EntuityClientOptions
				{
					Url = GetConfigString(config, "Url"),
					Username = GetConfigString(config, "Username"),
					Password = GetConfigString(config, "Password"),
					UserAgent = "Entuity.Api.Test",
					Logger = s.GetRequiredService<ILogger<EntuityClient>>()
				})
			);

		services
			.AddTransient(s =>
			new TestCredentialsManager
			{
				TestServerId = GetConfigString(config, "TestServerId")
			});

	}

	private static string GetConfigString(IConfigurationRoot config, string key)
		=> config[key] ?? throw new FormatException($"Missing config: {key}");
}
