using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Station
{
    /// <summary>
    /// 油站数据仓储操作接口
    /// </summary>
    public interface IStationRepository
    {

        /// <summary>
        /// 获取油油罐状态
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="oilCode"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<TankStor> GetTankStor(string beginTime, string endTime, string oilCode, string stationNo);
        /// <summary>
        /// 获取油站日报按枪号
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<RptDayByMach> GetRptDayByMach(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 获取油站日报按油品
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<RptDayByOil> GetRptDayByOil(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 获取油站日报按油罐
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<RptDayByTank> GetRptDayByTank(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 油站日报按加油员加油量
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<RptDayByEmpQty> GetRptDayByEmpQty(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 油站日报按加油员金额
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<RptDayByEmpMoney> GetRptDayByEmpMoney(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 获取卸油记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        IList<OilAdd> GetOilAddRecord(string beginTime, string endTime, string stationNo, string tankNo);

        /// <summary>
        /// 获取油站的油罐信息
        /// </summary>
        /// <param name="stationNo"></param>    
        /// <returns></returns>
        IList<string> GetStationTanks(string stationNo);


        /// <summary>
        /// 获取油品信息修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<OilChange> GetOilChangeRecord(string beginTime, string endTime, string stationNo);


        /// <summary>
        /// 获取油机信息记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<Machine> GetMachineRecord(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 获取油罐信息记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<Tank> GetTankRecord(string beginTime, string endTime, string stationNo);
        /// <summary>
        /// 获取操作员日志
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<OperLog> GetOperLog(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 获取油罐库存记录(班报)
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        IList<TankShift> GetTankShift(string beginTime, string endTime, string stationNo,string tankNo);

        /// <summary>
        /// 获取本班加油明细
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        IList<TradeShiftNowDetail> GetTradeShiftNowDetail(string BussDate, int ShiftNo, string stationNo, int PayWay);
        /// <summary>
        /// 获取本班加油量按油品统计
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        IList<TradeShiftNowByOil> GetTradeShiftNowByOil(string BussDate, int ShiftNo, string stationNo, int PayWay);
        /// <summary>
        /// 获取本班加油量按油枪统计
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        IList<TradeShiftNowByTerminal> GetTradeShiftNowByTerminal(string BussDate, int ShiftNo, string stationNo, int PayWay);
        /// <summary>
        /// 获取当前班信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        ShiftInfo GetShiftNow(string stationNo);

        /// <summary>
        /// 获取油罐报警记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<TankAlarm> GetTankAlarm(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 查询加油
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<Trade> GetTrades(TradeQuery tradeQuery);
        /// <summary>
        /// 查询加油统计按照交易类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<TradeSumByTradeType> GetTradeSumByTradeType(TradeQuery tradeQuery);

        /// <summary>
        /// 查询加油统计按照卡号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<TradeSumByCard> GetTradeSumByCard(TradeQuery tradeQuery);
        /// <summary>
        /// 查询加油统计按照卡类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<TradeSumByCardType> GetTradeSumByCardType(TradeQuery tradeQuery);
        /// <summary>
        /// 查询加油统计按照员工
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<TradeSumByEmpNo> GetTradeSumByEmpNo(TradeQuery tradeQuery);
        /// <summary>
        /// 查询加油统计按照油品
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<TradeSumByOil> GetTradeSumByOil(TradeQuery tradeQuery);
        /// <summary>
        /// 查询加油统计按照枪号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<TradeSumByTerminal> GetTradeSumByTerminal(TradeQuery tradeQuery);
        /// <summary>
        /// 查询加油统计按照结算方式
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        IList<TradeSumByPayWay> GetTradeSumByPayWay(TradeQuery tradeQuery);
        /// <summary>
        /// 查询加油站综合日报表
        /// </summary>
        /// <param name="bussDate"></param>
        /// <returns></returns>
        IList<Rpt_Day_OilTank> GetRptDayOilTank(string bussDate);
        /// <summary>
        /// 查询员工卡
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<EmpCard> GetEmpCard(string stationNo);

        /// <summary>
        /// 查询员工卡对账单
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<EmpCardBill> GetEmpCardBill(string beginTime, string endTime, string stationNo);
        
    }
}
