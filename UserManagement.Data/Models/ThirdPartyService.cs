using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
	[Table("ThirdPartyService")]
	public class ThirdPartyService
	{
		#region Model
		[Column("ThirdPartyServiceId")]
		public Guid? ThirdPartyServiceId
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

		[Column("ThirdPartyServiceType")]
		public string ThirdPartyServiceType
		{
			set;
			get;
		}

		[Column("BindToken")]
		public string BindToken
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "ThirdPartyServiceId=" + ThirdPartyServiceId + ",UserId=" + UserId + ",ThirdPartyServiceType=" + ThirdPartyServiceType + ",BindToken=" + BindToken;
		}
		#endregion Model
	}
}
