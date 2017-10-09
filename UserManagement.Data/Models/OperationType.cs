using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("OperationType")]
	public class OperationType
	{
		#region Model
		[Column("OperationCode")]
		public string OperationCode
		{
			set;
			get;
		}

		[Column("OperationName")]
		public string OperationName
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "OperationCode=" + OperationCode + ",OperationName=" + OperationName;
		}
		#endregion Model
	}
}
