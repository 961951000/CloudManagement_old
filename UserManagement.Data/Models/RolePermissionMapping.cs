using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("RolePermissionMapping")]
	public class RolePermissionMapping
	{
		#region Model
		[Column("RoleId")]
		public Guid? RoleId
		{
			set;
			get;
		}

		[Column("PermissionId")]
		public Guid? PermissionId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "RoleId=" + RoleId + ",PermissionId=" + PermissionId;
		}
		#endregion Model
	}
}
