using System.ComponentModel.DataAnnotations;

namespace Entuity.Api.Models;

public class AutoDiscovery : Entity<int>
{
	/// <summary>
	/// User-specified name of discovery profile.
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// user-specified description of discovery profile.
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Status of the discovery profile.
	/// <list type="bullet">
	/// <item>0 - Never Ran</item>
	/// <item>1 - In Progress</item>
	/// <item>2 - Complete</item>
	/// <item>3 - Stopped (aborted or crashed)</item>
	/// </list>
	/// </summary>
	public int Status { get; set; }

	/// <summary>
	/// Percentage of Completion, 0 -100
	/// </summary>
	[Range(0, 100)]
	public int Percentage { get; set; }
}
