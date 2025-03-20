namespace Entuity.Api.Models.GetItems;
public class Configuration
{
	public object? GlobalUserSettings { get; set; }

	public object? PasswordComplexitySettings { get; set; }

	public IEnumerable<User> Users { get; set; } = [];

	public IEnumerable<UserGroup> UserGroups { get; set; } = [];

	public IEnumerable<UserGroupView> Views { get; set; } = [];

	public IEnumerable<object> ContentFilters { get; set; } = [];

	public IEnumerable<object> EventFilters { get; set; } = [];

	public IEnumerable<object> IncidentFilters { get; set; } = [];
}
