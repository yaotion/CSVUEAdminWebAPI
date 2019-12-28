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

namespace CS.Img.OilInfo
{
    /// <summary>
    /// 站点信息控制器
    /// </summary>
    public class OilInfoController : ApiController
    {
        private OilInfoApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new OilInfoRepository(context);
            var work = new CSUoWFactory(context);
            var service = new OilInfoService(repo);
            return new OilInfoApp(service, work);
        }
        /// <summary>
        /// 获取支付方式信息
        /// </summary>
        /// <returns></returns>
        [Route("api/centerOil/centerOilDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetOilInfoList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetOilInfoList();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 添加常用油品
        /// </summary>
        /// <returns></returns>
        [Route("api/centerOil/centerOilAdd")]
        [HttpPost]
        public IHttpActionResult OilInfoAdd([FromBody]OilInfo oilInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            app.OilInfoAdd(oilInfo);           
            return Ok(resp);
        }
        /// <summary>
        /// 修改常用油品
        /// </summary>
        /// <returns></returns>
        [Route("api/centerOil/centerOilUpdate")]
        [HttpPost]
        public IHttpActionResult OilInfoUpdate([FromBody]OilInfo oilInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            app.OilInfoUpdate(oilInfo);
            return Ok(resp);
        }
        /// <summary>
        /// 删除常用油品
        /// </summary>
        /// <returns></returns>
        [Route("api/centerOil/centerOilDelete")]
        [HttpPost]
        public IHttpActionResult OilInfoDelete([FromBody]OilInfo oilInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            app.OilInfoDelete(oilInfo.OilCode);
            return Ok(resp);
        }
    }
}

