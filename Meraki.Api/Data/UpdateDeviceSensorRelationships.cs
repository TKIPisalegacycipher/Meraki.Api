using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Body for updating device sensor relationships
/// </summary>
[DataContract]
public class UpdateDeviceSensorRelationships
{
	/// <summary>
	/// The camera assigned to a given sensor. Also supports the inverse when scoped to a given camera.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "livestream")]
	public Livestream? Livestream { get; set; }
}
