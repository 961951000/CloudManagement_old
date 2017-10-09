using System;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using UserManagement.Data.Models;
using UserManagement.WebApi.DatabaseContext;
using UserManagement.WebApi.Helper;

namespace UserManagement.WebApi.Controllers
{
    /// <summary>
    /// 企业控制器
    /// </summary>
    public class EnterpriseController : ApiController
    {
        private readonly SqlServerContext _db;

        /// <summary>
        /// 构造函数
        /// </summary>
        public EnterpriseController() : this(new SqlServerContext()) { }

        internal EnterpriseController(SqlServerContext db)
        {
            _db = db;
        }

        /// <summary>
        /// 获取企业列表
        /// </summary>
        /// <returns>企业列表</returns>
        public async Task<HttpResponseMessage> GetEnterpriseList()
        {
            HttpResponseMessage response;
            try
            {
                var result = await _db.Enterprise.ToListAsync();
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }
            catch (InvalidOperationException ex) when (ex.Message == "Sequence contains no elements")
            {
                response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            return response;
        }

        /// <summary>
        /// 添加企业
        /// </summary>
        /// <param name="enterprise">企业信息</param>
        /// <returns>写入基础数据库的状态项数</returns>
        [HttpPut]
        public async Task<HttpResponseMessage> AddEnterprise(Enterprise enterprise)
        {
            HttpResponseMessage response;
            if (!ModelState.IsValid)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(ModelState.ExpendErrors()));
            }
            else
            {
                _db.Enterprise.Add(enterprise);
                var result = await _db.SaveChangesAsync();
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }

            return response;
        }

        /// <summary>
        /// 更新企业信息
        /// </summary>
        /// <param name="enterprise">企业信息</param>
        /// <returns>写入基础数据库的状态项数</returns>
        [HttpPut]
        public async Task<HttpResponseMessage> Update(Enterprise enterprise)
        {
            HttpResponseMessage response;
            if (enterprise.EnterpriseId == null)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, $"The EnterpriseId is required.");
            }
            else if (!ModelState.IsValid)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(ModelState.ExpendErrors()));
            }
            else
            {
                _db.Entry(enterprise).State = EntityState.Modified;
                var result = await _db.SaveChangesAsync();
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }

            return response;
        }

        /// <summary>
        /// 删除企业
        /// </summary>
        /// <param name="id">企业编号</param>
        /// <returns>写入基础数据库的状态项数</returns>
        [HttpPut]
        public async Task<HttpResponseMessage> Delete(Guid id)
        {
            var enterprise = await _db.Enterprise.SingleAsync(x => x.EnterpriseId == id);
            _db.Enterprise.Remove(enterprise);
            var result = await _db.SaveChangesAsync();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));

            return response;
        }
    }
}
