using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("GroupRoleMapping")]
	public class GroupRoleMapping
	{
		#region Model
		[Column("GroupId")]
		public Guid? GroupId
		{
			set;
			get;
		}

		[Column("RoleId")]
		public Guid? RoleId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "GroupId=" + GroupId + ",RoleId=" + RoleId;
		}
		#endregion Model
	}
}
