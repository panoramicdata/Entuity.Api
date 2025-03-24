namespace Entuity.Api.Models.UserDefinedRestPollersData;

public class StepInformation
{
	/// <summary>
	/// Path to the data for this attribute within the JSON or XML returned by the API request. This can be simply the name of a property in the JSON or a more complex expression
	/// </summary>
	public string SourcePath { get; set; } = string.Empty;

	/// <summary>
	/// Attribute name that will be used in the StormWorks data model. Must begin with udp_ and only contain alpha numeric characters and underscores
	/// </summary>
	public string SwAttrName { get; set; } = string.Empty;

	/// <summary>
	/// Display name used for this attribute in the UI (dashboards, reports etc.)
	/// </summary>
	public string SwAttrDisplayName { get; set; } = string.Empty;

	/// <summary>
	/// Data type to store the attribute value as. Valid values include "string", "float", "integer". If omitted will default to "string"
	/// </summary>
	public string DataType { get; set; } = string.Empty;

	public string DisplayType { get; set; } = string.Empty;

	public string Visibility { get; set; } = string.Empty;

	public bool Enumerable { get; set; }

	public bool Searchable { get; set; }

	public object StatusMap { get; set; }

	public EventInfo EventInformation { get; set; }
}