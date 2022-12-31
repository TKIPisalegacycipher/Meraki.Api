using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class FirmwareUpgradeStagedEvent
{
	/// <summary>
	/// The network devices to be updated
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "products")]
	public FirmwareProducts? Products { get; set; }

	/// <summary>
	/// Reasons for the rollback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reasons")]
	public List<Reasons>? Reasons { get; set; }

	/// <summary>
	/// The ordered stages in the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "stages")]
	public List<FirmwareUpgradesStage>? Stages { get; set; }
}
