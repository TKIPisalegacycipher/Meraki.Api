using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
public class CreateFirmwareUpgradeStagedEvent
{
	/// <summary>
	/// Contains information about the network to update
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "products")]
	public FirmwareProducts? Products { get; set; }

	/// <summary>
	/// All firmware upgrade stages in the network with their start time.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "stages")]
	public List<FirmwareUpgradesStage>? Stages { get; set; }
}
