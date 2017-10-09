using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using UserManagement.Data.Models;

namespace UserManagement.Demo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly string _endpoint = "http://localhost:57506/";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "注册页面";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "登录页面";

            return View();
        }

        public ActionResult UserList()
        {
            ViewBag.Message = "用户列表";
            ViewData["UserList"] = UserListApi().Result;

            return View();
        }

        public async Task RegisterApi(User user)
        {
            const string requestUrl = "api/User/AddUser";

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_endpoint);
                HttpContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync(requestUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var token = response.Headers.GetValues("Authorization").FirstOrDefault();
                    var responseCookie = Response.Cookies["token"];
                    if (responseCookie != null)
                    {
                        responseCookie.Value = token;
                        responseCookie.Expires = DateTime.Now.AddDays(1);
                    }
                    Console.WriteLine(result);
                    Response.Redirect("~/Home/Login");
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                    Response.Redirect("~/Home/Register");
                }
            }
        }

        public async Task LoginApi(string username, string password)
        {
            var requestUrl = $"api/User/Login?username={username}&password={password}";
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_endpoint);

                var response = await httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var token = response.Headers.GetValues("Authorization").FirstOrDefault();
                    var responseCookie = Response.Cookies["token"];
                    if (responseCookie != null)
                    {
                        responseCookie.Value = token;
                        responseCookie.Expires = DateTime.Now.AddDays(1);
                    }
                    Console.WriteLine(result);
                    Response.Redirect("~/Home/UserList");
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                    Response.Redirect("~/Home/Login");
                }
            }
        }

        public async Task<string> UserListApi()
        {
            const string requestUrl = "api/User/GetUserList";

            var cookie = Request.Cookies["token"];
            if (cookie != null)
            {
                using (var httpClient = new HttpClient())
                {
                    var token = Server.HtmlEncode(cookie.Value);
                    httpClient.BaseAddress = new Uri(_endpoint);
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", token);
                    var response = await httpClient.GetAsync(requestUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(result);
                        return result;
                    }
                    Console.WriteLine(response.StatusCode);
                }
            }
            return string.Empty;
        }
    }
}