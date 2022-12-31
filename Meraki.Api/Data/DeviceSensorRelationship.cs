﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Response for viewing device sensor relationships
/// </summary>
[DataContract]
public class DeviceSensorRelationship
{
	/// <summary>
	/// The camera assigned to a given sensor. Also supports the inverse when scoped to a given camera.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "livestream")]
	public Livestream? Livestream { get; set; }
}
