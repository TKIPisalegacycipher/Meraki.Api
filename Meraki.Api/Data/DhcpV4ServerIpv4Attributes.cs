namespace Meraki.Api.Data;

/// <summary>
/// IPv4 attributes of the server.
/// </summary>
[DataContract]
public class DhcpV4ServerIpv4Attributes
{
	/// <summary>
	/// IPv4 address of the server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// IPv4 gateway address of the server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gateway")]
	public string? Gateway { get; set; }

	/// <summary>
	/// Subnet of the server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }
}