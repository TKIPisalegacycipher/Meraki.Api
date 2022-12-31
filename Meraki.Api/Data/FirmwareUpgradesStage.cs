namespace Meraki.Api.Data;

/// <summary>
/// Rollback
/// </summary>
[DataContract]
public class FirmwareUpgradesStage
{
	/// <summary>
	/// Current upgrade status of the group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// The staged upgrade group
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "group")]
	public StagedUpgradeGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the stage
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "milestones")]
	public StagedUpgradeMilestone? Milestones { get; set; }
}
