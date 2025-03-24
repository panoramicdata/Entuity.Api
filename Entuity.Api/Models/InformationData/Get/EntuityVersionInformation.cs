using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.InformationData.Get;

/// <summary>
/// Information about the installed version of Entuity
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829646006685-Product-Info-RESTful-API#get'/></para>
/// </summary>
public class EntuityVersionInformation : Entity<string>, IGetItem
{
	/// <summary>
	/// The Product Version
	/// </summary>
	[JsonPropertyName("version")]
	public required string Version { get; set; }

	/// <summary>
	/// User-Friendly version string of the Product
	/// </summary>
	[JsonPropertyName("versionDisplay")]
	public required string VersionDisplay { get; set; }

	/// <summary>
	/// The Product edition
	/// </summary>
	[JsonPropertyName("product")]
	public required string Product { get; set; }

	/// <summary>
	/// Host name for accessing the product
	/// </summary>
	[JsonPropertyName("hostAddress")]
	public required string HostAddress { get; set; }

	/// <summary>
	/// Port number for accessing the product over HTTP(S)
	/// </summary>
	[JsonPropertyName("webPort")]
	public int WebPort { get; set; }

	/// <summary>
	/// Specifies to whether to use HTTP or HTTPS
	/// <list type="bullet">
	/// <item>True - use HTTPS</item>
	/// <item>False - use HTTP</item>
	/// </list>
	/// </summary>
	[JsonPropertyName("sslAccess")]
	public bool SslAccess { get; set; }
}

