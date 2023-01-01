namespace Meraki.Api.Data;

/// <summary>
/// Network policy
/// </summary>
[DataContract]
public class NetworkPolicy : NamedItem
{
	/// <summary>
	/// ID of client
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientId")]
	public string? ClientId { get; set; }

	/// <summary>
	/// Assigned policies
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assigned")]
	public List<AssignedPolicy>? Assigned { get; set; }
}
