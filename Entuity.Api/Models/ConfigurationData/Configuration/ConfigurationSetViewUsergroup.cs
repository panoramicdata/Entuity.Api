using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ConfigurationData.Configuration;

/// <summary>
/// Represents a User Group assigned to a Configuration Set.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13840534002461-Config-Sets-List-and-Add-Views-RESTful-API#get'/></para>
/// </summary>
public class ConfigurationSetViewUsergroup
{
	/// <summary>
	/// Name of the User Group assigned to this config Set
	/// </summary>
	public string GroupName { get; set; } = string.Empty;

	/// <summary>
	/// If the User Group is editable
	/// </summary>
	[JsonPropertyName("editable")]
	public bool IsEditable { get; set; }
}
