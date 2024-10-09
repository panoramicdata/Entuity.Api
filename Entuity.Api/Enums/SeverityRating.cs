namespace Entuity.Api.Enums;

/// <summary>
/// A given severity rating
/// </summary>

[Flags]
public enum SeverityRating : short
{
	Info = 1,
	Minor = 2,
	Major = 4,
	Severe = 8,
	Critical = 16
}
