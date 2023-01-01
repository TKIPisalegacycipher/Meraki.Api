namespace Meraki.Api.Data;

/// <summary>
/// Attributes of the server when it's a device.
/// </summary>
[DataContract]
public class DhcpV4DeviceInterface : NamedItem
{
	/// <summary>
	/// Url link to interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }
}