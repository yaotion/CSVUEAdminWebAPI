using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Common.Logging;
namespace CS.Img.WebAPI.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public class ActionMonitorAttribute : ActionFilterAttribute
    {
        ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>        
        /// 全局请求ID号       
        /// </summary>       
        private static Int64 ActionId { get; set; }
        /// <summary>
        /// 客户端IP地址  
        /// </summary>
        private String ClientIp { get; set; }
        /// <summary>      
        /// 请求ID号        
        /// </summary>       
        private Int64 RequestId { get; set; }
        /// <summary>       
        ///请求的接口       
        /// </summary>     
        private String controllername { get; set; }
        /// <summary>       
        /// 请求处理前       
        /// </summary>        
        /// <param name="actionContext"></param>    
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            RequestId = ActionId++;
            var strary = actionContext.Request.RequestUri.AbsolutePath.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            controllername = strary[1];
            dynamic RemoteEndpoint = null;
            if (actionContext.Request.Properties.TryGetValue("System.ServiceModel.Channels.RemoteEndpointMessageProperty", out RemoteEndpoint))
            {
                ClientIp = RemoteEndpoint.Address;
                if (ClientIp == "::1")
                { ClientIp = "localhost"; }
            }
            String Message = String.Format("[Requestd].[{1}].[{4}].[{0}].[{2}]=>{3}",
               RequestId, ClientIp, actionContext.Request.Method, actionContext.Request.RequestUri, controllername);
            log.Info(Message);
            base.OnActionExecuting(actionContext);
        }
        // <summary>        
        /// 请求返回前        
        /// <param name="actionExecutedContext"></param>     
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception == null)
            {
                log.Info(String.Format("[Response].[{0}].[{3}].[{1}].[{2}]", ClientIp, RequestId, actionExecutedContext.Response.ReasonPhrase, controllername));
                if (log.IsDebugEnabled)
                {
                    log.Debug(String.Format("    [Data]\t{0}\t{1}", RequestId, actionExecutedContext.Response.Content.ReadAsStringAsync().Result));
                }
            }
            else
            {
                log.Info(String.Format("[Response].[{0}].[{3}].[{1}].[{2}]", ClientIp, RequestId, "Exception", controllername));
                log.Info(String.Format("[WebApiRequest].[Exception].[{0}].[{1}]\r\n{2}", RequestId, actionExecutedContext.Request.RequestUri, actionExecutedContext.Exception.StackTrace));
            }
            base.OnActionExecuted(actionExecutedContext);
        }
    }

}

