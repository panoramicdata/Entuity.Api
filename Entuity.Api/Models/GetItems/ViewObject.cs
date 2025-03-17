using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.GetItems;


public class ViewObject : Entity<int>, IReturnItem
{
	public Guid ServerId { get; set; }

	public string TypeName { get; set; } = string.Empty;

	public string TypeDisplayName { get; set; } = string.Empty;

	public string DisplayName { get; set; } = string.Empty;
}

