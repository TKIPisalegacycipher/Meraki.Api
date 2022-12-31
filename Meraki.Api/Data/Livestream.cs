namespace Meraki.Api.Data;

[DataContract]
public class Livestream
{
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "relatedDevices")]
	public List<DeviceUsageSummary>? RelatedDevices { get; set; }
}