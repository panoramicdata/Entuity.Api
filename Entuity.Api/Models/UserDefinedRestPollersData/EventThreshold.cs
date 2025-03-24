using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Event threshold for a user defined REST poller
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class EventThreshold
{
	/// <summary>
	/// Threshold name. Must be unique
	/// </summary>
	public required string Name { get; set; }

	/// <summary>
	/// Description of this threshold
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }

	/// <summary>
	/// Group name for this threshold
	/// </summary>
	public required string GroupName { get; set; }

	/// <summary>
	/// Units for the threshold value. Can be blank if no units apply.
	/// </summary>
	public string DisplayUnits { get; set; } = string.Empty;

	/// <summary>
	/// Minimum value for this threshold
	/// </summary>
	public int MinimumValue { get; set; }

	/// <summary>
	/// Maximum value for this threshold
	/// </summary>
	public int MaxiumumValue { get; set; }

	/// <summary>
	/// Default value for this threshold
	/// </summary>
	public required object DefaultValue { get; set; }

	/// <summary>
	/// Flag for whether this threshold is enabled
	/// </summary>
	[JsonPropertyName("enabled")]
	public bool IsEnabled { get; set; }

	/// <summary>
	/// Flag for whether this threshold is user defined
	/// </summary>
	[JsonPropertyName("userDefined")]
	public bool IsUserDefined { get; set; }

}