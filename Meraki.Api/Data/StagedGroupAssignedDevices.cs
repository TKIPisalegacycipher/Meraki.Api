namespace Meraki.Api.Data;

[DataContract]
public class StagedGroupAssignedDevices
{
	/// <summary>
	/// Data Array of Devices containing the name and serial
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "devices")]
	public List<Device>? Devices { get; set; }

	/// <summary>
	/// Data Array of Switch Stacks containing the name and id
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "switchStacks")]
	public List<SwitchStack>? SwitchStacks { get; set; }
}