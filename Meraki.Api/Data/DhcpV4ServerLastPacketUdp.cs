namespace Meraki.Api.Data;

/// <summary>
/// UDP attributes of the packet
/// </summary>
[DataContract]
public class DhcpV4ServerLastPacketUdp
{
	/// <summary>
	/// UDP length of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "length")]
	public int Length { get; set; }

	/// <summary>
	/// UDP checksum of the packet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "checksum")]
	public string? Checksum { get; set; }
}