using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Categories")]
	public class Categories
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("CategoryId", Order = 0)]
		public Guid? CategoryId
		{
			set;
			get;
		}

		[Column("Name")]
		public string Name
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
			return "CategoryId=" + CategoryId + ",Name=" + Name + ",Description=" + Description + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn + ",ModifiedBy=" + ModifiedBy + ",ModifiedOn=" + ModifiedOn;
		}
		#endregion Model
	}
}
