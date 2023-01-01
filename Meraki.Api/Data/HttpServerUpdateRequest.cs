namespace Meraki.Api.Data;

[DataContract]
public class HttpServerUpdateRequest : NamedItem
{
	/// <summary>
	/// The URL of the HTTP server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Validator
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "validator")]
	public string? Validator { get; set; }

	/// <summary>
	/// Date validated at
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "validatedAt")]
	public string? ValidatedAt { get; set; }

	/// <summary>
	/// A shared secret that will be included in POSTs sent to the HTTP server. This secret can be used to verify that the request was sent by Meraki.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }
}