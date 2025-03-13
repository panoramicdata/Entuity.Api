using Entuity.Api.Interfaces;

namespace Entuity.Api.Models;

public class RestPoller : IReturnItem
{
	public int PollerId { get; set; }

	public string PollerType { get; set; } = string.Empty;

	public string PollerName { get; set; } = string.Empty;

	public int CreationTime { get; set; }

	public required string CreatedBy { get; set; }

	public int LastModified { get; set; }

	public required string ModifiedBy { get; set; }

	public double Version { get; set; }

	public int Revision { get; set; }

	public double Priority { get; set; }

	public Guid? ServerId { get; set; }

	public int? ErrorCount { get; set; }

	public bool Enabled { get; set; }

	public required string ContextTypeName { get; set; }

	public string? ExtendedTypeName { get; set; }

	public required string ComponentTypeName { get; set; }

	public string Description { get; set; } = string.Empty;

	public int StepCount { get; set; }

	public string StepNames { get; set; } = string.Empty;

	public IEnumerable<int>? ServerIds { get; set; } = [];

	public IEnumerable<int> MissingServerIds { get; set; } = [];

	public string PollerCollectorType { get; set; } = string.Empty;
}
