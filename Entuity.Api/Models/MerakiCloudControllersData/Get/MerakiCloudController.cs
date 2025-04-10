using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.MerakiCloudControllersData.Get;

/// <summary>
/// Holds information about a Meraki Cloud Controller.
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13835561179165-Cisco-Meraki-Cloud-Controllers-RESTful-API#get'/></para>
/// </summary>
public class MerakiCloudController : IGetItem
{
	/// <summary>
	/// The Entuity server ID String
	/// </summary>
	public Guid ServerId { get; set; }

	/// <summary>
	/// The StormWorks Object ID of the Meraki device on the server
	/// </summary>
	public int ObjectId { get; set; }

	/// <summary>
	/// The Display name of the device in ENA
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The StormWorks Type
	/// </summary>
	public string StormWorksType { get; set; } = string.Empty;

	/// <summary>
	/// This is the URL that should be put in the settings of the cloud controller (using the Cisco website, not anything in ENA)
	/// </summary>
	public string WebhookURL { get; set; } = string.Empty;

	/// <summary>
	/// If the Secret Key is set
	/// </summary>
	public bool SecretKeyIsSet { get; set; }

	/// <summary>
	/// If the Secret Key is shared
	/// </summary>
	public object? SharedSecret { get; set; }

	/// <summary>
	/// If the Webhook is enabled
	/// </summary>
	public bool WebhookEnabled { get; set; }

	/// <summary>
	/// This is the same as the status displayed in the ENA webhook admin page
	/// </summary>
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Number of devices managed by the cloud controller
	/// </summary>
	public int MerakiDeviceCount { get; set; }

	/// <summary>
	/// Key that should be entrered on the cloud controller settings page (same as the URL)
	/// </summary>
	public string? SecretKey { get; set; }
}
