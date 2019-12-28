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

namespace CS.Img.Discount
{
    /// <summary>
    /// 明折明扣信息控制器
    /// </summary>
    public class DiscountController : ApiController
    {
        private DiscountApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new DiscountRepository(context);
            var work = new CSUoWFactory(context);
            var service = new DiscountService(repo);
            return new DiscountApp(service, work);
        }
        /// <summary>
        /// 获取明折明扣活动
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountActDetailListQuery")]
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
        /// 添加明折明扣信息
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountActAdd")]
        [HttpPost]
        public IHttpActionResult AddAct(DiscountAct act)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddAct(act);
            return Ok(resp);
        }
        /// <summary>
        /// 修改明折明扣信息
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountActUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateAct(DiscountAct act)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdateAct(act);
            return Ok(resp);
        }
        /// <summary>
        /// 修改明折明扣信息
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountActDelete")]
        [HttpPost]
        public IHttpActionResult DeleleAct(DiscountAct act)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeleteAct(act.ActID);
            return Ok(resp);
        }


        /// <summary>
        /// 获取明折明扣活动内容
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountContentDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetDiscountContentList(string actID)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            if (string.IsNullOrEmpty(actID))
                actID = "";
            var listData = app.GetDiscountContentList(actID);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 添加明折明扣活动内容信息
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountContentAdd")]
        [HttpPost]
        public IHttpActionResult AddContent(DiscountContent content)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddContent(content);
            return Ok(resp);
        }
        /// <summary>
        /// 修改明折明扣活动内容信息
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountContentUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateContent(DiscountContent content)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdateContent(content);
            return Ok(resp);
        }
        /// <summary>
        /// 添加明折明扣活动内容信息
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountContentDelete")]
        [HttpPost]
        public IHttpActionResult DeleteContent(DiscountContent content)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeleteContent(content.DisID);
            return Ok(resp);
        }
        /// <summary>
        /// 获取明折明扣日志
        /// </summary>
        /// <returns></returns>
        [Route("api/discount/discountLogDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetActLogList(string actID)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            if (string.IsNullOrEmpty(actID))
                actID = "";
            var listData = app.GetActLogList(actID);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        

    }
}

