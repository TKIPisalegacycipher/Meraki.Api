namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksFirmwareUpgrades
{
	/// <summary>
	/// Get firmware upgrade information for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkFirmwareUpgrades")]
	[Get("/networks/{networkId}/firmwareUpgrades")]
	Task<NetworkFirmwareUpgrade> GetNetworkFirmwareUpgradesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update firmware upgrade information for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkFirmwareUpgrades">Body for updating network firmware upgrades</param>
	[ApiOperationId("updateNetworkFirmwareUpgrades")]
	[Put("/networks/{networkId}/firmwareUpgrades")]
	Task<NetworkFirmwareUpgrade> UpdateNetworkFirmwareUpgradesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkFirmwareUpgradeUpdateRequest updateNetworkFirmwareUpgrades,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Rollback a Firmware Upgrade For A Network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkFirmwareUpgradesRollback">Body for creating network firmware upgrade rollbacks</param>
	[ApiOperationId("createNetworkFirmwareUpgradesRollback")]
	[Post("/networks/{networkId}/firmwareUpgrades/rollbacks")]
	Task<NetworkFirmwareUpgrade> CreateNetworkFirmwareUpgradesRollbackAsync(
		[AliasAs("networkId")] string networkId,
		[Body] FirmwareUpgradeRollbackRequest createNetworkFirmwareUpgradesRollback,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Get the Staged Upgrade Event from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkFirmwareUpgradesStagedEvents")]
	[Get("/networks/{networkId}/firmwareUpgrades/staged/events")]
	Task<FirmwareUpgradeStagedEvent> GetNetworkFirmwareUpgradesStagedEventsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a Staged Upgrade Event for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("createNetworkFirmwareUpgradesStagedEvent")]
	[Post("/networks/{networkId}/firmwareUpgrades/staged/events")]
	Task<FirmwareUpgradeStagedEvent> CreateNetworkFirmwareUpgradesStagedEventAsync(
		[Body] CreateFirmwareUpgradeStagedEvent createNetworkFirmwareUpgradesStagedEvent,
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Postpone by 1 week all pending staged upgrade stages for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("deferNetworkFirmwareUpgradesStagedEvents")]
	[Post("/networks/{networkId}/firmwareUpgrades/staged/events/defer")]
	Task<FirmwareUpgradeStagedEvent> DeferNetworkFirmwareUpgradesStagedEventsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Rollback a Staged Upgrade Event for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("rollbacksNetworkFirmwareUpgradesStagedEvents")]
	[Post("/networks/{networkId}/firmwareUpgrades/staged/events/rollbacks")]
	Task<FirmwareUpgradeStagedEvent> RollbacksNetworkFirmwareUpgradesStagedEventsAsync(
		[Body] CreateFirmwareUpgradeStagedEvent rollbacksNetworkFirmwareUpgradesStagedEvents,
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the Staged Upgrade Event for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("updateNetworkFirmwareUpgradesStagedEvents")]
	[Put("/networks/{networkId}/firmwareUpgrades/staged/events")]
	Task<FirmwareUpgradeStagedEvent> UpdateNetworkFirmwareUpgradesStagedEventsAsync(
		[Body] CreateFirmwareUpgradeStagedEvent updateNetworkFirmwareUpgradesStagedEvents,
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a Staged Upgrade Group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupId">The group id</param>
	[ApiOperationId("deleteNetworkFirmwareUpgradesStagedGroup")]
	[Delete("/networks/{networkId}/firmwareUpgrades/staged/groups/{groupId}")]
	Task DeleteNetworkFirmwareUpgradesStagedGroupAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupId")] string groupId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a Staged Upgrade Group from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupId">The group id</param>
	[ApiOperationId("getNetworkFirmwareUpgradesStagedGroup")]
	[Get("/networks/{networkId}/firmwareUpgrades/staged/groups/{groupId}")]
	Task<FirmwareStagedGroup> GetNetworkFirmwareUpgradesStagedGroupAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupId")] string groupId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List of Staged Upgrade Groups in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkFirmwareUpgradesStagedGroups")]
	[Get("/networks/{networkId}/firmwareUpgrades/staged/groups")]
	Task<List<FirmwareStagedGroup>> GetNetworkFirmwareUpgradesStagedGroupsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a Staged Upgrade Group for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("createNetworkFirmwareUpgradesStagedGroup")]
	[Post("/networks/{networkId}/firmwareUpgrades/staged/groups")]
	Task<FirmwareStagedGroup> CreateNetworkFirmwareUpgradesStagedGroupAsync(
		[Body] FirmwareStagedGroup createNetworkFirmwareUpgradesStagedGroup,
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a Staged Upgrade Group for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupId">The group id</param>
	[ApiOperationId("updateNetworkFirmwareUpgradesStagedGroup")]
	[Post("/networks/{networkId}/firmwareUpgrades/staged/groups/{groupId}")]
	Task<FirmwareStagedGroup> UpdateNetworkFirmwareUpgradesStagedGroupAsync(
		[Body] FirmwareStagedGroup updateNetworkFirmwareUpgradesStagedGroup,
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupId")] string groupId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Order of Staged Upgrade Groups in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkFirmwareUpgradesStagedStages")]
	[Get("/networks/{networkId}/firmwareUpgrades/staged/stages")]
	Task<List<FirmwareUpgradesStage>> GetNetworkFirmwareUpgradesStagedStagesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Assign Staged Upgrade Group order in the sequence.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("updateNetworkFirmwareUpgradesStagedStages")]
	[Put("/networks/{networkId}/firmwareUpgrades/staged/stages")]
	Task<List<FirmwareUpgradesStage>> UpdateNetworkFirmwareUpgradesStagedStagesAsync(
		[Body] FirmwareUpgradesStageUpdateRequest updateNetworkFirmwareUpgradesStagedStages,
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);
}
