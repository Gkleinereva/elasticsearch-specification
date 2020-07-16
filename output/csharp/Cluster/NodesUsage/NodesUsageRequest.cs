using Nest.CommonOptions;
using Nest.CommonAbstractions;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Nest.Cluster {

	public class NodesUsageRequest : RequestBase {
		
		[DataMember(Name="timeout")]
		public Time Timeout { get; set; }

	}
}
