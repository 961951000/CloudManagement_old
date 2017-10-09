using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("Plates")]
	public class Plates
	{
		#region Model
		[Column("PlateId")]
		public Guid? PlateId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "PlateId=" + PlateId;
		}
		#endregion Model
	}
}
