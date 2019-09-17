using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using CS.Img.Utils;
namespace CS.Img.Card
{
    
    /// <summary>
    /// 用户卡控制类
    /// </summary>
    public class CardController:ApiController
    {
        private CardApp GetCardApp()
        {

            var context = new CSDBContext();
            var repo = new CardRepository(context);
            var work = new CSUoWFactory(context);
            var service = new CardService(repo);
            return new CardApp(service, work);
        }
        /// <summary>
        /// 根据用户token值返回用户信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/userSaleTrade")]
        [HttpGet]
        public IHttpActionResult GetUserSaleTrade(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo==null)?"":stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
        
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetUserSaleTrade(stationNo,begintime,endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 根据用户token值返回用户信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/userRecardTrade")]
        [HttpGet]
        public IHttpActionResult GetUserRecardRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetUserRecardRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 根据用户token值返回用户信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/userLosscardTrade")]
        [HttpGet]
        public IHttpActionResult GetUserLosscardRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetUserLossCardRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取用户卡接挂记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/userUnLosscardTrade")]
        [HttpGet]
        public IHttpActionResult GetUserUnLosscardRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetUserUnLossCardRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取用户卡解灰记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardUngreyLog")]
        [HttpGet]
        public IHttpActionResult GetUserUnGreyCardRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetUserUnGreyCardRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取用户卡储值记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/userDepositTrade")]
        [HttpGet]
        public IHttpActionResult GetUserDepositRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetUserDepositRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }


