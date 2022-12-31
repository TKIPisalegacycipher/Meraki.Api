namespace Meraki.Api.Data;

/// <summary>
/// The camera assigned to a given sensor. Also supports the inverse when scoped to a given camera.
/// </summary>
[DataContract]
public class Livestream
{
	/// <summary>
	/// An array of the related devices for the role
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "relatedDevices")]
	public List<RelatedDevices>? RelatedDevices { get; set; }
}