using System.Text.Json.Serialization;

namespace Entuity.Api.Models.UpdateItems;

public class UserUpdate
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? LockAttempts { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? LockDurationFailedAttempts { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? ExpiryDays { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? TimeoutMinutes { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? PwChangeDays { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? ForcePWChange { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<string>? Groups { get; set; }
}

