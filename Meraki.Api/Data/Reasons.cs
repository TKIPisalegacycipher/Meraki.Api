namespace Meraki.Api.Data;

/// <summary>
/// Reasons
/// </summary>
[DataContract]
public class Reasons
{
	/// <summary>
	/// Reason for the rollback
	/// </summary>
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// Additional comment about the rollback
	/// </summary>
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
