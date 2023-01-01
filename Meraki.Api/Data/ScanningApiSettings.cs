namespace Meraki.Api.Data;

/// <summary>
/// Scanning API settings
/// </summary>
[DataContract]
public class ScanningApiSettings
{
	/// <summary>
	/// Validator for push API.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "validator")]
	public string? Validator { get; set; }

	/// <summary>
	/// Whether to enable collection of location and scanning analytics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "analyticsEnabled")]
	public bool AnalyticsEnabled { get; set; }

	/// <summary>
	/// Whether to enable push API for scanning events. Analytics must be enabled to enable scanning API.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scanningApiEnabled")]
	public bool ScanningApiEnabled { get; set; }
}
