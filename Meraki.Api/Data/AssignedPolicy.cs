namespace Meraki.Api.Data;

/// <summary>
/// Assigned policy
/// </summary>
public class AssignedPolicy : NamedItem
{
	/// <summary>
	/// Type of policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// ssid
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssid")]
	public AssignedPolicySsid? Ssid { get; set; }
}
