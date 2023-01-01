namespace Meraki.Api.Data;

/// <summary>
/// Scanning API settings
/// </summary>
[DataContract]
public class ScanningApiSettingsUpdateRequest
{
	/// <summary>
	/// Collect location and scanning analytics
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "analyticsEnabled")]
	public bool AnalyticsEnabled { get; set; }

	/// <summary>
	/// Enable push API for scanning events, analytics must be enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "scanningApiEnabled")]
	public bool ScanningApiEnabled { get; set; }
}
