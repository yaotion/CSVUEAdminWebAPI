using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using CS.Img.Utils;
namespace CS.Img.Station
{
    
    /// <summary>
    /// 用户卡控制类
    /// </summary>
    public class StationController:ApiController
    {
        private StationApp GetStationApp()
        {

            var context = new CSDBContext();
            var repo = new StationRepository(context);
            var work = new CSUoWFactory(context);
            var service = new StationService(repo);
            return new StationApp(service, work);
        }
        /// <summary>
        /// 根据用户token值返回用户信息
        /// </summary>
        /// <returns></returns>
        [Route("api/station/stationTankMonitorQuery")]
        [HttpGet]
        public IHttpActionResult GetUserSaleTrade(string stationNo, string begintime, string endtime,string oilCode)
        {           
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTankStor(begintime, endtime,oilCode, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取油站日报按枪号
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationDayReportByTerminalQuery")]
        [HttpGet]
        public IHttpActionResult GetRptDayByMach(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRptDayByMach(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取油站日报按油品
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationDayReportByOilQuery")]
        [HttpGet]
        public IHttpActionResult GetRptDayByOil(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRptDayByOil(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取油站日报按油罐
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationDayReportByTankQuery")]
        [HttpGet]
        public IHttpActionResult GetRptDayByTank(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRptDayByTank(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 油站日报按加油员加油量
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationDayReportByEmpQty")]
        [HttpGet]
        public IHttpActionResult GetRptDayByEmpQty(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRptDayByEmpQty(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 油站日报按加油员加油金额
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationDayReportByEmpMoney")]
        [HttpGet]
        public IHttpActionResult GetRptDayByEmpMoney(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRptDayByEmpMoney(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取卸油记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        [Route("api/station/stationTankAddQuery")]
        [HttpGet]
        public IHttpActionResult GetOilAddRecord(string beginTime, string endTime, string stationNo, string tankNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetOilAddRecord(beginTime, endTime, stationNo,tankNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取油站的油罐信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationStationTanks")]
        [HttpGet]
        public IHttpActionResult GetStationTanks( string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetStationTanks(stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取油品信息修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationOilChangeQuery")]
        [HttpGet]
        public IHttpActionResult GetOilChangeRecord(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetOilChangeRecord(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取油机信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationMachineQuery")]
        [HttpGet]
        public IHttpActionResult GetMachineRecord(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetMachineRecord(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取油罐信息记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationTankChangeQuery")]
        [HttpGet]
        public IHttpActionResult GetTankRecord(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTankRecord(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取操作员日志
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationOptLogQuery")]
        [HttpGet]
        public IHttpActionResult GetOperLog(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetOperLog(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取操作员日志
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        [Route("api/station/stationTankShiftQuery")]
        [HttpGet]
        public IHttpActionResult GetTankShift(string beginTime, string endTime, string stationNo, string tankNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTankShift(beginTime, endTime, stationNo, tankNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }


        /// <summary>
        /// 获取当班信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationShiftNowQuery")]
        [HttpGet]
        public IHttpActionResult GetTankShift(string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();            
            var listData = app.GetShiftNow(stationNo);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取当班加油明细
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="payWay"></param>
        /// <returns></returns>
        [Route("api/station/stationShiftNowYYLDetailQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeShiftNowDetail(string stationNo,int payWay)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var shift = app.GetShiftNow(stationNo);
            var listData = app.GetTradeShiftNowDetail(shift.Buss_Date,shift.Shift_No,stationNo, payWay);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取当班加油明细
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="payWay"></param>
        /// <returns></returns>
        [Route("api/station/stationShiftNowYYLByOilQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeShiftNowByOil(string stationNo, int payWay)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var shift = app.GetShiftNow(stationNo);
            var listData = app.GetTradeShiftNowByOil(shift.Buss_Date, shift.Shift_No, stationNo, payWay);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 获取当班加油明细
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="payWay"></param>
        /// <returns></returns>
        [Route("api/station/stationShiftNowYYLByTerminalQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeShiftNowByTerminal(string stationNo, int payWay)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var shift = app.GetShiftNow(stationNo);
            var listData = app.GetTradeShiftNowByTerminal(shift.Buss_Date, shift.Shift_No, stationNo, payWay);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 获取油罐报警记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationTankAlarmQuery")]
        [HttpGet]
        public IHttpActionResult GetTankAlarm(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTankAlarm(beginTime, endTime, stationNo);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油明细
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/stationTradeListQuery")]
        [HttpGet]
        public IHttpActionResult GetTrades([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTrades(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油统计按照交易类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/sumTradeByTradeTypeQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumByTradeType([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTradeSumByTradeType(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油统计按照卡号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/sumTradeByCardQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumByCard([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTradeSumByCard(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油统计按照卡类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/sumTradeByCardTypeQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumByCardType([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTradeSumByCardType(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油统计按照员工
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/sumTradeByOptQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumByEmpNo([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTradeSumByEmpNo(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油统计按照油品
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/sumTradeByOilQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumByOil([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTradeSumByOil(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油统计按照枪号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/sumTradeByTerminalQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumByTerminal([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTradeSumByTerminal(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油统计按照结算方式
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        [Route("api/station/sumTradeByPayWayQuery")]
        [HttpGet]
        public IHttpActionResult GetTradeSumByPayWay([FromUri]TradeQuery tradeQuery)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetTradeSumByPayWay(tradeQuery);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询加油站综合日报表
        /// </summary>
        /// <param name="bussDate"></param>
        /// <returns></returns>
        [Route("api/station/stationZHDayReportQuery")]
        [HttpGet]
        public IHttpActionResult GetRptDayOilTank(string bussDate)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetRptDayOilTank(bussDate);
            respData.items = listData;
            respData.total = listData.Count;
            resp.data = respData;
            return Ok(resp);
        }

        /// <summary>
        /// 查询员工卡
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationEmpCardQuery")]
        [HttpGet]
        public IHttpActionResult GetEmpCard(string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetEmpCard(stationNo);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }
        /// <summary>
        /// 查询员工卡对账单
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        [Route("api/station/stationEmpBillQuery")]
        [HttpGet]
        public IHttpActionResult GetEmpCardBill(string beginTime, string endTime, string stationNo)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            var app = GetStationApp();
            var respData = new CSWebAPIListResp();
            var listData = app.GetEmpCardBill(beginTime, endTime,stationNo);
            respData.items = listData;
            respData.total = 1;
            resp.data = respData;
            return Ok(resp);
        }

    }
}
