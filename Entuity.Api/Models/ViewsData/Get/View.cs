using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.ViewsData.Get;

/// <summary>
/// Holds information about a view
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829756254109-View-List-RESTful-API#get'/></para>
/// </summary>
public class View : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity server ID on which the resource resides
	/// </summary>
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	/// <summary>
	/// The name of the View
	/// </summary>
	[JsonPropertyName("displayName")]
	public required string DisplayName { get; set; }

	/// <summary>
	/// View path with forward slash as a sub-view seperator
	/// </summary>
	[JsonPropertyName("path")]
	public required string Path { get; set; }
}

