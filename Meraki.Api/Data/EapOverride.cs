﻿namespace Meraki.Api.Data;

/// <summary>
/// EAP override
/// </summary>
[DataContract]
public class EapOverride
{
	/// <summary>
	/// EAP timeout override
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_timeout_override")]
	public bool EapTimeoutOverride { get; set; }

	/// <summary>
	/// EAP initial timeout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_initial_timeout")]
	public int EapInitialTimeout { get; set; }

	/// <summary>
	/// EAP max retries override
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_max_retries_override")]
	public bool EapMaxRetriesOverride { get; set; }

	/// <summary>
	/// EAP max retries
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_max_retries")]
	public int EapMaxRetries { get; set; }

	/// <summary>
	/// EAP identity timeout override
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_identity_timeout_override")]
	public bool EapIdentityTimeoutOverride { get; set; }

	/// <summary>
	/// EAP identity timeout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_identity_timeout")]
	public int EapIdentityTimeout { get; set; }

	/// <summary>
	/// EAP identity retries override
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_identity_retries_override")]
	public bool EapIdentityRetriesOverride { get; set; }

	/// <summary>
	/// EAP identity retries
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eap_identity_retries")]
	public int EapIdentityRetries { get; set; }

	/// <summary>
	/// EAP key timeout override
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eapol_key_timeout_override")]
	public bool EapolKeyTimeoutOverride { get; set; }

	/// <summary>
	/// EAP key timeout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eapol_key_timeout")]
	public int EapolKeyTimeout { get; set; }

	/// <summary>
	/// EAP key retries override
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eapol_key_retries_override")]
	public bool EapolKeyRetriesOverride { get; set; }

	/// <summary>
	/// EAP key retries
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eapol_key_retries")]
	public int EapolKeyRetries { get; set; }
}
