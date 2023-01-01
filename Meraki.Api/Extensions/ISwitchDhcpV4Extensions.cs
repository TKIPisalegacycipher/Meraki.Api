namespace Meraki.Api.Extensions;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public static class ISwitchDhcpV4Extensions
{
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
	public static Task<List<DhcpV4Server>> GetNetworkSwitchDhcpV4ServersSeenAllAsync(
		this ISwitchDhcpV4 switchDhcpV4,
		[AliasAs("networkId")] string networkId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("timespan")] string? timespan = null,
		[AliasAs("startingAfter")] string? startingAfter = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, cancellationToken)
			=> switchDhcpV4.GetNetworkSwitchDhcpV4ServersSeenApiResponseAsync(
				networkId,
				t0,
				timespan,
				startingAfter,
				cancellationToken
			),
			cancellationToken
		);
}
