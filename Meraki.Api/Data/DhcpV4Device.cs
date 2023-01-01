namespace Meraki.Api.Data;

/// <summary>
/// Attributes of the server when it's a device.
/// </summary>
[DataContract]
public class DhcpV4Device : NamedItem
{
	/// <summary>
	/// Device serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Url link to device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Interface attributes of the server. Only for configured servers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public DhcpV4DeviceInterface? Interface { get; set; }
}