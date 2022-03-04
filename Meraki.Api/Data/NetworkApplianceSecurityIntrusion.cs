namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSecurityIntrusionSettings
/// </summary>
[DataContract]
public class NetworkApplianceSecurityIntrusion
{
	/// <summary>
	/// Gets or Sets Mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mode")]
	public SecurityIntrusionMode? Mode { get; set; }

	/// <summary>
	/// Gets or Sets IdsRulesets
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "idsRulesets")]
	public SecurityIntrusionDetectionRuleSet? IdsRulesets { get; set; }

	/// <summary>
	/// Gets or Sets ProtectedNetworks
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protectedNetworks")]
	public ProtectedNetworks ProtectedNetworks { get; set; } = new();
}
