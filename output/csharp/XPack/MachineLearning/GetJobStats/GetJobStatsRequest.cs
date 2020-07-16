using Nest.CommonAbstractions;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Nest.XPack {

	public class GetJobStatsRequest : RequestBase {
		
		[DataMember(Name="allow_no_jobs")]
		public bool AllowNoJobs { get; set; }

	}
}
