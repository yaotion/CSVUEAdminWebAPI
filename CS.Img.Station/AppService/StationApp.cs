using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.Img.Utils;

namespace CS.Img.Station
{
    /// <summary>
    /// 卡操作应用层
    /// </summary>
    public class StationApp : IStationApp
    {
        private readonly IStationService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cardService"></param>
        /// <param name="uoWFactory"></param>
        public StationApp(IStationService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }
        

        /// <summary>
        /// 获取油罐状态记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="oilCode"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<TankStor> GetTankStor(string beginTime, string endTime, string oilCode, string stationNo)
        {
            return _Service.GetTankStor(beginTime, endTime, oilCode, stationNo);
        }

        /// <summary>
        /// 获取油站日报按枪号
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByMach> GetRptDayByMach(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetRptDayByMach(beginTime, endTime, stationNo);
        }
        /// <summary>
        /// 获取油站日报按油品
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByOil> GetRptDayByOil(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetRptDayByOil(beginTime, endTime, stationNo);
        }

        /// <summary>
        /// 获取油站日报按油罐
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByTank> GetRptDayByTank(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetRptDayByTank(beginTime, endTime, stationNo);
        }

        /// <summary>
        /// 油站日报按加油员加油量
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByEmpQty> GetRptDayByEmpQty(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetRptDayByEmpQty(beginTime, endTime, stationNo);
        }
        /// <summary>
        /// 油站日报按加油员金额
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByEmpMoney> GetRptDayByEmpMoney(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetRptDayByEmpMoney(beginTime, endTime, stationNo);
        }

        /// <summary>
        /// 获取卸油记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        public IList<OilAdd> GetOilAddRecord(string beginTime, string endTime, string stationNo, string tankNo)
        {
            return _Service.GetOilAddRecord(beginTime, endTime, stationNo, tankNo);

        }
        /// <summary>
        /// 获取油站的油罐信息
        /// </summary>
        /// <param name="stationNo"></param>    
        /// <returns></returns>
        public IList<string> GetStationTanks(string stationNo)
        {
            return _Service.GetStationTanks(stationNo);
        }

        /// <summary>
        /// 获取油品信息修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<OilChange> GetOilChangeRecord(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetOilChangeRecord(beginTime, endTime, stationNo);
        }

        /// <summary>
        /// 获取油机信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<Machine> GetMachineRecord(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetMachineRecord(beginTime, endTime, stationNo);
        }
        /// <summary>
        /// 获取油罐信息记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<Tank> GetTankRecord(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetTankRecord(beginTime, endTime, stationNo);
        }

        /// <summary>
        /// 获取操作员日志
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<OperLog> GetOperLog(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetOperLog(beginTime, endTime, stationNo);
        }

        /// <summary>
        /// 获取油罐库存记录(班报)
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        public IList<TankShift> GetTankShift(string beginTime, string endTime, string stationNo, string tankNo)
        {
            return _Service.GetTankShift(beginTime, endTime, stationNo, tankNo);
        }
        /// <summary>
        /// 获取本班加油明细
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        public IList<TradeShiftNowDetail> GetTradeShiftNowDetail(string BussDate, int ShiftNo, string stationNo, int PayWay)
        {
            return _Service.GetTradeShiftNowDetail(BussDate, ShiftNo, stationNo, PayWay);
        }
        /// <summary>
        /// TradeShiftNowByOil
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        public IList<TradeShiftNowByOil> GetTradeShiftNowByOil(string BussDate, int ShiftNo, string stationNo, int PayWay)
        {
            return _Service.GetTradeShiftNowByOil(BussDate, ShiftNo, stationNo, PayWay);
        }
        /// <summary>
        /// 获取本班加油量按油枪统计
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        public IList<TradeShiftNowByTerminal> GetTradeShiftNowByTerminal(string BussDate, int ShiftNo, string stationNo, int PayWay)
        {
            return _Service.GetTradeShiftNowByTerminal(BussDate, ShiftNo, stationNo, PayWay);
        }
        /// <summary>
        /// 获取当班信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public ShiftInfo GetShiftNow(string stationNo)
        {
            return _Service.GetShiftNow(stationNo);
        }
        /// <summary>
        /// 获取油罐报警记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<TankAlarm> GetTankAlarm(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetTankAlarm(beginTime, endTime, stationNo);
        }
        /// <summary>
        /// 查询加油
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<Trade> GetTrades(TradeQuery tradeQuery)
        {
            return _Service.GetTrades(tradeQuery);
        }
        /// <summary>
        /// 查询加油统计按照交易类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByTradeType> GetTradeSumByTradeType(TradeQuery tradeQuery)
        {
            return _Service.GetTradeSumByTradeType(tradeQuery);
        }

        /// <summary>
        /// 查询加油统计按照卡号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByCard> GetTradeSumByCard(TradeQuery tradeQuery)
        {
            return _Service.GetTradeSumByCard(tradeQuery);
        }
        /// <summary>
        /// 查询加油统计按照卡类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByCardType> GetTradeSumByCardType(TradeQuery tradeQuery)
        {
            return _Service.GetTradeSumByCardType(tradeQuery);

        }
        /// <summary>
        /// 查询加油统计按照员工
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByEmpNo> GetTradeSumByEmpNo(TradeQuery tradeQuery)
        {
            return _Service.GetTradeSumByEmpNo(tradeQuery);
        }
        /// <summary>
        /// 查询加油统计按照油品
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByOil> GetTradeSumByOil(TradeQuery tradeQuery)
        {
            return _Service.GetTradeSumByOil(tradeQuery);
        }
        /// <summary>
        /// 查询加油统计按照枪号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByTerminal> GetTradeSumByTerminal(TradeQuery tradeQuery)
        {
            return _Service.GetTradeSumByTerminal(tradeQuery);
        }
        /// <summary>
        /// 查询加油统计按照结算方式
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByPayWay> GetTradeSumByPayWay(TradeQuery tradeQuery)
        {
            return _Service.GetTradeSumByPayWay(tradeQuery);
        }
        /// <summary>
        /// 查询加油站综合日报表
        /// </summary>
        /// <param name="bussDate"></param>
        /// <returns></returns>
        public IList<Rpt_Day_OilTank> GetRptDayOilTank(string bussDate)
        {
            return _Service.GetRptDayOilTank(bussDate);
        }

        /// <summary>
        /// 查询员工卡
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<EmpCard> GetEmpCard(string stationNo)
        {
            return _Service.GetEmpCard(stationNo);
        }
        /// <summary>
        /// 查询员工卡对账单
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<EmpCardBill> GetEmpCardBill(string beginTime, string endTime, string stationNo)
        {
            return _Service.GetEmpCardBill(beginTime, endTime, stationNo);
        }
    }
}
