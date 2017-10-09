using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("OrderDetails")]
	public class OrderDetails
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("OrderDetailId", Order = 0)]
		public Guid? OrderDetailId
		{
			set;
			get;
		}

		[Column("OrderId")]
		public Guid? OrderId
		{
			set;
			get;
		}

		[Column("SpecificationId")]
		public Guid? SpecificationId
		{
			set;
			get;
		}

		[Column("Amount")]
		public int? Amount
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

		public override string ToString()
		{
			return "OrderDetailId=" + OrderDetailId + ",OrderId=" + OrderId + ",SpecificationId=" + SpecificationId + ",Amount=" + Amount + ",Price=" + Price;
		}
		#endregion Model
	}
}
