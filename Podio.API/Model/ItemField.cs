using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public class ItemField 
	{


		[DataMember(Name = "field_id", IsRequired=false)]
		public int? FieldId { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "external_id", IsRequired=false)]
		public string ExternalId { get; set; }


		[DataMember(Name = "label", IsRequired=false)]
		public string Label { get; set; }


		[DataMember(Name = "values", IsRequired=false)]
		public List<Podio.API.Utils.JSONVariableData> Values { get; set; }


		[DataMember(Name = "config", IsRequired=false)]
		public Podio.API.Utils.JSONVariableData Config { get; set; }


	}
}

