namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchDhcpV4
{
	/// <summary>
	/// Return the network's DHCPv4 servers seen within the selected timeframe (default 1 day)
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	[ApiOperationId("getNetworkSwitchDhcpV4ServersSeen")]
	[Get("/networks/{networkId}/switch/dhcp/v4/servers/seen")]
	Task<List<DhcpV4Server>> GetNetworkSwitchDhcpV4ServersSeenAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("timespan")] string? timespan = null,
		[AliasAs("perPage")] int? perPage = 1000,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the network's DHCPv4 servers seen within the selected timeframe (default 1 day)
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	[ApiOperationId("getNetworkSwitchDhcpV4ServersSeen")]
	[Get("/networks/{networkId}/switch/dhcp/v4/servers/seen")]
	internal Task<ApiResponse<List<DhcpV4Server>>> GetNetworkSwitchDhcpV4ServersSeenApiResponseAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("timespan")] string? timespan = null,
		[AliasAs("startingAfter")] string? startingAfter = null,
		CancellationToken cancellationToken = default
		);
}
