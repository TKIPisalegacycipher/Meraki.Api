﻿namespace Meraki.Api.Interfaces.Products.Sensor;

public interface IDeviceSensorRelationships
{
	/// <summary>
	/// List the sensor roles for a given device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial id</param>
	[ApiOperationId("getDeviceSensorRelationships")]
	[Get("/devices/{serial}/sensor/relationships")]
	Task<List<DeviceSensorRelationship>> GetDeviceSensorRelationshipsAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the sensor roles for devices in a given network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSensorRelationships")]
	[Get("/networks/{networkId}/sensor/relationships")]
	Task<List<NetworkSensorRelationship>> GetNetworkSensorRelationshipsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Assign one or more sensor roles to a given device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial id</param>
	[ApiOperationId("updateDeviceSensorRelationships")]
	[Put("/devices/{serial}/sensor/relationships")]
	Task<DeviceSensorRelationship> UpdateDeviceSensorRelationshipsAsync(
		[Body] UpdateDeviceSensorRelationships updateDeviceSensorRelationships,
		string serial,
		CancellationToken cancellationToken = default
		);
}
