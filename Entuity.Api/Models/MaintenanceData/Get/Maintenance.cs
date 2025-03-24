using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.MaintenanceData.Get;

/// <summary>
/// Represents a Maintenance Schedule
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835539462429-Maintenance-List-RESTful-API#get'/></para>
/// </summary>
public class Maintenance : Entity<int>, IGetItem
{
	/// <summary>
	/// The name of the Maintenance Schedule
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}
