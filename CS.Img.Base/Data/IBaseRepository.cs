using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Base
{
    /// <summary>
    /// 基础数据仓储层接口
    /// </summary>
    public  interface IBaseRepository
    {
        /// <summary>
        /// 获取站点信息列表
        /// </summary>
        /// <returns></returns>
         List<Station> GetStationList();
         /// <summary>
         /// 获取卡状态列表
         /// </summary>
         /// <returns></returns>
         List<CardState> GetCardStateList();

         /// <summary>
         /// 获取散户卡级别列表
         /// </summary>
         /// <returns></returns>
         List<RetailType> GetRetailTypeList();

        /// <summary>
        /// 获取优惠类型列表
        /// </summary>
        /// <returns></returns>
        List<preType> GetPreIdList();
        /// <summary>
        /// 获取支付方式列表
        /// </summary>
        /// <returns></returns>
        List<PayWay> GetPayWayList();
        /// <summary>
        /// 获取班号
        /// </summary>
        /// <returns></returns>
        List<ShiftNo> GetShiftNoList(string stationNo, string bussDate);
        /// <summary>
        /// 获取油品信息
        /// </summary>
        /// <returns></returns>
        List<OilInfo> GetOilInfoList();
        /// <summary>
        /// 获取油枪信息
        /// </summary>
        /// <returns></returns>
        List<TerminalInfo> GetTerminalInfoList(string stationNo);
        /// <summary>
        /// 获取交易类型
        /// </summary>
        /// <returns></returns>
        List<TradeTypeInfo> GetTradeTypeInfoList();
        /// <summary>
        /// 获取卡类型
        /// </summary>
        /// <returns></returns>
        List<CardTypeInfo> GetCardTypeInfoList();
        /// <summary>
        /// 油站员工信息
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployeeList(string stationNo);
     


    }


}
