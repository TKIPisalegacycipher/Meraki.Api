namespace Meraki.Api.Data;

[DataContract]
public class Endpoint
{
	/// <summary>
	/// HTTP server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "httpServer")]
	public HttpServer? HttpServer { get; set; }

	/// <summary>
	/// Success at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "successAt")]
	public string? SuccessAt { get; set; }

	/// <summary>
	/// Error at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errorAt")]
	public string? ErrorAt { get; set; }

	/// <summary>
	/// Post errors
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "postErrors")]
	public string? PostErrors { get; set; }
}