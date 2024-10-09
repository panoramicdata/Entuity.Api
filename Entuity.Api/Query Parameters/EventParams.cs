using Entuity.Api.Enums;
using Refit;

namespace Entuity.Api.Query_Parameters;
public class EventParams
{
	//public int UpdateId { get; set; }

	/// <summary>
	/// Filter for events from this Epoch Time
	/// </summary>
	[AliasAs("openedFrom")]
	public int? OpenedFrom { get; set; }

	/// <summary>
	/// Filter events until this Epoch Time
	/// </summary>
	[AliasAs("openedTo")]
	public int? OpenedTo { get; set; }

	/// <summary>
	/// Filter events that were closed from this Epoch Time forward
	/// </summary>
	[AliasAs("closedFrom")]
	public int? ClosedFrom { get; set; }

	/// <summary>
	/// Filter events that were closed before this Epoch Time
	/// </summary>
	[AliasAs("closedTo")]
	public int? ClosedTo { get; set; }

	//public int? View { get; set; }

	/// <summary>
	/// Filter events with a severity rating
	/// </summary>
	[AliasAs("mask")]
	public SeverityRating? SeverityRating { get; set; }

	/// <summary>
	/// Filter events by their state
	/// </summary>
	[AliasAs("states")]
	public State? State { get; set; }
}
