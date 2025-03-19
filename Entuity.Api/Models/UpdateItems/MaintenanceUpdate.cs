using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UpdateItems;

/// <summary>
/// Holds optional fields for updating a maintenance schedule
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835574526109-Maintenance-Details-RESTful-API#put'/></para>
/// </summary>
public class MaintenanceUpdate
{
	/// <summary>
	/// Specified name of this maintenance schedule. Must not be empty or null, and must be unique for this server. Maximum of 255 characters
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }

	/// <summary>
	/// If true, then the devices will have their events suppressed during the times that they would be under maintenance
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SuppressEvents { get; set; }

	/// <summary>
	/// Map of serverIds to list of deviceIds to add to the existing list of devices. Only applicable to modifying existing schedules, otherwise will be null
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Dictionary<string, IEnumerable<int>>? AddDevices { get; set; }
}
