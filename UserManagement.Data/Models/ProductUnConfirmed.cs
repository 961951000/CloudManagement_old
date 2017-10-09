using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("ProductUnConfirmed")]
	public class ProductUnConfirmed
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ProductId", Order = 0)]
		public Guid? ProductId
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

		[Column("Enabled")]
		public int? Enabled
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

		[Column("DescriptionDetail")]
		public string DescriptionDetail
		{
			set;
			get;
		}

		[Column("Price")]
		public decimal? Price
		{
			set;
			get;
		}

		[Column("PriceUnit")]
		public int? PriceUnit
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
			return "ProductId=" + ProductId + ",EnterpriseId=" + EnterpriseId + ",Name=" + Name + ",Type=" + Type + ",Enabled=" + Enabled + ",IsShelved=" + IsShelved + ",Description=" + Description + ",DescriptionDetail=" + DescriptionDetail + ",Price=" + Price + ",PriceUnit=" + PriceUnit + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn;
		}
		#endregion Model
	}
}
