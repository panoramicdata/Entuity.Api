using System.Text.Json.Serialization;

namespace Entuity.Api.Models.DataAccessTemplatesData;

/// <summary>
/// Holds top level data about a Node
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830443905565-Data-Access-Templates-Management-Operations-on-a-Single-Template-RESTful-API#get'/></para>
/// </summary>
public class NodeData
{
	public string? Name { get; set; }

	public string Tag { get; set; } = string.Empty;

	public bool? AsElement { get; set; }

	public object? AsAttribute { get; set; }

	public object? AsText { get; set; }

	public object? AllowMultibyte { get; set; }

	public object? AllAttributes { get; set; }

	public object? ObjectIdRequired { get; set; }

	public object? DisplayNameRequired { get; set; }

	public object? DeviceTypeRequired { get; set; }

	public object? HostNameRequired { get; set; }

	[JsonPropertyName("polledIpAddrRequired")]
	public object? PolledIpAddressRequired { get; set; }

	public IEnumerable<Node> Nodes { get; set; } = [];

	#region Attribute Node Properties
	public string Expression { get; set; } = string.Empty;

	public string? Unit { get; set; }
	#endregion

	#region Object Node Properties
	[JsonPropertyName("$type")]
	public string? Type { get; set; }

	public string? Selector { get; set; }

	public string? Filter { get; set; }
	#endregion
}
