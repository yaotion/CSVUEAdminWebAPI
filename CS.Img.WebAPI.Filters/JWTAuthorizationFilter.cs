
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using System.Security.Principal;



namespace CS.Img.WebAPI.Filters
{
    /// <summary>
    /// JWT认证过滤器
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class JWTAuthorizationFilterAttribute : AuthorizationFilterAttribute
    {
        /// <summary>
        /// 重写过滤器认证方法
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var attr = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
            bool isAnonymous = attr.Any(a => a is AllowAnonymousAttribute);
            if (!isAnonymous)
            {
                var authorization = actionContext.Request.Headers.Authorization;
                IPrincipal loginPrincipal;
                var result = Utils.TokenManager.ValidateToken(authorization.Parameter,out loginPrincipal);
                if (!result)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                    return;
                }
                if (HttpContext.Current.User != null)
                {
                    HttpContext.Current.User = loginPrincipal;
                }
            }
        }
    }

    
}

