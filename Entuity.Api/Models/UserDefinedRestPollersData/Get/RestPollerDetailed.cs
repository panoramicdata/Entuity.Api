using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UserDefinedRestPollersData.Get;
/// <summary>
/// Holds detailed information about a REST poller specified on the Entuity server
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13838655745565-User-Defined-REST-Poller-Details-RESTful-API#get'/></para>
/// </summary>
public class RestPollerDetailed
{
	/// <summary>
	/// Unique identifier for the REST poller
	/// </summary>
	public int PollerId { get; set; }

	/// <summary>
	/// Type of poller. Currently only "API" is supported, but "SNMP" may be supported in future versions
	/// </summary>
	public string PollerType { get; set; } = string.Empty;

	/// <summary>
	/// Unique poller name, without spaces. Alpha numeric characters and underscores are allowed but other characters are invalid. Should start with udp_ and this will be added if missing
	/// </summary>
	public string PollerName { get; set; } = string.Empty;

	/// <summary>
	/// Unix timestamp for when this poller was first created
	/// </summary>
	public int CreationTime { get; set; }

	/// <summary>
	/// Name of Entuity user that created this poller
	/// </summary>
	public required string CreatedBy { get; set; }

	/// <summary>
	/// Unix timestamp for when this poller was last modified
	/// </summary>
	public int LastModified { get; set; }

	/// <summary>
	/// User that last modified this poller
	/// </summary>
	public required string ModifiedBy { get; set; }

	/// <summary>
	/// Version number
	/// </summary>
	public double Version { get; set; }

	/// <summary>
	/// Revision number. This is incremented each time the user edits this poller
	/// </summary>
	public int Revision { get; set; }

	/// <summary>
	/// Number determining collector priority
	/// </summary>
	public double Priority { get; set; }

	/// <summary>
	/// This field is currently redundant and will always be null
	/// </summary>
	public Guid? ServerId { get; set; }

	/// <summary>
	/// Number of errors while creating this poller. Should be zero or null for a successful poller
	/// </summary>
	public int? ErrorCount { get; set; }

	/// <summary>
	/// Whether the poller is enabled or not
	/// </summary>
	public bool Enabled { get; set; }

	/// <inheritdoc cref="UserDefinedRestPollersData.PollerDefinition"/>/>
	[JsonPropertyName("pollerDef")]
	public required PollerDefinition PollerDefinition { get; set; }
}
