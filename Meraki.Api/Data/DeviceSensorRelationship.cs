using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class DeviceSensorRelationship
{
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "livestream")]
	public Livestream? Livestream { get; set; }
}
