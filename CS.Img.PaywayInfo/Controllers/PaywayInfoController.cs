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

namespace CS.Img.PaywayInfo
{
    /// <summary>
    /// 站点信息控制器
    /// </summary>
    public class PaywayInfoController : ApiController
    {
        private PaywayInfoApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new PaywayInfoRepository(context);
            var work = new CSUoWFactory(context);
            var service = new PaywayInfoService(repo);
            return new PaywayInfoApp(service, work);
        }
        /// <summary>
        /// 获取支付方式信息
        /// </summary>
        /// <returns></returns>
        [Route("api/paywayInfo/payWayDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetPaywayInfoList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetPaywayInfoList();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 添加支付方式
        /// </summary>
        /// <returns></returns>
        [Route("api/paywayInfo/payWayAdd")]
        [HttpPost]
        public IHttpActionResult AddPaywayInfo([FromBody] PaywayInfo paywayInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddPaywayInfo(paywayInfo);
            return Ok(resp);
        }
        /// <summary>
        /// 修改支付方式
        /// </summary>
        /// <returns></returns>
        [Route("api/paywayInfo/payWayUpdate")]
        [HttpPost]
        public IHttpActionResult UpdatePaywayInfo([FromBody] PaywayInfo paywayInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdatePaywayInfo(paywayInfo);
            return Ok(resp);
        }
        /// <summary>
        /// 删除支付方式
        /// </summary>
        /// <returns></returns>
        [Route("api/paywayInfo/payWayDelete")]
        [HttpPost]
        public IHttpActionResult DeletePaywayInfo([FromBody] PaywayInfo paywayInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeletePaywayInfo(paywayInfo.Pay_way);
            return Ok(resp);
        }
    }
}

