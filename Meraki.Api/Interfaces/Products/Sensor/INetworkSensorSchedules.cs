namespace Meraki.Api.Interfaces.Products.Sensor;

public interface INetworkSensorSchedules
{
	/// <summary>
	/// Returns a list of all sensor schedules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSensorSchedules")]
	[Get("/networks/{networkId}/sensor/schedules")]
	Task<List<NamedIdentifiedItem>> GetNetworkSensorSchedulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
