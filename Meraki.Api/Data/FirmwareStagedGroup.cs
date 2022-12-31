using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// The staged upgrade group
/// </summary>
public class FirmwareStagedGroup : NamedItem
{
	/// <summary>
	/// Description of the Staged Upgrade Group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Id of staged upgrade group
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "groupId")]
	public string? GroupId { get; set; }

	/// <summary>
	/// Boolean indicating the default Group. Any device that does not have a group explicitly assigned will upgrade with this group
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "isDefault")]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// The devices and Switch Stacks assigned to the Group
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "assignedDevices")]
	public StagedGroupAssignedDevices? AssignedDevices { get; set; }
}
