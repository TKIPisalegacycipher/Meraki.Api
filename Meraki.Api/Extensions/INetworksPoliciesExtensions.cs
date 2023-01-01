namespace Meraki.Api.Extensions;

public static class INetworksPoliciesExtensions
{
	/// <summary>
	/// Get policies for all clients with policies
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getNetworkPoliciesByClient")]
	[Get("/networks/{networkId}/policies/byClient")]
	public static Task<List<NetworkPolicy>> GetNetworkPoliciesByClientAllAsync(
		this INetworksPolicies networkPolicies,
		[AliasAs("networkId")] string networkId,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("timespan")] int? timespan = 1,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, cancellationToken)
			=> networkPolicies.GetNetworkPoliciesByClientApiResponseAsync(
				networkId,
				startingAfter,
				t0,
				timespan,
				cancellationToken
			),
			cancellationToken
		);
}
