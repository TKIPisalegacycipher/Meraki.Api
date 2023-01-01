namespace Meraki.Api.Data;

[DataContract]
public class HttpServer : NamedIdentifiedItem
{
	/// <summary>
	/// URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Validator
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "validator")]
	public string? Validator { get; set; }

	/// <summary>
	/// Date validated at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "validatedAt")]
	public string? ValidatedAt { get; set; }

	/// <summary>
	/// Shared secret
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }
}