using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UsersData.Get;

/// <summary>
/// Holds basic information about a user, returned from a get all request
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829697694877-Users-RESTful-API#get'/></para>
/// </summary>
public class UserSimple : Entity<string>, IGetItem
{
	/// <summary>
	/// Entuity server Id on which resource resides
	/// </summary>
	[JsonPropertyName("serverId")]
	public required string ServerId { get; set; }

	/// <summary>
	/// User name
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }
}

