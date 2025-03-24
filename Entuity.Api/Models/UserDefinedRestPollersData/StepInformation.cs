using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData;

/// <summary>
/// Information on the attributes added by this step
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838639545373-User-Defined-REST-Pollers-RESTful-API#post'/></para>
/// </summary>
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

	/// <summary>
	/// How the value will be displayed in the UI. A displayType can allow the data to be shown including e.g. appropriate units and formatting
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? DisplayType { get; set; }

	/// <summary>
	/// Visibility level for this attribute. Can be one of "SHORTLISTED", "VISIBLE", "ADVANCED" or "HIDDEN"
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Visibility { get; set; }

	/// <summary>
	/// If true this attribute will be considered to have a limited enumeration of values. This makes it eligible for example for being used as the data to drive the groupings of a generic pie chart
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? Enumerable { get; set; }

	/// <summary>
	/// If true this attribute will be considered a valid choice for display on a chart, if false it will not. If omitted then a default will be determined based upon the data type (numeric values are graphable, strings are not)
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? Searchable { get; set; }

	/// <summary>
	/// If true this attribute will be searchable using the search tool
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public object? StatusMap { get; set; }

	/// <inheritdoc cref='EventInfo'/>
	[JsonPropertyName("eventInfo")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public EventInfo? EventInformation { get; set; }

	/// <summary>
	/// List of thresholds for events on this attribute
	/// </summary>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<EventThreshold>? EventThresholds { get; set; }
}