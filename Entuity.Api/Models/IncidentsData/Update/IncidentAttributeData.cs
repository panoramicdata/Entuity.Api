namespace Entuity.Api.Models.IncidentsData.Update;

/// <summary>
/// Holds data about an attribute for an Incident
/// </summary>
public class IncidentAttributeData
{
	/// <summary>
	/// The key of the attribute
	/// </summary>
	public required string Key { get; set; }
	/// <summary>
	/// The value of the attribute
	/// </summary>
	public required string Value { get; set; }
}