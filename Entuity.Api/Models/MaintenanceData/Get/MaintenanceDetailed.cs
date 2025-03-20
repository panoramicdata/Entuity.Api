using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.MaintenanceData.Get;

/// <summary>
/// Detailed information about a maintenance schedule
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835574526109-Maintenance-Details-RESTful-API#get'/></para>
/// </summary>
public class MaintenanceDetailed : Entity<int>, IGetItem
{
	/// <summary>
	/// Specified name of this maintenance schedule. Must not be empty or null, and must be unique for this server. Maximum of 255 characters
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Specified description of this maintenance schedule. Maximum of 255 characters
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Map of serverIds (string) to a List of deviceIds (integer). Contains the devices that will be affected by this schedule. Devices are identified by their deviceId on the server from the serverId. This value will be ignored if it is not used in a POST call to create a new schedule
	/// </summary>
	public Dictionary<string, IEnumerable<int>> Devices { get; set; } = [];

	public int NumDevices { get; set; }

	/// <summary>
	/// If true, then the devices will have their events suppressed during the times that they would be under maintenance
	/// </summary>
	public bool SuppressEvents { get; set; }

	/// <inheritdoc cref="MaintenanceSchedule"/>
	public required MaintenanceSchedule Schedule { get; set; }

	/// <summary>
	/// ServerId of the server that created this schedule
	/// </summary>
	public Guid ServerId { get; set; }

	/// <summary>
	/// If 0, this schedule was created locally. Otherwise, the serverId is the master of this schedule, and the original ID is this value
	/// </summary>
	public int MasterId { get; set; }

	/// <summary>
	/// Map of serverIds to list of deviceIds to add to the existing list of devices. Only applicable to modifying existing schedules, otherwise will be null
	/// </summary>
	public Dictionary<string, IEnumerable<int>>? AddDevices { get; set; }

	/// <summary>
	/// Map of serverIds to list of deviceIds to remove from the existing list of devices. Only applicable to modifying existing schedules, otherwise will be null
	/// </summary>
	public Dictionary<string, IEnumerable<int>>? RemoveDevices { get; set; }
}

