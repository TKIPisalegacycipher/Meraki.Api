namespace Meraki.Api.Data;

/// <summary>
/// DHCP-specific fields of the packet
/// </summary>
[DataContract]
public class DhcpV4ServerLastPacketFields
{
	/// <summary>
	/// Hardware length of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hlen")]
	public int Hlen { get; set; }

	/// <summary>
	/// Number of hops the packet took.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hops")]
	public int Hops { get; set; }

	/// <summary>
	/// Hardware type code of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "htype")]
	public int Htype { get; set; }

	/// <summary>
	/// Operation code of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "op")]
	public int Op { get; set; }

	/// <summary>
	/// Number of seconds since receiving the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "secs")]
	public int Secs { get; set; }

	/// <summary>
	/// Client hardware address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "chaddr")]
	public int Chaddr { get; set; }

	/// <summary>
	/// Client IP address of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ciaddr")]
	public int Ciaddr { get; set; }

	/// <summary>
	/// Packet flags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "flags")]
	public int Flags { get; set; }

	/// <summary>
	/// Gateway IP address of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "giaddr")]
	public int Giaddr { get; set; }

	/// <summary>
	/// Magic cookie of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "magicCookie")]
	public int MagicCookie { get; set; }

	/// <summary>
	/// Server IP address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "siaddr")]
	public int Siaddr { get; set; }

	/// <summary>
	/// Server identifier address of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sname")]
	public int Sname { get; set; }

	/// <summary>
	/// Transaction id of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "xid")]
	public int Xid { get; set; }

	/// <summary>
	/// Assigned IP address of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "yiaddr")]
	public int Yiaddr { get; set; }

	/// <summary>
	/// Additional DHCP options of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "options")]
	public List<DhcpV4Options>? Options { get; set; }
}