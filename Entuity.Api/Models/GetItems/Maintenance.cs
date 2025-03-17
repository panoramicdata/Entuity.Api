using Entuity.Api.Interfaces;
using System.Text.Json.Serialization;

namespace Entuity.Api.Models.GetItems;
public class Maintenance : Entity<int>, IGetItem
{
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
}
