namespace Entuity.Api.Models;

/// <summary>
/// Information returned from actions. These include:
/// <list type="bullet">
/// <item>Delete Server Group</item>
/// </list>
/// </summary>
public class DeleteResponse
{
	public string ErrorCode { get; set; } = string.Empty;

	public string ErrorDetails { get; set; } = string.Empty;

	public object? Data { get; set; }
}
