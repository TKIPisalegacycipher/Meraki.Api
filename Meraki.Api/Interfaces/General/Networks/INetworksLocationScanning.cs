namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksLocationScanning
{
	/// <summary>
	/// Return scanning API settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkLocationScanning")]
	[Get("/networks/{networkId}/locationScanning")]
	Task<ScanningApiSettings> GetNetworkLocationScanningAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Change scanning API settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("updateNetworkLocationScanning")]
	[Put("/networks/{networkId}/locationScanning")]
	Task<ScanningApiSettings> UpdateNetworkLocationScanningAsync(
		[Body] ScanningApiSettingsUpdateRequest updateNetworkLocationScanning,
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return list of scanning API receivers
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkLocationScanningHttpServers")]
	[Get("/networks/{networkId}/locationScanning/httpServers")]
	Task<List<ScanningApiReciever>> GetNetworkLocationScanningHttpServersAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Set the list of scanning API receivers. Old receivers will be removed
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("updateNetworkLocationScanningHttpServers")]
	[Put("/networks/{networkId}/locationScanning/httpServers")]
	Task<List<ScanningApiReciever>> UpdateNetworkLocationScanningHttpServersAsync(
		[Body] ScanningApiRecieverUpdateRequest updateNetworkLocationScanningHttpServers,
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);
}
