namespace Meraki.Api.Data;

/// <summary>
/// Scanning API reciever
/// </summary>
[DataContract]
public class ScanningApiReciever
{
	/// <summary>
	/// Endpoints
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endpoints")]
	public List<Endpoint>? Endpoints { get; set; }
}
