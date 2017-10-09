using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("UserGroupMapping")]
	public class UserGroupMapping
	{
		#region Model
		[Column("UserId")]
		public Guid? UserId
		{
			set;
			get;
		}

		[Column("GroupId")]
		public Guid? GroupId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "UserId=" + UserId + ",GroupId=" + GroupId;
		}
		#endregion Model
	}
}
