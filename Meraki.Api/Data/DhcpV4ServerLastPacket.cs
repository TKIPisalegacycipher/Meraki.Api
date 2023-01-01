namespace Meraki.Api.Data;

/// <summary>
/// Last packet the server received
/// </summary>
[DataContract]
public class DhcpV4ServerLastPacket
{
	/// <summary>
	/// Packet type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Destination of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destination")]
	public DhcpV4ServerLastPacketDestination? Destination { get; set; }

	/// <summary>
	/// Additional ethernet attributes of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ethernet")]
	public DhcpV4ServerLastPacketEthernet? Ethernet { get; set; }

	/// <summary>
	/// DHCP-specific fields of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fields")]
	public DhcpV4ServerLastPacketFields? Fields { get; set; }

	/// <summary>
	/// Additional IP attributes of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ip")]
	public DhcpV4ServerLastPacketIp? Ip { get; set; }

	/// <summary>
	/// Source of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public DhcpV4ServerLastPacketSource? Source { get; set; }

	/// <summary>
	/// UDP attributes of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public DhcpV4ServerLastPacketUdp? Udp { get; set; }
}