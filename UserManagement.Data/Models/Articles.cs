using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Articles")]
	public class Articles
	{
		#region Model
		[Column("ArticleId")]
		public Guid? ArticleId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "ArticleId=" + ArticleId;
		}
		#endregion Model
	}
}
