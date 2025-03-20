namespace Entuity.Api.Models.UserGroupsData.Post;

/// <summary>
/// Holds details required to create a User Group.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13829674289693-User-Groups-RESTful-API#post'/></para>
/// </summary>
public class UserGroupCreate
{
	/// <summary>
	/// User group name
	/// </summary>
	public required string Name { get; set; }
}
