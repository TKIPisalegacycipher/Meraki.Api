﻿namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmUsersSoftwares
{
	/// <summary>
	/// Get a list of softwares associated with a user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="userId">The user id</param>
	[Get("/networks/{networkId}/sm/users/{userId}/softwares")]
	Task<List<Software>> GetNetworkSmUserSoftwaresAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("userId")] string userId,
		CancellationToken cancellationToken = default
		);
}
