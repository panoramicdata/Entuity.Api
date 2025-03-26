using System.Text.Json.Serialization;

namespace Entuity.Api.Models.IncidentsData.Update;

/// <summary>
/// Holds optional information for updating an Incident
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13819723797405-Incident-Details-RESTful-API#put'/></para>
/// </summary>
public class IncidentUpdate
{
	/// <summary>
	/// Change state. Valid states are “open”, “closed” and “expired”
	/// </summary>
	/// <remarks>Note: It is not possible to change the state of an incident if it has already expired</remarks>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? State { get; set; }

	/// <summary>
	/// Change the annotation for an incident
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Annotation { get; set; }

	/// <summary>
	/// Update an attribute for an incident. A key and value must be provided (see examples below)
	/// </summary>
	/// <remarks>Note: The attribute must have already been defined in the active event project</remarks>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IncidentAttributeData? Attribute { get; set; }
}
