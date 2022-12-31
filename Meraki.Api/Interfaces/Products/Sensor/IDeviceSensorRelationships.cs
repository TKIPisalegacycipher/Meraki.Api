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
}
