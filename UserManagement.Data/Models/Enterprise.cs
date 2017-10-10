using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Data.Models
{
    /// <summary>
    /// 企业信息
    /// </summary>
    [Table("Enterprise", Schema = "UserAuthorization")]
    public class Enterprise
    {
        #region Model
        /// <summary>
        /// 企业编号
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), Column("EnterpriseId", Order = 0)]
        public Guid? EnterpriseId
        {
            set;
            get;
        }

        /// <summary>
        /// 企业管理员
        /// </summary>
        [Column("AdministratorId")]
        public Guid? AdministratorId
        {
            set;
            get;
        }

        /// <summary>
        /// 企业名称
        /// </summary>
        [Column("EnterpriseName")]
        public string EnterpriseName
        {
            set;
            get;
        }

        /// <summary>
        /// 统一社会信用码/注册号
        /// </summary>
        [Column("RegistrationNumber")]
        public string RegistrationNumber
        {
            set;
            get;
        }

        /// <summary>
        /// 工商营业执照
        /// </summary>
        [Column("BusinessLicense")]
        public string BusinessLicense
        {
            set;
            get;
        }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        [Column("OrganizationCode")]
        public string OrganizationCode
        {
            set;
            get;
        }

        /// <summary>
        /// 税务登记证
        /// </summary>
        [Column("TaxRegistrationCertificate")]
        public string TaxRegistrationCertificate
        {
            set;
            get;
        }

        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        [Column("LegalRepresentative")]
        public string LegalRepresentative
        {
            set;
            get;
        }

        /// <summary>
        /// 住所
        /// </summary>
        [Column("Address")]
        public string Address
        {
            set;
            get;
        }

        /// <summary>
        /// 注册资本
        /// </summary>
        [Column("RegisteredCapital")]
        public string RegisteredCapital
        {
            set;
            get;
        }

        /// <summary>
        /// 企业状态
        /// </summary>
        [Column("EnterpriseStatus")]
        public int? EnterpriseStatus
        {
            set;
            get;
        }

        /// <summary>
        /// 公司类型
        /// </summary>
        [Column("CompanyType")]
        public int? CompanyType
        {
            set;
            get;
        }

        /// <summary>
        /// 成立日期
        /// </summary>
        [Column("EstablishmentDate")]
        public DateTime? EstablishmentDate
        {
            set;
            get;
        }

        /// <summary>
        /// 营业期限
        /// </summary>
        [Column("BusinessTerm")]
        public string BusinessTerm
        {
            set;
            get;
        }

        /// <summary>
        /// 登记机关
        /// </summary>
        [Column("RegistrationAuthority")]
        public string RegistrationAuthority
        {
            set;
            get;
        }

        /// <summary>
        /// 受理机关
        /// </summary>
        [Column("AcceptingOrgans")]
        public string AcceptingOrgans
        {
            set;
            get;
        }

        /// <summary>
        /// 经营范围
        /// </summary>
        [Column("BusinessScope")]
        public string BusinessScope
        {
            set;
            get;
        }

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("CreatedBy")]
        public Guid? CreatedBy
        {
            set;
            get;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("CreatedOn")]
        public DateTime? CreatedOn
        {
            set;
            get;
        }

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("ModifiedBy")]
        public Guid? ModifiedBy
        {
            set;
            get;
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("ModifiedOn")]
        public DateTime? ModifiedOn
        {
            set;
            get;
        }

        public override string ToString()
        {
            return "EnterpriseId=" + EnterpriseId + ",AdministratorId=" + AdministratorId + ",EnterpriseName=" + EnterpriseName + ",RegistrationNumber=" + RegistrationNumber + ",BusinessLicense=" + BusinessLicense + ",OrganizationCode=" + OrganizationCode + ",TaxRegistrationCertificate=" + TaxRegistrationCertificate + ",LegalRepresentative=" + LegalRepresentative + ",Address=" + Address + ",RegisteredCapital=" + RegisteredCapital + ",EnterpriseStatus=" + EnterpriseStatus + ",CompanyType=" + CompanyType + ",EstablishmentDate=" + EstablishmentDate + ",BusinessTerm=" + BusinessTerm + ",RegistrationAuthority=" + RegistrationAuthority + ",AcceptingOrgans=" + AcceptingOrgans + ",BusinessScope=" + BusinessScope + ",CreatedBy=" + CreatedBy + ",CreatedOn=" + CreatedOn + ",ModifiedBy=" + ModifiedBy + ",ModifiedOn=" + ModifiedOn;
        }
        #endregion Model
    }
}
