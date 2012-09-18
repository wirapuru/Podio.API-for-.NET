using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public class StreamMute 
	{


		[DataMember(Name = "id", IsRequired=false)]
		public int? Id { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "data", IsRequired=false)]
		public Podio.API.Utils.Hash Data { get; set; }


		[DataMember(Name = "item", IsRequired=false)]
		public bool Item { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public bool Status { get; set; }


		[DataMember(Name = "task", IsRequired=false)]
		public bool Task { get; set; }


	}
}

