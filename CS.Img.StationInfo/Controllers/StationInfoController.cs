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

namespace CS.Img.StationInfo
{
    /// <summary>
    /// 站点信息控制器
    /// </summary>
    public class StationInfoController:ApiController
    {
        private StationInfoApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new StationInfoRepository(context);
            var work = new CSUoWFactory(context);
            var service = new StationInfoService(repo);
            return new StationInfoApp(service, work);
        }
        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/stationInfo/stationDetailListQuery")]
        [HttpGet]
        public IHttpActionResult GetStationInfoList(int stationType, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetStationInfoList(stationType, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 修改油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/stationInfo/stationUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateStationInfo([FromBody]StationInfo stationInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdateStationInfo(stationInfo);
            return Ok(resp);
        }
        /// <summary>
        /// 删除油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/stationInfo/stationDelete")]
        [HttpPost]
        public IHttpActionResult DeleteStationInfo([FromBody]StationInfo stationInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeleteStationInfo(stationInfo.StationNo);
            return Ok(resp);
        }
        /// <summary>
        /// 删除油站信息
        /// </summary>
        /// <returns></returns>
        [Route("api/stationInfo/stationAdd")]
        [HttpPost]
        public IHttpActionResult AddStationInfo([FromBody]StationInfo stationInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddStationInfo(stationInfo);
            return Ok(resp);
        }
        /// <summary>
        /// 初始化占站点
        /// </summary>
        /// <returns></returns>
        [Route("api/stationInfo/stationInit")]
        [HttpPost]
        public IHttpActionResult InitStationInfo([FromBody]StationInfo stationInfo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.InitStationInfo(stationInfo.StationNo);
            return Ok(resp);
        }
    }
}

