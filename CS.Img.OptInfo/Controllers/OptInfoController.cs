using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using CS.Img.Utils;

namespace CS.Img.OptInfo
{
    /// <summary>
    /// 操作员信息控制器
    /// </summary>
    public class OptInfoController : ApiController
    {
        private OptInfoApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new OptInfoRepository(context);
            var work = new CSUoWFactory(context);
            var service = new OptInfoService(repo);
            return new OptInfoApp(service, work);
        }
        /// <summary>
        /// 获取操作员信息
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/operatorDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetOptInfoList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetOptInfoList();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
       
        /// <summary>
        /// 修改操作员信息
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/operatorUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateOptInfo(OptInfoUpdate optInfo)
        {
            
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            
            app.UpdateOptInfoLogic(optInfo);
            return Ok(resp);
        }
        /// <summary>
        /// 添加操作员信息
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/operatorAdd")]
        [HttpPost]
        public IHttpActionResult AddOptInfo(OptInfo optInfo)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddOptInfo(optInfo);
            return Ok(resp);
        }
        /// <summary>
        /// 添加操作员信息
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/operatorDelete")]
        [HttpPost]
        public IHttpActionResult DeleteOptInfo(OptInfoUpdate optInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeleteOptInfo(optInfo.OptNo);
            return Ok(resp);
        }
        /// <summary>
        /// 添加操作员信息
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/operatorUpdatePassword")]
        [HttpPost]
        public IHttpActionResult UpdateOptPassword(OptInfoResetPWD optInfoResetPWD)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            bool resetResult = app.UpdateOptPassword(optInfoResetPWD);
            if (!resetResult)
            {
                resp.code = 0;
                resp.data = "错误的用户名或密码";
            }
            return Ok(resp);
        }
        /// <summary>
        /// 获取全部功能
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/systemFunctionList")]
        [HttpGet]
        public IHttpActionResult GetSystemFunctionList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetSystemFunctionList();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取操作员的功能
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/optFunctionList")]
        [HttpGet]
        public IHttpActionResult GetOptFunctionList(string optNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetOptFunctionList(optNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 修改操作员信息
        /// </summary>
        /// <returns></returns>
        [Route("api/operator/optFunctionUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateOptFunctionList(OptFuntionList optFuntionList)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();

            app.UpdateOptFunctionList(optFuntionList.OptNo, optFuntionList.FunctionList);
            return Ok(resp);
        }
    }
}

