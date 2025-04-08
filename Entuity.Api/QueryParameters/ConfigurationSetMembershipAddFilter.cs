namespace Entuity.Api.QueryParameters;

public class ConfigurationSetMembershipAddFilter
{
	/// <summary>
	/// Used to force control of a server (that already belongs to a different config set) when adding it to a new config set.
	/// </summary>
	public required bool ForceControl { get; set; }
}
