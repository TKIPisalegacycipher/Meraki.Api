using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// The staged upgrade group
/// </summary>
public class StagedUpgradeGroup : NamedItem
{
	/// <summary>
	/// Description of the Staged Upgrade Group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Id of the Staged Upgrade Group
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
