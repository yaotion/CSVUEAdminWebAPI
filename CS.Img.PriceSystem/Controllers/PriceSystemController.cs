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

namespace CS.Img.PriceSystem
{
    /// <summary>
    /// 价格策略信息控制器
    /// </summary>
    public class PriceSystemController : ApiController
    {
        private PriceSystemApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new PriceSystemRepository(context);
            var work = new CSUoWFactory(context);
            var service = new PriceSystemService(repo);
            return new PriceSystemApp(service, work);
        }
        /// <summary>
        /// 获取价格体系信息
        /// </summary>
        /// <returns></returns>
        [Route("api/priceSet/priceSetListQuery")]
        [HttpGet]
        public IHttpActionResult GetPriceSetList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetPriceSetList();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 添加价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        /// <returns></returns>
        [Route("api/priceSet/priceSetAdd")]
        [HttpPost]
        public IHttpActionResult AddPriceSet(PriceSet priceSet)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddPriceSet(priceSet);
            return Ok(resp);
        }
        /// <summary>
        /// 修改价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        /// <returns></returns>
        [Route("api/priceSet/priceSetUpdate")]
        [HttpPost]
        public IHttpActionResult UpdatePriceSet(PriceSet priceSet)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdatePriceSet(priceSet);
            return Ok(resp);
        }
        /// <summary>
        /// 删除价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        /// <returns></returns>
        [Route("api/priceSet/priceSetDelete")]
        [HttpPost]
        public IHttpActionResult DeletePriceSet(PriceSet priceSet)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeletePriceSet(priceSet.PriceSetNo);
            return Ok(resp);
        }
        /// <summary>
        /// 获取价格策略信息
        /// </summary>
        /// <returns></returns>
        [Route("api/priceSet/priceContentListQuery")]
        [HttpGet]
        public IHttpActionResult GetPriceContentList(int priceSetNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetPriceContentList(priceSetNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 添加价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        /// <returns></returns>
        [Route("api/priceSet/priceContentAdd")]
        [HttpPost]
        public IHttpActionResult AddPriceContent(PriceContent priceContent)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddPriceContent(priceContent);
            return Ok(resp);
        }
        /// <summary>
        /// 修改价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        /// <returns></returns>
        [Route("api/priceSet/priceContentUpdate")]
        [HttpPost]
        public IHttpActionResult UpdatePriceContent(PriceContent priceContent)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdatePriceContent(priceContent);
            return Ok(resp);
        } /// <summary>
          /// 删除价格策略
          /// </summary>
          /// <param name="priceContent"></param>
          /// <returns></returns>
        [Route("api/priceSet/priceContentDelete")]
        [HttpPost]
        public IHttpActionResult DeletePriceContent(PriceContent priceContent)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeletePriceContent(priceContent.ContentNo);
            return Ok(resp);
        }

        /// <summary>
        /// 获取价格体系限制油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/priceSet/priceStationListQuery")]
        [HttpGet]
        public IHttpActionResult GetPriceStationList(int priceSetNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetPriceStationList(priceSetNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 设置价格体系适用油站
        /// </summary>
        /// <returns></returns>
        [Route("api/priceSet/priceStationSetStation")]
        [HttpPost]
        public IHttpActionResult SetPriceStation(PriceStationSet priceStationSet)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.SetPriceStation(priceStationSet);
            return Ok(resp);
        }

        /// <summary>
        /// 获取价格体系限制油品信息
        /// </summary>
        /// <returns></returns>
        [Route("api/priceSet/priceOilListQuery")]
        [HttpGet]
        public IHttpActionResult GetPriceContentOilList(int priceContentNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetPriceContentOilList(priceContentNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 设置价格体系适用油品
        /// </summary>
        /// <returns></returns>
        [Route("api/priceSet/priceContentSetOil")]
        [HttpPost]
        public IHttpActionResult SetPriceContentOil(PriceContentOilSet priceContentOilSet)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.SetPriceContentOil(priceContentOilSet);
            return Ok(resp);
        }
    }
}

