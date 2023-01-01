namespace Meraki.Api.Data;

/// <summary>
/// Devices that saw the server
/// </summary>
[DataContract]
public class DhcpV4ServerSeenBy : NamedItem
{
	/// <summary>
	/// Device serial.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Url link to device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }
}