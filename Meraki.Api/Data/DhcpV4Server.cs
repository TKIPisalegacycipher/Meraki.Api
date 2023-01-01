namespace Meraki.Api.Data;

/// <summary>
/// No documentation available
/// </summary>
[DataContract]
public class DhcpV4Server
{
	/// <summary>
	/// Vlan id of the server.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// Client id of the server if available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientId")]
	public string? ClientId { get; set; }

	/// <summary>
	/// Last time the server was seen.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastSeenAt")]
	public string? LastSeenAt { get; set; }

	/// <summary>
	/// Mac address of the server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// server type. Can be a 'device', 'stack', or 'discovered' (i.e client).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Whether the server is allowed or blocked. Always true for configured servers.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAllowed")]
	public bool IsAllowed { get; set; }

	/// <summary>
	/// Whether the server is configured.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isConfigured")]
	public bool IsConfigured { get; set; }

	/// <summary>
	/// Attributes of the server when it's a device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public DhcpV4Server? Device { get; set; }

	/// <summary>
	/// IPv4 attributes of the server.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public DhcpV4ServerIpv4Attributes? Ipv4 { get; set; }

	/// <summary>
	/// Attributes of the server's last ack.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastAck")]
	public DhcpV4ServerLastAck? LastAck { get; set; }

	/// <summary>
	/// Last packet the server received
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastPacket")]
	public DhcpV4ServerLastPacket? LastPacket { get; set; }

	/// <summary>
	/// Devices that saw the server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "seenBy")]
	public DhcpV4ServerSeenBy? SeemBy { get; set; }
}