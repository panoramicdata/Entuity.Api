namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Information on what if any events to raise when this attribute's value changes
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
public class EventInfo
{
	/// <summary>
	/// Either "NONE", "THRESHOLD" or "STATUS"
	/// </summary>
	public string EventMode { get; set; } = string.Empty;

	/// <summary>
	/// Map of values to event severity
	/// </summary>
	public object? Mapping { get; set; }
}