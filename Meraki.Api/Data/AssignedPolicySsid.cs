namespace Meraki.Api.Data;

/// <summary>
/// ssid
/// </summary>
public class AssignedPolicySsid
{
	/// <summary>
	/// number of ssid
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }
}
