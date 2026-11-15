using Entuity.Api.Interfaces;
using Entuity.Api.Models.ConfigurationData.ServerGroupsSummaryInfo;
using Entuity.Api.Models.ConfigurationData.Sets.Get;

namespace Entuity.Api.Models.ConfigurationData.SummaryInformation.Get;

/// <summary>
/// Provides summary information for a Config Set
/// <para>See <a href=''/></para>
/// </summary>
public class ConfigurationSetSummaryInformation : ConfigurationSetModifiedBase, IGetItem
{
	/// <summary>
	/// Number of servers in the config set
	/// </summary>
	public int MemberCount { get; set; }

	/// <inheritdoc cref="ServerGroupsSummaryInfo.SyncStatus"/>
	public required SyncStatus SyncStatus { get; set; }

	/// <summary>
	/// Description of the config set's current sync status
	/// </summary>
	public string SyncStatusCategory { get; set; } = string.Empty;
}
