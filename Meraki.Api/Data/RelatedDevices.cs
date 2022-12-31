namespace Meraki.Api.Data;

/// <summary>
/// Related devices for the role
/// </summary>
[DataContract]
public class RelatedDevices
{
	/// <summary>
	/// The serial of the related device
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// The type of the related device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public ProductType? ProductType { get; set; }
}