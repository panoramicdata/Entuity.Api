using System.Text.Json.Serialization;

namespace Entuity.Api.Models.PostItems;

/// <summary>
/// A Model that contains required properties used to create a Maintenance Schedule.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835539462429-Maintenance-List-RESTful-API#post'/></para>
/// </summary>
public class MaintenanceCreate
{
	/// <summary>
	/// Specified name of this maintenance schedule. Must not be empty and must be unique for this server. Maximum of 255 characters.
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Specified description of this maintenance schedule. Maximum of 255 characters
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }
	/// <summary>
	/// Map of serverIds (string) to a List of deviceIds (integer). Contains the devices that will be affected by this schedule. Devices are identified by their deviceId on the server from the serverId. This value will be ignored if it is not used in a POST call to create a new schedule
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Dictionary<string, IEnumerable<int>>? Devices { get; set; }

	/// <summary>
	/// If true, then the devices will have their events suppressed during the times that they would be under maintenance
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? SuppressEvents { get; set; }

	/// <inheritdoc cref="MaintenanceSchedule"/>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public MaintenanceSchedule? Schedule { get; set; }
}
