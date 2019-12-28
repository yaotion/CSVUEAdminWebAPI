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

namespace CS.Img.Deposit
{
    /// <summary>
    /// 储值赠送信息控制器
    /// </summary>
    public class DepositController : ApiController
    {
        private DepositApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new DepositRepository(context);
            var work = new CSUoWFactory(context);
            var service = new DepositService(repo);
            return new DepositApp(service, work);
        }
        /// <summary>
        /// 获取储值赠送活动
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositActDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetActList(string beginTime, string endTime, string actName)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetActList(beginTime,endTime,actName);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
     
        /// <summary>
        /// 添加储值赠送信息
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositActAdd")]
        [HttpPost]
        public IHttpActionResult AddAct(DepositAct act)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddAct(act);
            return Ok(resp);
        }
        /// <summary>
        /// 修改储值赠送信息
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositActUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateAct(DepositAct act)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdateAct(act);
            return Ok(resp);
        }
        /// <summary>
        /// 删除储值赠送信息
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositActDelete")]
        [HttpPost]
        public IHttpActionResult DeleleAct(DepositAct act)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeleteAct(act.Id);
            return Ok(resp);
        }


        /// <summary>
        /// 获取储值赠送活动内容
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositContentDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetDepositContentList(int actID)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            
            var listData = app.GetDepositContentList(actID);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 添加储值赠送活动内容信息
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositContentAdd")]
        [HttpPost]
        public IHttpActionResult AddContent(DepositContent content)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            
            app.AddContent(content);
            return Ok(resp);
        }
        /// <summary>
        /// 修改储值赠送活动内容信息
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositContentUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateContent(DepositContent content)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdateContent(content);
            return Ok(resp);
        }
        /// <summary>
        /// 添加储值赠送活动内容信息
        /// </summary>
        /// <returns></returns>
        [Route("api/deposit/depositContentDelete")]
        [HttpPost]
        public IHttpActionResult DeleteContent(DepositContent content)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeleteContent(content.Id);
            return Ok(resp);
        }
       
        

    }
}