        /// <summary>
        /// 获取单位客户存钱记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custPayMoneyQuery")]
        [HttpGet]
        public IHttpActionResult GetCustPayMoneyRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCustPayMoneyRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取单位客户划账记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custChangeMoneyQuery")]
        [HttpGet]
        public IHttpActionResult GetCustChangeMoneyRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCustChangeMoneyRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取客户卡储值记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custDepositQuery")]
        [HttpGet]
        public IHttpActionResult GetCustDepositRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCustDepositRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取客户卡储值记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custUnDepositQuery")]
        [HttpGet]
        public IHttpActionResult GetCustUnDepositRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCustUnDepositRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取客户卡储值记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/userUnDepositTrade")]
        [HttpGet]
        public IHttpActionResult GetUserUnDepositRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetUserUnDepositRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取单位开户记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custCreateQuery")]
        [HttpGet]
        public IHttpActionResult GetCustCreateRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCustCreateRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取单位开户记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custDestroyQuery")]
        [HttpGet]
        public IHttpActionResult GetCustDestroyRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCustDestroyRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 卡修改密码纪录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardChangePinQuery")]
        [HttpGet]
        public IHttpActionResult GetChangePinRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetChangePinRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 重装卡密码纪录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardReloadQuery")]
        [HttpGet]
        public IHttpActionResult GetReloadPinRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetReloadPinRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 卡信息修改纪录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardUpdateQuery")]
        [HttpGet]
        public IHttpActionResult GetCardUpdateRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardUpdateRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 退卡记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardReturnQuery")]
        [HttpGet]
        public IHttpActionResult GetCardReturnRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardReturnRecord(stationNo, begintime, endtime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 有卡退卡记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardReturnWCQuery")]
        [HttpGet]
        public IHttpActionResult GetCardReturnWCRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardLossRecord(stationNo, begintime, endtime,1);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 无卡退卡记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardReturnNCQuery")]
        [HttpGet]
        public IHttpActionResult GetCardReturnNCRecord(string stationNo = "", string begintime = "", string endtime = "")
        {
            stationNo = (stationNo == null) ? "" : stationNo;
            begintime = (begintime == null) ? "" : begintime;
            endtime = (endtime == null) ? "" : endtime;
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardLossRecord(stationNo, begintime, endtime,2);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        public class QueryUserCardInput
        {
            public string CardNo;
            public string HolderName;
            public string Mobile;
            public string CerNo;
            public string Car;
            public int RetailType;
            public int CardState;
        }
        
        /// <summary>
        /// 查询用户卡 信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardInfoQuery")]
        [HttpPost]
        public IHttpActionResult QueryUserCardInfo([FromBody]QueryUserCardInput QueryIn)
        {
            var inParams = QueryIn;
            if (inParams ==null)
            {
                inParams = new QueryUserCardInput();
            }

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.QueryUserCardInfo(QueryIn.CardNo,QueryIn.HolderName,QueryIn.Mobile,QueryIn.CerNo,QueryIn.Car,QueryIn.RetailType,QueryIn.CardState);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取用户卡详细信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardInfoFind")]
        [HttpGet]
        public IHttpActionResult QueryUserCardInfo(string CardNo)
        {
     
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            UserCardInfoDetail cardDetail;
            bool found = app.FindUserCardInfo(CardNo, out cardDetail);

            var listData = app.FindUserCardInfo(CardNo, out cardDetail);
            if (found)
            {
                resp.data = cardDetail;
            }
            else { resp.code = 404; }
            return Ok(resp);
        }
        /// <summary>
        /// 获取用户卡详细信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custInfoQuery")]
        [HttpGet]
        public IHttpActionResult GetCustomerTree()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.QueryCustomerInfo("","", "", 0);
            var tree = new List<CustomerInfoTree>();
            var level = 1;
            while (level <= 2)
            {
                foreach (var item in listData)
                {
                    if (item.AccLevel == level)
                    {
                        if (level == 1)
                        {
                            tree.Add(new CustomerInfoTree() { id = item.AccNo.Trim(), label = item.AccName });
                        }
                        else
                        {
                            foreach (var itemSub in tree)
                            {
                                if (itemSub.id == item.FatherAccNo.Trim())
                                {
                                    itemSub.children.Add(new CustomerInfoTree() { id = item.AccNo.Trim(), label = item.AccName });
                                }
                            }
                        }
                    }
                }
                level += 1;
            }

            resp.data = tree;
            return Ok(resp);
        }
        /// <summary>
        /// 获取大内详细信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custInfoFind")]
        [HttpGet]
        public IHttpActionResult FindCustomerInfo(string AccNo)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var customList = app.QueryCustomerInfo(AccNo, "", "", 0);            
            bool found = customList.Count> 0;           
            if (found)
            {
                resp.data = customList[0];
            }
            else { resp.code = 404; }
            return Ok(resp);
        }

        /// <summary>
        /// 获取单位详细信息
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custCardQuery")]
        [HttpGet]
        public IHttpActionResult QueryCustCardInfo(string AccNo)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.QueryCustCardInfo(AccNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        public string[] TradeTypeName = 
        {
            "正常加油",
                                            "逃卡",
                                            "错卡",
                                            "补扣",
                                            "补充",
                                            "上班",
                                            "下班",
                                            "非卡",
                                            "油价接受",
                                            "卡错拒绝"
        };
        public string[] BillTypeNameEn = {
        "PRE","Deposit","Undeposit","Ungrey","ReturnCard","Refund","Return"
                                         };
        public string[] BillTypeNameCn = {
        "优惠","储值","扣款","解灰","退卡","备付金","退钱"
                                         };                
        /// <summary>
        /// 获取用户卡对账单
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custCardQuery")]
        [HttpGet]
        public IHttpActionResult GetCardBillRecord(string CardNo, string beginTime, string endTime)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListSumResp();
            var listData = app.GetCardBillRecord(CardNo,beginTime,endTime);
            var sum = new CardBillSum();
            foreach (var item in listData)
            {
                string strOilName = item.OilName;
                ///非油品,从第六位开始为其商品名称
                /////转换交易类型名称
                if (strOilName.IndexOf("UnOil") == 0)
                {
                    item.TypeName = "非油消费";
                    if (strOilName.Length > 5)
                    {
                        strOilName = strOilName.Substring(6, strOilName.Length - 5);
                    }
                }
                else { 
                    int indexBillType = BillTypeNameEn.ToList().IndexOf(strOilName);
                    if (indexBillType >= 0)
                    {
                        item.TypeName = BillTypeNameCn[indexBillType];
                    }
                    else {
                        item.TypeName = TradeTypeName[item.T_Type];
                    }
                }
                //转换升、金额
                if ((new int[]{3,4}.Contains(item.T_Type)) || ((new string[]{"Ungrey","Return"}.Contains(strOilName))))
                {
                    
                    item.QtyName = "_._";
                    item.AmnName = "_._";
                } else{
                    
                    item.QtyName = item.Qty.ToString();
                    item.AmnName = item.Amn.ToString();
                }
                ////////////转换油品名称///////////
                if (new string[] { "PRE", "Deposit", "Undeposit", "Ungrey", "ReturnCard", "Refund" }.Contains(strOilName))
                {
                    item.OilName = "";
                }
                else {
                    item.OilName = strOilName; 
                }
                //存钱
                if (new string[] { "Save", "Deposit" }.Contains(strOilName))
                {
                    sum.SaveMoneys += item.Amn;
                    //sum3 += ds->FieldByName("AMN")->AsFloat;
                    continue;
                }
                //优惠
                if (new string[] { "PRE" }.Contains(strOilName))
                {
                    sum.PreMoneys += item.Amn;
                    //sum5 += ds->FieldByName("AMN")->AsFloat;
                    continue;
                }
                //优惠
                if (new string[] { "Undeposit" }.Contains(strOilName))
                {
                    sum.DeSaveMoneys += item.Amn;
                    //sum4 += ds->FieldByName("AMN")->AsFloat;
                    continue;
                }
                //非油
                if (strOilName.IndexOf("UnOil") == 0)
                {
                    sum.UnOilMoneys += item.Amn;
                    //sum6 += ds->FieldByName("AMN")->AsFloat;
                    continue;
                }
                //解灰，备付金，退卡
                if (new string[] { "Ungrey", "Refund", "ReturnCard"  }.Contains(strOilName))
                {
                    continue;
                }
                sum.TradeQtys += item.Qty;
                sum.TradeMoneys += item.Amn;
                //交易
                //sum1 += ds->FieldByName("QTY")->AsFloat;
                //sum2 += ds->FieldByName("AMN")->AsFloat;
            }
            respData.items = listData;
            respData.total = listData.Count;
            respData.sum = sum;
            resp.data = respData;
            return Ok(resp);
        }
    }
}
