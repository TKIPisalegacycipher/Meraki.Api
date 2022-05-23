namespace Meraki.Api.Data;

/// <summary>
/// The type of splash page for the SSID ('None', 'Click-through splash page', 'Billing', 'Password-protected with Meraki RADIUS', 'Password-protected with custom RADIUS', 'Password-protected with Active Directory', 'Password-protected with LDAP', 'SMS authentication', 'Systems Manager Sentry', 'Facebook Wi-Fi', 'Google OAuth', 'Sponsored guest', 'Cisco ISE' or 'Google Apps domain'). This attribute is not supported for template children.
/// /// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SplashPage
{
	/// <summary>
	/// Enum None for "None"
	/// </summary>
	[EnumMember(Value = "None")]
	None,

	/// <summary>
	/// Enum Clickthroughsplashpage for "Click-through splash page"
	/// </summary>
	[EnumMember(Value = "Click-through splash page")]
	Clickthroughsplashpage,

	/// <summary>
	/// Enum Billing for "Billing"
	/// </summary>
	[EnumMember(Value = "Billing")]
	Billing,

	/// <summary>
	/// Enum PasswordprotectedwithMerakiRADIUS for "Password-protected with Meraki RADIUS"
	/// </summary>
	[EnumMember(Value = "Password-protected with Meraki RADIUS")]
	PasswordprotectedwithMerakiRADIUS,

	/// <summary>
	/// Enum PasswordprotectedwithcustomRADIUS for "Password-protected with custom RADIUS"
	/// </summary>
	[EnumMember(Value = "Password-protected with custom RADIUS")]
	PasswordprotectedwithcustomRADIUS,

	/// <summary>
	/// Enum PasswordprotectedwithActiveDirectory for "Password-protected with Active Directory"
	/// </summary>
	[EnumMember(Value = "Password-protected with Active Directory")]
	PasswordprotectedwithActiveDirectory,

	/// <summary>
	/// Enum PasswordprotectedwithLDAP for "Password-protected with LDAP"
	/// </summary>
	[EnumMember(Value = "Password-protected with LDAP")]
	PasswordprotectedwithLDAP,

	/// <summary>
	/// Enum SMSauthentication for "SMS authentication"
	/// </summary>
	[EnumMember(Value = "SMS authentication")]
	SMSauthentication,

	/// <summary>
	/// Enum SystemsManagerSentry for "Systems Manager Sentry"
	/// </summary>
	[EnumMember(Value = "Systems Manager Sentry")]
	SystemsManagerSentry,

	/// <summary>
	/// Enum FacebookWiFi for "Facebook Wi-Fi"
	/// </summary>
	[EnumMember(Value = "Facebook Wi-Fi")]
	FacebookWiFi,

	/// <summary>
	/// Enum GoogleOAuth for "Google OAuth"
	/// </summary>
	[EnumMember(Value = "Google OAuth")]
	GoogleOAuth,

	/// <summary>
	/// Enum Sponsoredguest for "Sponsored guest"
	/// </summary>
	[EnumMember(Value = "Sponsored guest")]
	SponsoredGuest,

	/// <summary>
	/// Enum CiscoISE for "Cisco ISE"
	/// </summary>
	[EnumMember(Value = "Cisco ISE")]
	CiscoISE,

	/// <summary>
	/// Enum Sponsoredguest for "Google Apps domain"
	/// </summary>
	[EnumMember(Value = "Google Apps domain")]
	GoogleAppsDomain
}
