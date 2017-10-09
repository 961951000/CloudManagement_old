using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Posts")]
	public class Posts
	{
		#region Model
		[Column("PosstId")]
		public Guid? PosstId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "PosstId=" + PosstId;
		}
		#endregion Model
	}
}
