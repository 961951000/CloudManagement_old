using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Permission")]
	public class Permission
	{
		#region Model
		[Column("PermissionId")]
		public Guid? PermissionId
		{
			set;
			get;
		}

		[Column("ServiceId")]
		public Guid? ServiceId
		{
			set;
			get;
		}

		[Column("PermissionName")]
		public string PermissionName
		{
			set;
			get;
		}

		[Column("Description")]
		public string Description
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "PermissionId=" + PermissionId + ",ServiceId=" + ServiceId + ",PermissionName=" + PermissionName + ",Description=" + Description;
		}
		#endregion Model
	}
}
