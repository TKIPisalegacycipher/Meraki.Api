namespace Meraki.Api.Data;

/// <summary>
/// Additional DHCP options of the packet
/// </summary>
[DataContract]
public class DhcpV4Options : NamedItem
{
	/// <summary>
	/// Option value.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string? Value { get; set; }
}