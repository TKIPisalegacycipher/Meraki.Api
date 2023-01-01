namespace Meraki.Api.Data;

/// <summary>
/// Attributes of the server's last ack.
/// </summary>
[DataContract]
public class DhcpV4ServerLastAck
{
	/// <summary>
	/// Attributes of the server's last ack.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string? Ts { get; set; }

	/// <summary>
	/// IPv4 attributes of the last ack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public DhcpV4ServerIpv4Attributes? Ipv4 { get; set; }
}