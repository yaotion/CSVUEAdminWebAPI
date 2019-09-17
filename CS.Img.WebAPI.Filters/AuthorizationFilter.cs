using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using Common.Logging;
using System.Security.Principal;
using System.Threading;
using System.Text;

namespace CS.Img.WebAPI.Filters
{
    /// <summary>
    /// 基础认证基类
    /// </summary>
    public class BasicAuthenticationIdentity : GenericIdentity
    {
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public BasicAuthenticationIdentity(string name, string password)
            : base(name, "Basic")
        {
            this.Password = password;
        }
    }
    /// <summary>
    /// 认证过滤器
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class BasicAuthenticationFilter : AuthorizationFilterAttribute
    {
        /// <summary>
        /// Override to Web API filter method to handle Basic Auth check
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var userIdentity = ParseHeader(actionContext);
            if (userIdentity == null)
            {
                Challenge(actionContext);
                return;
            }

            if (!OnAuthorize(userIdentity.Name, userIdentity.Password, actionContext))
            {
                Challenge(actionContext);
                return;
            }

            var principal = new GenericPrincipal(userIdentity, null);

            Thread.CurrentPrincipal = principal;

            base.OnAuthorization(actionContext);
        }
        /// <summary>
        /// 解析头文件
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        public virtual BasicAuthenticationIdentity ParseHeader(HttpActionContext actionContext)
        {
            string authParameter = null;

            var authValue = actionContext.Request.Headers.Authorization;
            if (authValue != null && authValue.Scheme == "Basic")
                authParameter = authValue.Parameter;

            if (string.IsNullOrEmpty(authParameter))

                return null;

            authParameter = Encoding.Default.GetString(Convert.FromBase64String(authParameter));

            var authToken = authParameter.Split(':');
            if (authToken.Length < 2)
                return null;

            return new BasicAuthenticationIdentity(authToken[0], authToken[1]);
        }


        void Challenge(HttpActionContext actionContext)
        {
            var host = actionContext.Request.RequestUri.DnsSafeHost;
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized,"");
            actionContext.Response.Headers.Add("WWW-Authenticate", string.Format("Basic realm=\"{0}\"", host));

        }
        /// <summary>
        /// 重写认证函数
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        public virtual bool OnAuthorize(string userName, string userPassword, HttpActionContext actionContext)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))

                return false;
            else
                return true;

        }
    }
    /// <summary>
    /// 基础认证
    /// </summary>
    public class CustomBasicAuthenticationFilter : BasicAuthenticationFilter
    {
        /// <summary>
        /// 重写认证处理 函数
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        public override bool OnAuthorize(string userName, string userPassword, HttpActionContext actionContext)
        {
            if (userName == "xpy0928" && userPassword == "cnblogs")

                return true;
            else
                return false;

        }
    }
}
