using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.GetItems;

/// <summary>
/// Holds information about a User Group.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829674289693-User-Groups-RESTful-API#get'/></para>
/// </summary>
public class UserGroup : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity server Id on which resource resides
	/// </summary>
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	/// <summary>
	/// User group name
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }
}

