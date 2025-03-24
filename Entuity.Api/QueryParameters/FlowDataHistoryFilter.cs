namespace Entuity.Api.QueryParameters;

/// <summary>
/// Filters for returned data for the flow data history endpoint 
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835538293789-Flow-Data-Time-Series-History-RESTful-API#methods'/></para>
/// </summary>
public class FlowDataHistoryFilter
{
	/// <summary>
	/// The time from which data should be returned
	/// </summary>
	public int? StartTime { get; set; }

	/// <summary>
	/// The time between data points
	/// </summary>
	public int? Interval { get; set; }
}
