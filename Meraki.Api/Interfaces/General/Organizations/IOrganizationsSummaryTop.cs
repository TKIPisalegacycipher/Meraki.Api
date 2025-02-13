namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsSummaryTop
{
	/// <summary>
	/// Return the top 10 appliances sorted by utilization over given time range.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getOrganizationSummaryTopAppliancesByUtilization")]
	[Get("/organizations/{organizationId}/summary/top/appliances/byUtilization")]
	Task<List<ApplianceUtilizationSummary>> GetOrganizationSummaryTopAppliancesByUtilizationAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 clients by data usage (in mb) over given time range.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getOrganizationSummaryTopClientsByUsage")]
	[Get("/organizations/{organizationId}/summary/top/clients/byUsage")]
	Task<List<ClientUsageSummary>> GetOrganizationSummaryTopClientsByUsageAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top clients by data usage (in mb) over given time range, grouped by manufacturer.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getOrganizationSummaryTopClientsManufacturersByUsage")]
	[Get("/organizations/{organizationId}/summary/top/clients/manufacturers/byUsage")]
	Task<List<ClientManufacturersSummary>> GetOrganizationSummaryTopClientsManufacturersByUsageAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 devices sorted by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getOrganizationSummaryTopDevicesByUsage")]
	[Get("/organizations/{organizationId}/summary/top/devices/byUsage")]
	Task<List<DeviceUsageSummary>> GetOrganizationSummaryTopDevicesByUsageAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 device models sorted by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getOrganizationSummaryTopDevicesModelsByUsage")]
	[Get("/organizations/{organizationId}/summary/top/devices/models/byUsage")]
	Task<List<DeviceModelUsageSummary>> GetOrganizationSummaryTopDevicesModelsByUsageAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 ssids by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getOrganizationSummaryTopSsidsByUsage")]
	[Get("/organizations/{organizationId}/summary/top/ssids/byUsage")]
	Task<List<SsidUsageSummary>> GetOrganizationSummaryTopSsidsByUsageAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 switches by energy usage over given time range. Default unit is joules.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	[ApiOperationId("getOrganizationSummaryTopSwitchesByEnergyUsage")]
	[Get("/organizations/{organizationId}/summary/top/switches/byEnergyUsage")]
	Task<List<EnergyUsageSummary>> GetOrganizationSummaryTopSwitchesByEnergyUsageAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);
}
