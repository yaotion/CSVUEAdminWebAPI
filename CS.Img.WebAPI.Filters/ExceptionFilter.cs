using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using Common.Logging;


namespace CS.Img.WebAPI.Filters
{
    /// <summary>
    /// 异常拦截器
    /// </summary>
    public class NotImplExceptionFilterAttribute : ExceptionFilterAttribute
    {
        ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// 重写异常处理函数
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(HttpActionExecutedContext context)
        {
            log.Error("NotImplExceptionFilterAttribute", context.Exception);
            context.Response = new HttpResponseMessage(HttpStatusCode.NotImplemented);
        }
    }
}