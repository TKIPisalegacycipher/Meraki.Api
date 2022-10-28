﻿namespace Meraki.Api.Extensions;

public static class IOrganizationsPolicyObjectsExtensions
{
	/// <summary>
	/// Lists Policy Objects belonging to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	public static Task<List<OrganizationPolicyObject>> GetOrganizationPolicyObjectsAllAsync(
		this IOrganizationsPolicyObjects organizationsPolicyObjects,
		string organizationId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationsPolicyObjects.GetOrganizationPolicyObjectsApiResponseAsync(
						organizationId,
						startingAfter,
						cancellationToken
					),
					cancellationToken
			);
}
