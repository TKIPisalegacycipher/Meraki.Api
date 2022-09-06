namespace Meraki.Api.Data;

/// <summary>
/// UpdateOrganizationLicense
/// </summary>
[DataContract]
public class LicenseUpdateRequest
{
	/// <summary>
	/// The serial number of the device to assign this license to. Set this to null to unassign the license. If a different license is already active on the device, this parameter will control queuing/dequeuing this license.
	/// </summary>
	/// <value>The serial number of the device to assign this license to. Set this to null to unassign the license. If a different license is already active on the device, this parameter will control queuing/dequeuing this license.</value>
	[DataMember(Name = "deviceSerial")]
	public string DeviceSerial { get; set; } = string.Empty;
}
