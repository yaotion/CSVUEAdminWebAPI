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

namespace CS.Img.RetailType
{
    /// <summary>
    /// 储值赠送信息控制器
    /// </summary>
    public class RetailTypeController : ApiController
    {
        private RetailTypeApp GetApp()
        {

            var context = new CSDBContext();
            var repo = new RetailTypeRepository(context);
            var work = new CSUoWFactory(context);
            var service = new RetailTypeService(repo);
            return new RetailTypeApp(service, work);
        }
        /// <summary>
        /// 获取散户类型信息
        /// </summary>
        /// <returns></returns>
        [Route("api/RetailType/retailTypeListQuery")]
        [HttpGet]
        public IHttpActionResult GetRetailTypeList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRetailTypeList();
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 添加散户类型
        /// </summary>
        /// <returns></returns>
        [Route("api/RetailType/retailTypeAdd")]
        [HttpPost]
        public IHttpActionResult AddRetailType(RetailType retailType)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.AddRetailType(retailType);
            return Ok(resp);
        }
        /// <summary>
        /// 修改散户类型
        /// </summary>
        /// <returns></returns>
        [Route("api/RetailType/retailTypeUpdate")]
        [HttpPost]
        public IHttpActionResult UpdateRetailType(RetailType retailType)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.UpdateRetailType(retailType);
            return Ok(resp);
        }
        /// <summary>
        /// 删除散户类型
        /// </summary>
        /// <returns></returns>
        [Route("api/RetailType/retailTypeDelete")]
        [HttpPost]
        public IHttpActionResult DeleteRetailType(RetailType retailType)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            app.DeleteRetailType(retailType.RetailTypeID);
            return Ok(resp);
        }
        /// <summary>
        /// 获取散户类型信息
        /// </summary>
        /// <returns></returns>
        [Route("api/RetailType/retailTypeUserCardListQuery")]
        [HttpGet]
        public IHttpActionResult GetRetailTypeCardList(int retailTypeID)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRetailTypeCardList(retailTypeID);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取散户类型信息
        /// </summary>
        /// <returns></returns>
        [Route("api/RetailType/retailTypeSetUserCard")]
        [HttpPost]
        public IHttpActionResult BatUpdateCardRetailType(UpdateCards updateCards)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetApp();
            var respData = new CSWebAPIListResp();
            foreach (var item in updateCards.CardList)
            {
                app.UpdateCardRetailType(updateCards.RetailTypeID,item.CardNo);
            }           
            return Ok(resp);
        }
    }
}

