namespace Meraki.Api.Data;

/// <summary>
/// DSCP attributes of the packet.
/// </summary>
[DataContract]
public class DhcpV4ServerLastPacketIpDscp
{
	/// <summary>
	/// ECN number of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ecn")]
	public int Ecn { get; set; }

	/// <summary>
	/// DSCP tag number of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tag")]
	public int Tag { get; set; }
}