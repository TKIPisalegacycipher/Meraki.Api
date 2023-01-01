namespace Meraki.Api.Data;

/// <summary>
/// Network sensor relationship
/// </summary>
[DataContract]
public class NetworkSensorRelationship
{
	/// <summary>
	/// Device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public RelatedDevices? Device { get; set; }

	/// <summary>
	/// Relationships
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "relationships")]
	public DeviceSensorRelationship? Relationships { get; set; }
}
