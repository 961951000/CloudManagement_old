using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Products")]
	public class Products
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ProductId", Order = 0)]
		public Guid? ProductId
		{
			set;
			get;
		}

		[Column("ProductSpecificationId")]
		public Guid? ProductSpecificationId
		{
			set;
			get;
		}

		[Column("EnterpriseId")]
		public Guid? EnterpriseId
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

		[Column("Type")]
		public int? Type
		{
			set;
			get;
		}

		[Column("IsShelved")]
		public int? IsShelved
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
			return "ProductId=" + ProductId + ",ProductSpecificationId=" + ProductSpecificationId + ",EnterpriseId=" + EnterpriseId + ",Name=" + Name + ",Type=" + Type + ",IsShelved=" + IsShelved + ",Description=" + Description + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn + ",ModifiedBy=" + ModifiedBy + ",ModifiedOn=" + ModifiedOn;
		}
		#endregion Model
	}
}
