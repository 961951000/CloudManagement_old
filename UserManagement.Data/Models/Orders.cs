using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Orders")]
	public class Orders
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("OrderId", Order = 0)]
		public Guid? OrderId
		{
			set;
			get;
		}

		[Column("UserId")]
		public Guid? UserId
		{
			set;
			get;
		}

		[Column("Status")]
		public int? Status
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

		[Column("TotalPrice")]
		public decimal? TotalPrice
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
			return "OrderId=" + OrderId + ",UserId=" + UserId + ",Status=" + Status + ",Amount=" + Amount + ",TotalPrice=" + TotalPrice + ",CreatedOn=" + CreatedOn;
		}
		#endregion Model
	}
}
