using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("AuditRequest")]
	public class AuditRequest
	{
		#region Model
		[Column("AuditRequestId")]
		public Guid? AuditRequestId
		{
			set;
			get;
		}

		[Column("RequestType")]
		public int? RequestType
		{
			set;
			get;
		}

		[Column("RequestUserId")]
		public Guid? RequestUserId
		{
			set;
			get;
		}

		[Column("CreationTime")]
		public DateTime? CreationTime
		{
			set;
			get;
		}

		[Column("AuditUserId")]
		public Guid? AuditUserId
		{
			set;
			get;
		}

		[Column("AuditTime")]
		public DateTime? AuditTime
		{
			set;
			get;
		}

		[Column("AuditRequestComment")]
		public string AuditRequestComment
		{
			set;
			get;
		}

		[Column("AuditResultComment")]
		public string AuditResultComment
		{
			set;
			get;
		}

		[Column("AuditStatus")]
		public int? AuditStatus
		{
			set;
			get;
		}

		[Column("Action")]
		public int? Action
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "AuditRequestId=" + AuditRequestId + ",RequestType=" + RequestType + ",RequestUserId=" + RequestUserId + ",CreationTime=" + CreationTime + ",AuditUserId=" + AuditUserId + ",AuditTime=" + AuditTime + ",AuditRequestComment=" + AuditRequestComment + ",AuditResultComment=" + AuditResultComment + ",AuditStatus=" + AuditStatus + ",Action=" + Action;
		}
		#endregion Model
	}
}
