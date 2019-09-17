using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using CS.Img.Utils;

namespace CS.Img.Base
{
    /// <summary>
    /// 基础信息控制类
    /// </summary>
    public class BaseController : ApiController
    {
        private BaseApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new BaseRepository(context);
            var work = new CSUoWFactory(context);
            var service = new BaseService(repo);
            return new BaseApp(service, work);
        }
        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/base/stationList")]
        [HttpGet]        
        public IHttpActionResult GetStationList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();


            var app = GetApp();

            var listData = app.GetStationList();
            var respData = new CSWebAPIListResp();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;  
            return Ok(resp);
        }
        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/base/cardStateListQuery")]
        [HttpGet]
        public IHttpActionResult GetCardStateList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();


            var app = GetApp();

            var listData = app.GetCardStateList();
            var respData = new CSWebAPIListResp();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取油站复杂列表信息
        /// </summary>
        /// <returns></returns>
        [Route("api/base/cardStateCompListQuery")]
        [HttpGet]
        public IHttpActionResult GetCardStateCompList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();


            var app = GetApp();

            var listData = app.GetCardStateList();
            var sumState = new List<CardState>();
            sumState.Add(new CardState { cardState = 100, cardStateName = "未发售" });
            sumState.Add(new CardState { cardState = 101, cardStateName = "已发售" });

            var compState = new[]{
                 new {sortID = 1,sortName="组合状态",sortData = sumState},
                 new {sortID = 2,sortName="详细状态",sortData = listData},
            };
            var respData = new CSWebAPIListResp();
            respData.items = compState;
            respData.total = compState.Length;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/base/retailTypeListQuery")]
        [HttpGet]
        public IHttpActionResult GetRetailTypeList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();


            var app = GetApp();

            var listData = app.GetRetailTypeList();
            var respData = new CSWebAPIListResp();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
    }
}
