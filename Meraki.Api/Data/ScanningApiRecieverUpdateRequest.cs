namespace Meraki.Api.Data;

/// <summary>
/// Scanning API reciever update request
/// </summary>
[DataContract]
public class ScanningApiRecieverUpdateRequest
{
	/// <summary>
	/// A set of http server configurations
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "endpoints")]
	public List<EndpointUpdateRequest>? Endpoints { get; set; }
}
