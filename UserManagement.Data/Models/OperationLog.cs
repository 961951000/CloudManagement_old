using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("OperationLog")]
	public class OperationLog
	{
		#region Model
		[Column("OperationLogId")]
		public Guid? OperationLogId
		{
			set;
			get;
		}

		[Column("OperationCode")]
		public string OperationCode
		{
			set;
			get;
		}

		[Column("Context")]
		public string Context
		{
			set;
			get;
		}

		[Column("UserId")]
		public int? UserId
		{
			set;
			get;
		}

		[Column("CreateTime")]
		public DateTime? CreateTime
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "OperationLogId=" + OperationLogId + ",OperationCode=" + OperationCode + ",Context=" + Context + ",UserId=" + UserId + ",CreateTime=" + CreateTime;
		}
		#endregion Model
	}
}
