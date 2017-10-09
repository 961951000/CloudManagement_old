using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Role")]
	public class Role
	{
		#region Model
		[Column("RoleId")]
		public Guid? RoleId
		{
			set;
			get;
		}

		[Column("RoleName")]
		public string RoleName
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

		[Column("CreatedBy")]
		public Guid? CreatedBy
		{
			set;
			get;
		}

		[Column("CreatedOn")]
		public DateTime? CreatedOn
		{
			set;
			get;
		}

		[Column("ModifiedBy")]
		public Guid? ModifiedBy
		{
			set;
			get;
		}

		[Column("ModifiedOn")]
		public DateTime? ModifiedOn
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "RoleId=" + RoleId + ",RoleName=" + RoleName + ",Description=" + Description + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn + ",ModifiedBy=" + ModifiedBy + ",ModifiedOn=" + ModifiedOn;
		}
		#endregion Model
	}
}
