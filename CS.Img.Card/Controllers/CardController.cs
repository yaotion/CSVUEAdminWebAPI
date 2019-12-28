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
            stationNo = stationNo??"";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
            var resp = new CSHttpWebAPIResp();
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
            stationNo = stationNo ?? "";
            begintime = begintime ?? "";
            endtime = endtime ?? "";
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
            bool found = app.FindUserCardInfo(CardNo, out UserCardInfoDetail cardDetail);

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
        [Route("api/card/cardBillQuery")]
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
                        item.TypeName = CardConst.TradeTypeName[item.T_Type];
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

        /// <summary>
        /// 获取单位账户对账单
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custBillQuery")]
        [HttpGet]
        public IHttpActionResult GetCustBillRecord(string beginTime, string endTime,string AccNo = "")
        {
            if (string.IsNullOrEmpty(beginTime))
            {
                beginTime = "2000-01-01";
            }
            if (string.IsNullOrEmpty(endTime))
            {
                beginTime = "2000-01-01";
            }
            if (string.IsNullOrEmpty(AccNo))
            {
                AccNo= "";
            }
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListSumResp();
            var listData = app.GetCustBillRecord(AccNo, beginTime, endTime);
            var sum = new CustBillSum();
            foreach (var item in listData)
            {
                switch (item.TypeId1)
                {
                    case 1:
                        {
                            sum.SaveMoneys += item.PayAMN;
                            break;
                        }
                    case 2:
                        {
                            sum.PreMoneys += item.PayAMN;
                            break;
                        }
                    case 3:
                        {
                            sum.CorrectMoneys += item.ChangeAMN;
                            break;
                        }
                    case 4:
                        {
                            sum.VirementMoneys += item.ChangeAMN;
                            break;
                        }
                    case 5:
                        {
                            sum.UnVirementMoneys += item.ChangeAMN;
                            break;
                        }
                    case 6:
                        {
                            sum.DepositMoneys += item.DepositAMN;
                            break;
                        }
                    case 7:
                        {
                            sum.ReturnMoneys += item.DepositAMN;
                            break;
                        }
                    case 8:
                    case 11:
                    case 14:
                        {
                            sum.TradeMoneys += item.ConsumeAMN;
                            break;
                        }
                    case 9:
                        {
                            sum.UndepositMoneys += item.DepositAMN;
                            break;
                        }
                    default:
                        break;
                }
            }

            respData.items = listData;
            respData.total = listData.Count;
            respData.sum = sum;
            resp.data = respData;
            return Ok(resp);
        }


        /// <summary>
        /// 获取用户卡消费纪录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardTradeQuery")]
        [HttpGet]
        public IHttpActionResult GetCardTradeRecord(string beginTime, string endTime, string CardNo = "")
        {
            if (string.IsNullOrEmpty(beginTime))
            {
                beginTime = "2000-01-01";
            }
            if (string.IsNullOrEmpty(endTime))
            {
                beginTime = "2000-01-01";
            }
            if (string.IsNullOrEmpty(CardNo))
            {
                CardNo = "";
            }
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardTradeRecord(CardNo, beginTime, endTime);
            foreach (var item in listData)
            {
                item.TradeType = item.OilName;
                if(!(new string[]{"PRE","Deposit","Undeposit","Ungrey","ReturnCard"}.Contains(item.OilName)))
                {
                    item.TradeType = CardConst.TradeTypeName[item.TypeId2];
                }                                
            }
            respData.items = listData;
            respData.total = listData.Count;            
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取用户卡消费纪录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardScoreBillQuery")]
        [HttpGet]
        public IHttpActionResult GetCardScoreRecord(string beginTime, string endTime, string CardNo)
        {
            
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardScoreRecord(CardNo, beginTime, endTime);
            
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 用户卡积分消费记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardScorePayQuery")]
        [HttpGet]
        public IHttpActionResult GetCardScorePayRecord(string beginTime, string endTime, string CardNo,string StationNo)
        {

            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardScorePayRecord(StationNo,CardNo, beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 类型、值合计
        /// </summary>
        public class TypeSum
        {
            public string TypeName { get; set; }
            public string SumValue { get; set; }
        }
        /// <summary>
        /// 获取指定函数的数量
        /// </summary>
        /// <param name="FunList"></param>
        /// <param name="FunctionName"></param>
        /// <returns></returns>
        public int GetFunctionCount(IList<FunctionSum> FunList, string FunctionName)
        {
            var item = FunList.FirstOrDefault(x=>x.FunctionNo.ToUpper() == FunctionName.ToUpper());
            if (item == null)
                return 0;
            return item.FunctionCount;
        }
        /// <summary>
        /// 用户卡积分消费记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardSaleStationSum")]
        [HttpGet]
        public IHttpActionResult GetSaleStationSum(string beginTime, string endTime,string StationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = new List<TypeSum>();
            var functionSum = app.GetOptGroupSum(StationNo, beginTime, endTime);
            listData.Add(new TypeSum() { TypeName = "售卡数量", SumValue = app.GetSaleCardCount(StationNo, beginTime, endTime).ToString() });
            listData.Add(new TypeSum() { TypeName = "挂失数量", SumValue = app.GetLossCardCount(StationNo, beginTime, endTime).ToString() });
            listData.Add(new TypeSum() { TypeName = "开户数量", SumValue = app.GetNewCustomerCount(StationNo, beginTime, endTime).ToString() });
            listData.Add(new TypeSum() { TypeName = "销户数量", SumValue = app.GetDestroyCustomerCount(StationNo, beginTime, endTime).ToString() });
            listData.Add(new TypeSum() { TypeName = "修改卡信息次数", SumValue = GetFunctionCount(functionSum, "Act_modcard").ToString() });
            listData.Add(new TypeSum() { TypeName = "挂失数量", SumValue = GetFunctionCount(functionSum, "Act_unloss").ToString() });
            listData.Add(new TypeSum() { TypeName = "修改卡密码次数", SumValue = GetFunctionCount(functionSum, "Act_changepin").ToString() });
            listData.Add(new TypeSum() { TypeName = "重装卡密码次数", SumValue = GetFunctionCount(functionSum, "Act_reloadpin").ToString() });
            listData.Add(new TypeSum() { TypeName = "重新发卡次数", SumValue = GetFunctionCount(functionSum, "Act_resendcard").ToString() });
            listData.Add(new TypeSum() { TypeName = "解灰次数", SumValue = GetFunctionCount(functionSum, "Act_GreyRecord").ToString() });            
            listData.Add(new TypeSum() { TypeName = "修改客户密码次数", SumValue = GetFunctionCount(functionSum, "Act_custmodifypin").ToString() }); ;
            listData.Add(new TypeSum() { TypeName = "修改客户信息次数", SumValue = GetFunctionCount(functionSum, "Act_custmodify").ToString() }); ;

            listData.Add(new TypeSum() { TypeName = "转账金额", SumValue = app.GetCustChangeMoneySum(StationNo, beginTime, endTime).ToString() });
            listData.Add(new TypeSum() { TypeName = "反转账金额", SumValue = app.GetCustReChangeMoneySum(StationNo, beginTime, endTime).ToString() });
            var userRedepositMoney = app.GetUserReDepositMoneySum(StationNo, beginTime, endTime);
            listData.Add(new TypeSum() { TypeName = "圈提金额", SumValue = userRedepositMoney.ToString() });
            var custSaveMoney = app.GetCustomerSaveMoneySum(StationNo, beginTime, endTime);
            listData.Add(new TypeSum() { TypeName = "单位客户存钱金额", SumValue = custSaveMoney.ToString() });
            var userDepositMoney = app.GetUserDepositMoneySum(StationNo, beginTime, endTime);
            listData.Add(new TypeSum() { TypeName = "散户储值金额", SumValue = userDepositMoney.ToString() });
            var custResaveMoney = app.GetCustomerReSaveMoneySum(StationNo, beginTime, endTime);
            listData.Add(new TypeSum() { TypeName = "冲正金额", SumValue = custResaveMoney.ToString() });
            //散户退卡
            var userReturnMoney = app.GetUserReturnMoneySum(StationNo, beginTime, endTime);
            //单位销户
            var custReturnMoney = app.GetCustReturnMoneySum(StationNo, beginTime, endTime);
            //散户退卡+客户销户
            listData.Add(new TypeSum() { TypeName = "销户退款", SumValue = (userReturnMoney+ custReturnMoney).ToString() });
            //应收款=客户存钱+散户充值-冲正-圈提-散户销户
            var ysk = custSaveMoney + userDepositMoney - custResaveMoney - userRedepositMoney - userReturnMoney;
            listData.Add(new TypeSum() { TypeName = "应收款", SumValue = ysk.ToString() });

            listData.Add(new TypeSum() { TypeName = "退至单位账户金额", SumValue = app.GetCustBackAccMoneySum(StationNo, beginTime, endTime).ToString() });

            var saveGroupSum = app.GetCustSaveGroupMoneySum(StationNo, beginTime, endTime);
            decimal allSave = 0;
            decimal cqSave = 0;
            decimal jzSave = 0;
            foreach (var item in saveGroupSum)
            {
                if (item.GroupName == "1")
                {
                    jzSave += item.SumMoney;
                }
                if (item.GroupName == "0")
                {
                    cqSave += item.SumMoney;
                }
                allSave += item.SumMoney;
            }
            listData.Add(new TypeSum() { TypeName = "存钱客户存钱 A1", SumValue = cqSave.ToString() });
            listData.Add(new TypeSum() { TypeName = "记账客户存钱 A2", SumValue = jzSave.ToString() });
            listData.Add(new TypeSum() { TypeName = "单位客户存钱=A1+A2", SumValue = allSave.ToString() });
            

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

         /// <summary>
        /// 用户卡积分消费记录
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custChangeLimitQuery")]
        [HttpGet]
        public IHttpActionResult GetCustChangeLimitRecord(string beginTime, string endTime, string StationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCustChangeLimitRecord(StationNo,  beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 制卡纪录查询
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("api/card/makelist")]
        [HttpGet]
        public IHttpActionResult GetMarkCardList(string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetMakeCardRecordList( beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
       /// <summary>
       /// 白名单卡查询
       /// </summary>
       /// <param name="stationNo"></param>
       /// <param name="beginTime"></param>
       /// <param name="endTime"></param>
       /// <returns></returns>
        [Route("api/card/cardWhitelistQuery")]
        [HttpGet]
        public IHttpActionResult GetWhiteCardList(string stationNo,string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetWhiteCardList(stationNo,beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取PSAM卡信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("api/card/cardPSAMQuery")]
        [HttpGet]
        public IHttpActionResult GetPSAMCardList( string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetPSAMCardList( beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 油站清算汇总表
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("api/card/cardOilStationSum")]
        [HttpGet]
        public IHttpActionResult GetOilEmpCardSum(string stationNo, string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetOilEmpCardSum(stationNo,beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取油站清存汇总信息
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="preState"></param>
        /// <param name="preId"></param>
        /// <returns></returns>
        [Route("api/card/cardPreQuery")]
        [HttpGet]
        public IHttpActionResult GetCardPreRecord(string cardNo, string beginTime, string endTime, int preState, int preId)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetCardPreRecord(cardNo, beginTime, endTime, preState, preId);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 检索卡号
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        [Route("api/card/cardFuzzySearch")]
        [HttpGet]
        public IHttpActionResult CardSearch(string cardNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.CardSearch(cardNo);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询明折明扣纪录
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("api/card/cardMZMKQuery")]
        [HttpGet]
        public IHttpActionResult GetMZMKRecord(string cardNo, string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetMZMKRecord(cardNo, beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取油站调价记录
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("api/card/cardChangePriceQuery")]
        [HttpGet]
        public IHttpActionResult GetStationChangePriceRecord(string StationNo, string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetStationChangePriceRecord(StationNo, beginTime, endTime);

            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取油站交易传输情况
        /// </summary>   
        /// <returns></returns>
        [Route("api/card/cardStationRecTime")]
        [HttpGet]
        public IHttpActionResult GetCardStationRecTime()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetStationLastTransRecord();

            resp.data = listData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取黑名单列表
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="BlackListTypeID"></param>
        /// <returns></returns>
        [Route("api/card/cardBlackListQuery")]
        [HttpGet]
        public IHttpActionResult GetBlackList(string cardNo, string beginTime, string endTime, int? BlackListTypeID)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();
            int blacktype = (BlackListTypeID == null) ? 0 : BlackListTypeID.Value;
            var listData = app.GetBlackList(cardNo, beginTime, endTime, blacktype);


            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取最新黑名单校验结果
        /// </summary>
        /// <returns></returns>
        [Route("api/card/cardBlackListCheckQuery")]
        [HttpGet]
        public IHttpActionResult GetBlackListCheckList()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListSumResp();
            
            var listData = app.GetBlackListCheckList();
            respData.items = listData;
            respData.total = listData.Count;
            respData.sum = app.GetBlackListVersion();
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取单位的金额统计
        /// </summary>
        /// <returns></returns>
        [Route("api/card/custMoneyQuery")]
        [HttpGet]
        public IHttpActionResult GetCustMoneySum(string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListSumResp();

            var listData = app.GetCustMoneySum(beginTime, endTime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取单位积分统计信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("api/card/custScoreQuery")]
        [HttpGet]
        public IHttpActionResult GetCustScoreSum(string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListSumResp();

            var listData = app.GetCustScoreSum(beginTime, endTime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取卡片出入库记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        ///<param name="StationNo"></param>
        /// <returns></returns>
        [Route("api/card/cardInoutQuery")]
        [HttpGet]
        public IHttpActionResult GetCardInoutRecord(string StationNo, string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListSumResp();

            var listData = app.GetCardInoutRecord(StationNo, beginTime, endTime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取支票接收记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        ///<param name="StationNo"></param>
        /// <returns></returns>
        [Route("api/card/cardChequeQuery")]
        [HttpGet]
        public IHttpActionResult GetChequeReceiveRecord(string StationNo, string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListSumResp();

            var listData = app.GetChequeReceiveRecord(StationNo, beginTime, endTime);
            ChequeSum sum = new ChequeSum();
            foreach (var item in listData)
            {
                if (item.IsEffctiveName == "是")
                    sum.EffectiveCount++;
                if (item.IsEffctiveName == "否")
                    sum.InEffectiveCount++;
                if (item.IsReturnName == "是")
                    sum.ReturnCount++;
                sum.AllCount++;
            }
            respData.items = listData;
            respData.total = listData.Count;
            respData.sum = sum;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取日结信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>

        /// <returns></returns>
        [Route("api/card/GetAllSettle")]
        [HttpGet]
        public IHttpActionResult GetAllSettle(string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();

            var listData = app.GetAllSettle(beginTime, endTime);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }


        /// <summary>
        /// 获取日结合计信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>

        /// <returns></returns>
        [Route("api/card/cardDaySettleSum")]
        [HttpGet]
        public IHttpActionResult GetAllSettleSum(string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();

            var listData = app.GetAllSettleSum(beginTime, endTime);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("api/card/custDeductQuery")]
        [HttpGet]
        public IHttpActionResult GetDeductUpdateLog(string beginTime, string endTime)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();

            var listData = app.GetDeductUpdateLog(beginTime, endTime);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cardNo"></param>
        /// <param name="onlyUnBalance"></param>
        /// <returns></returns>
        [Route("api/card/cardBalanceQuery")]
        [HttpGet]
        public IHttpActionResult GetUserCardBalance(string beginTime, string endTime, string cardNo, int onlyUnBalance)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();

            var listData = app.GetUserCardBalance(beginTime, endTime,cardNo, onlyUnBalance);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/card/reportSaleSectionQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumGroupByPrice(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();

            var listData = app.GetTradeSumGroupByPrice(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取开票纪录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="invoiceType"></param>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        [Route("api/card/cardInvoiceQuery")]
        [HttpGet]
        public IHttpActionResult GetInvoiceTrade(string beginTime, string endTime, string stationNo, int invoiceType, string cardNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetCardApp();
            var respData = new CSWebAPIListResp();

            var listData = app.GetInvoiceTrade(beginTime, endTime, stationNo, invoiceType, cardNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
       
    }
}
