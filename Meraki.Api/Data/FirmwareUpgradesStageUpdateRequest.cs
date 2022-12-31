namespace Meraki.Api.Data;

[DataContract]
public class FirmwareUpgradesStageUpdateRequest
{
	/// <summary>
	/// Array of Staged Upgrade Groups
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "_json")]
	public List<StagedUpgradeGroup>? Json { get; set; }
}
