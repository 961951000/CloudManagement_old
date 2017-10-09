using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("CartItems")]
	public class CartItems
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("CartItemId", Order = 0)]
		public Guid? CartItemId
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

		[Column("ProductId")]
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

		[Column("Amount")]
		public int? Amount
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

		[Column("CreatedOn")]
		public DateTime? CreatedOn
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
			return "CartItemId=" + CartItemId + ",UserId=" + UserId + ",ProductId=" + ProductId + ",ProductSpecificationId=" + ProductSpecificationId + ",Amount=" + Amount + ",Status=" + Status + ",CreatedOn=" + CreatedOn + ",ModifiedOn=" + ModifiedOn;
		}
		#endregion Model
	}
}
