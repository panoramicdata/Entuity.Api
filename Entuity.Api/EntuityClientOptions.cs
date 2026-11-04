
using Microsoft.Extensions.Logging;

namespace Entuity.Api;

public class EntuityClientOptions
{
	/// <summary>
	/// The system URL
	/// </summary>
	public required string Url { get; set; }

	/// <summary>
	/// The username to use for authentication
	/// </summary>
	public required string Username { get; set; }

	/// <summary>
	/// The password to use for authentication
	/// </summary>
	public required string Password { get; set; }

	/// <summary>
	/// An optional user agent to use for the requests
	/// </summary>
	public string? UserAgent { get; set; }

	/// <summary>
	/// When true, the client refuses every request other than GET, HEAD and OPTIONS, before it is sent. Defaults to false.
	/// </summary>
	public bool IsReadOnly { get; set; }

	/// <summary>
	/// An optional logger
	/// </summary>
	public ILogger? Logger { get; set; }
}