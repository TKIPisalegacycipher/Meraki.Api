﻿namespace Meraki.Api.Test.Devices;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task PutDeviceAsync_WithMoveMapMarker_Succeeds()
	{
		var devices = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(Configuration.TestNetworkId)
			.ConfigureAwait(false);

		devices
			.Should()
			.NotBeNullOrEmpty();

		var deviceSerial = devices[0].Serial;

		var device = await TestMerakiClient
			.Devices
			.GetDeviceAsync(deviceSerial)
			.ConfigureAwait(false);

		device.Should().NotBeNull();
		device.Serial.Should().Equals(deviceSerial);
		device.Firmware.Should().NotBeNull();

		if (device.Address != string.Empty)
		{
			device.Address = string.Empty;
			await TestMerakiClient
				.Devices
				.UpdateDeviceAsync(
					device.Serial,
					device
				)
				.ConfigureAwait(false);
		}
		//Device now has blank address

		device.Address = "Picadilly Circus, London";
		device.MoveMapMarker = true;
		var updatedDevice = await TestMerakiClient
			.Devices
			.UpdateDeviceAsync(
				device.Serial,
				device
			)
			.ConfigureAwait(false);

		updatedDevice.Should().NotBeNull();
	}

	[Fact]
	public async Task BlinkDeviceAsync_Succeeds()
	{
		var deviceStatuses = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);

		deviceStatuses
			.Should()
			.NotBeNullOrEmpty();

		var onlineDevice = deviceStatuses.Find(d => d.Status == "online");
		onlineDevice.Should().NotBeNull("Could not find an online device");

		var outcome = await TestMerakiClient
			.Devices
			.BlinkDeviceLedsAsync(
				onlineDevice!.Serial,
				new BlinkLeds
				{
					Duration = 10,
					Period = 500
				})
			.ConfigureAwait(false);

		outcome
			.Should()
			.NotBeNull();
	}

	// Test disabled - could only test with temporary credentials.
	[Fact]
	public async Task GetDeviceNetworkManagementSettingsAsync_Succeeds()
	{
		var devices = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(Configuration.TestNetworkId)
			.ConfigureAwait(false);

		devices
			.Should()
			.NotBeNull()
			.And
			.NotBeEmpty();

		var deviceSerial = devices[0].Serial;

		var deviceManagementInterfaceSettings = await TestMerakiClient
			.Devices
			.ManagementInterface
			.GetDeviceManagementInterfaceAsync(deviceSerial)
			.ConfigureAwait(false);

		deviceManagementInterfaceSettings
			.Should()
			.NotBeNull();
	}
}
