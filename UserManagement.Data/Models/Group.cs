using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Group")]
	public class Group
	{
		#region Model
		[Column("GroupId")]
		public Guid? GroupId
		{
			set;
			get;
		}

		[Column("GroupName")]
		public string GroupName
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
			return "GroupId=" + GroupId + ",GroupName=" + GroupName + ",Description=" + Description + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn + ",ModifiedBy=" + ModifiedBy + ",ModifiedOn=" + ModifiedOn;
		}
		#endregion Model
	}
}
