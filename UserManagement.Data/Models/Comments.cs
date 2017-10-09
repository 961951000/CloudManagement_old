using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Comments")]
	public class Comments
	{
		#region Model
		[Column("CommentId")]
		public Guid? CommentId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "CommentId=" + CommentId;
		}
		#endregion Model
	}
}
