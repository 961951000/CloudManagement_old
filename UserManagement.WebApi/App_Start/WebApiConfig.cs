#if !DEBUG
using System.Net.Http.Headers;
#endif
using System.Web.Http;
using System.Web.Http.Cors;
using UserManagement.WebApi.Filters.Action;
using UserManagement.WebApi.Filters.Authentication;
using UserManagement.WebApi.Filters.Handler;

namespace UserManagement.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //跨域配置
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

#if !DEBUG
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
#endif
            config.Filters.Add(new IdentityBasicAuthenticationAttribute());
            config.Filters.Add(new ApiExceptionFilterAttribute());
            config.Filters.Add(new ExecutionTimeFilterAttribute());
        }
    }
}
