using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ZonesData.Update;

/// <summary>
/// Holds information to update a Zone
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830223150621-Zone-Details-RESTful-API#put'/></para>
/// </summary>
public class ZoneUpdate : ZoneBase
{
	/// <summary>
	/// Zone Name
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Name { get; set; }

	/// <summary>
	/// Zone Flags
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? Flags { get; set; }

	/// <summary>
	/// Description of the Zone
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Description { get; set; }
}
