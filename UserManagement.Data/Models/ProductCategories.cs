using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("ProductCategories")]
	public class ProductCategories
	{
		#region Model
		[Column("ProductId")]
		public Guid? ProductId
		{
			set;
			get;
		}

		[Column("CategoryId")]
		public Guid? CategoryId
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

		public override string ToString()
		{
			return "ProductId=" + ProductId + ",CategoryId=" + CategoryId + ",Description=" + Description + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn;
		}
		#endregion Model
	}
}
