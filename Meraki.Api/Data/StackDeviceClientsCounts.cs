﻿namespace Meraki.Api.Data;
/// <summary>
/// Counts
/// </summary>
[DataContract]
public class StackDeviceClientsCounts
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
