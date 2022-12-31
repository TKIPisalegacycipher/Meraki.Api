using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// The Staged Upgrade Milestones for the stage
/// </summary>
public class StagedUpgradeMilestone
{
	/// <summary>
	/// Time that the group was canceled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "canceledAt")]
	public string? CanceledAt { get; set; }

	/// <summary>
	/// Finish time for the group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "completedAt")]
	public string? CompletedAt { get; set; }

	/// <summary>
	/// Scheduled start time for the group
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "scheduledFor")]
	public string? ScheduledFor { get; set; }

	/// <summary>
	/// Start time for the group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startedAt")]
	public string? StartedAt { get; set; }
}
