using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("ProductSpecifications")]
	public class ProductSpecifications
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ProductSpecificationId", Order = 0)]
		public Guid? ProductSpecificationId
		{
			set;
			get;
		}

		[Column("ProductId")]
		public Guid? ProductId
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
			return "ProductSpecificationId=" + ProductSpecificationId + ",ProductId=" + ProductId + ",Name=" + Name + ",DescriptionDetail=" + DescriptionDetail + ",Price=" + Price + ",PriceUnit=" + PriceUnit + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn;
		}
		#endregion Model
	}
}
