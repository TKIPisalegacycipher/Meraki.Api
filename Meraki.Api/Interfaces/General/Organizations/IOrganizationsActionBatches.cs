namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsActionBatches
{
	/// <summary>
	/// Create an action batch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationActionBatch">Body for creating organization action batch</param>
	[Post("/organizations/{organizationId}/actionBatches")]
	Task<ActionBatch> CreateOrganizationActionBatchAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] ActionBatchCreationRequest createOrganizationActionBatch,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete an action batch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="actionBatchId"></param>
	[Delete("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
	Task DeleteOrganizationActionBatchAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("actionBatchId")] string actionBatchId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return an action batch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="actionBatchId">The action batch id</param>
	[Get("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
	Task<ActionBatch> GetOrganizationActionBatchAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("actionBatchId")] string actionBatchId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the list of action batches in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="status">Filter batches by status. Valid types are pending, completed, and failed.</param>
	[Get("/organizations/{organizationId}/actionBatches")]
	Task<List<ActionBatch>> GetOrganizationActionBatchesAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("status")] string? status = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an action batch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="actionBatchId">The action batch id</param>
	/// <param name="updateOrganizationActionBatch">Body for updating organization action batch</param>
	[Put("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
	Task<ActionBatch> UpdateOrganizationActionBatchAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("actionBatchId")] string actionBatchId,
		[Body] ActionBatchUpdateRequest updateOrganizationActionBatch = null!,
		CancellationToken cancellationToken = default);
}
