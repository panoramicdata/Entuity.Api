namespace Entuity.Api.Models.FlowData.Get;

/// <summary>
/// Represents a single sample of flow data.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835538293789-Flow-Data-Time-Series-History-RESTful-API#get'/></para>
/// </summary>
public class FlowSample
{
	/// <summary>
	/// When the sample was taken.
	/// </summary>
	public int Timestamp { get; set; }

	/// <summary>
	/// The rate
	/// </summary>
	public double Rate { get; set; }

	/// <summary>
	/// The volume
	/// </summary>
	public int Volume { get; set; }
}
