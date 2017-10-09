using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using UserManagement.Data.Models;
using UserManagement.WebApi.DatabaseContext;
using UserManagement.WebApi.Helper;

namespace UserManagement.WebApi.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    public class UserController : ApiController
    {
        private readonly SqlServerContext _db;
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserController() : this(new SqlServerContext()) { }

        internal UserController(SqlServerContext db)
        {
            _db = db;
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns>用户列表</returns>
        public async Task<HttpResponseMessage> GetUserList()
        {
            HttpResponseMessage response;
            try
            {
                var result = await _db.User.ToListAsync();
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }
            catch (InvalidOperationException ex) when (ex.Message == "Sequence contains no elements")
            {
                response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            return response;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>写入基础数据库的状态项数</returns>
        [HttpPut]
        [AllowAnonymous]
        public async Task<HttpResponseMessage> AddUser(User user)
        {
            HttpResponseMessage response;

            if (!ModelState.IsValid)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(ModelState.ExpendErrors()));
            }
            else
            {
                if (user.CreatedBy == null || user.ModifiedBy == null)
                {
                    user.UserId = Guid.NewGuid();
                    user.CreatedBy = user.UserId;
                    user.ModifiedBy = user.UserId;
                }
                user.Token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user.UserName}:{user.Password}"));
                _db.User.Add(user);
                var result = await _db.SaveChangesAsync();
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }

            return response;
        }

        /// <summary>
        /// 导入用户列表
        /// </summary>
        /// <param name="id">操作人编号</param>
        /// <param name="userList">用户信息列表</param>
        /// <returns>写入基础数据库的状态项数</returns>
        [HttpPut]
        public async Task<HttpResponseMessage> ImportUser(Guid id, IEnumerable<User> userList)
        {
            HttpResponseMessage response;
            var users = userList as User[] ?? userList.ToArray();
            var errors = new List<string>();
            foreach (var user in users)
            {
                user.CreatedBy = id;
                user.ModifiedBy = id;
                if (!ModelState.IsValidField(user.UserName))
                {
                    errors.Add(ModelState.Values.First().Errors.First().ErrorMessage);
                }
                user.Token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user.UserName}:{user.Password}"));
            }
            if (errors.Any())
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(errors));
            }
            else
            {
                _db.User.AddRange(users);
                var result = await _db.SaveChangesAsync();
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }

            return response;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>写入基础数据库的状态项数</returns>
        [HttpPut]
        public async Task<HttpResponseMessage> Update(User user)
        {
            HttpResponseMessage response;
            if (user.UserId == null)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, $"The UserId is required.");
            }
            else if (!ModelState.IsValid)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(ModelState.ExpendErrors()));
            }
            else
            {
                _db.Entry(user).State = EntityState.Modified;
                user.Token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user.UserName}:{user.Password}"));
                var result = await _db.SaveChangesAsync();
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }

            return response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns>写入基础数据库的状态项数</returns>
        public async Task<HttpResponseMessage> Delete(Guid id)
        {
            HttpResponseMessage response;
            var user = await _db.User.SingleAsync(x => x.UserId == id);
            _db.User.Remove(user);
            var result = await _db.SaveChangesAsync();
            response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));

            return response;
        }

        /// <summary>
        /// 用户名密码登陆登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>用户编号</returns>
        [HttpGet, HttpPost]
        [AllowAnonymous]
        public async Task<HttpResponseMessage> Login(string username, string password)
        {
            HttpResponseMessage response;
            try
            {
                var user = await _db.User.SingleAsync(x => x.UserName == username && x.Password == password);
                var result = user.UserId;
                response = Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
                response.Headers.Add("Authorization", "Basic " + user.Token);
            }
            catch (InvalidOperationException ex) when (ex.Message == "Sequence contains no elements")
            {
                response = Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex.Message);
            }

            return response;
        }

        /// <summary>
        /// 令牌登录
        /// </summary>
        /// <returns>用户编号</returns>
        [HttpHead]
        [AllowAnonymous]
        public async Task<HttpResponseMessage> LoginByToken()
        {
            HttpResponseMessage response;
            try
            {
                var authenticationHeader = Request.Headers.Authorization;
                if (authenticationHeader == null || authenticationHeader.Scheme != "Basic")
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid token");
                }
                else
                {
                    var token = authenticationHeader.Parameter;
                    var user = await _db.User.SingleAsync(x => x.Token == token);
                    var result = user.UserId;
                    response = Request.CreateResponse(HttpStatusCode.OK);
                    response.Headers.Add("Authorization", "Basic " + token);
                }
            }
            catch (InvalidOperationException ex) when (ex.Message == "Sequence contains no elements")
            {
                response = Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex.Message);
            }

            return response;
        }
    }
}
