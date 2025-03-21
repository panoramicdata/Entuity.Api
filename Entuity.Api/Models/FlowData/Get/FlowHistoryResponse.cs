namespace Entuity.Api.Models.FlowData.Get;

/// <summary>
/// Represents the response to a request for flow data history.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835538293789-Flow-Data-Time-Series-History-RESTful-API#get'/></para>
/// </summary>
public class FlowHistoryResponse
{
	/// <summary>
	/// The flow data for the requested time period.
	/// </summary>
	public required IEnumerable<SampleSet> SampleSets { get; set; } = [];
}
