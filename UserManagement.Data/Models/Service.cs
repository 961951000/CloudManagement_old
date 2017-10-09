using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Service")]
	public class Service
	{
		#region Model
		[Column("ServiceId")]
		public Guid? ServiceId
		{
			set;
			get;
		}

		[Column("ServiceName")]
		public string ServiceName
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "ServiceId=" + ServiceId + ",ServiceName=" + ServiceName;
		}
		#endregion Model
	}
}
