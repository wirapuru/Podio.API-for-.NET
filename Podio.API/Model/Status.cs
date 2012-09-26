using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public class Status 
	{


		[DataMember(Name = "status_id", IsRequired=false)]
		public int? StatusId { get; set; }


		[DataMember(Name = "value", IsRequired=false)]
		public string Value { get; set; }


		[DataMember(Name = "rich_value", IsRequired=false)]
		public string RichValue { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public string CreatedOn { get; set; }


		[DataMember(Name = "alerts", IsRequired=false)]
		public string[] Alerts { get; set; }


		[DataMember(Name = "ratings", IsRequired=false)]
		public Podio.API.Utils.JSONVariableData[] Ratings { get; set; }


		[DataMember(Name = "subscribed", IsRequired=false)]
		public bool? Subscribed { get; set; }


		[DataMember(Name = "user_ratings", IsRequired=false)]
		public Podio.API.Utils.JSONVariableData[] UserRatings { get; set; }


		[DataMember(Name = "file_ids", IsRequired=false)]
		public List<int> FileIds { get; set; }


		[DataMember(Name = "embed_id", IsRequired=false)]
		public int? EmbedId { get; set; }


		[DataMember(Name = "embed_file_id", IsRequired=false)]
		public int? EmbedFileId { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public Contact CreatedBy { get; set; }


		[DataMember(Name = "created_via", IsRequired=false)]
		public Via CreatedVia { get; set; }


		[DataMember(Name = "embed", IsRequired=false)]
		public Embed Embed { get; set; }


		[DataMember(Name = "embed_file", IsRequired=false)]
		public FileAttachment EmbedFile { get; set; }


		[DataMember(Name = "comments", IsRequired=false)]
		public List<Comment> Comments { get; set; }


		[DataMember(Name = "conversations", IsRequired=false)]
		public List<Conversation> Conversations { get; set; }


		[DataMember(Name = "tasks", IsRequired=false)]
		public List<Task> Tasks { get; set; }


		[DataMember(Name = "shares", IsRequired=false)]
		public List<AppStoreShare> Shares { get; set; }


		[DataMember(Name = "files", IsRequired=false)]
		public List<FileAttachment> Files { get; set; }


		[DataMember(Name = "questions", IsRequired=false)]
		public List<Question> Questions { get; set; }


	}
}

