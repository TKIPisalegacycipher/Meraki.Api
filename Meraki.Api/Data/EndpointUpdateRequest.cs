namespace Meraki.Api.Data;

[DataContract]
public class EndpointUpdateRequest
{
	/// <summary>
	/// An http server object
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "httpServer")]
	public HttpServerUpdateRequest? HttpServer { get; set; }

	/// <summary>
	/// API version that the receiver expects to get; '1', '2' or '3'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "scanningApiVersion")]
	public int ScanningApiVersion { get; set; }

	/// <summary>
	/// Radio type to use for scanning; 'WiFi' or 'BLE'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radioType")]
	public string? RadioType { get; set; }
}