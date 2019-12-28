using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.Img.Utils;

namespace CS.Img.Base
{
    public class BaseApp : IBaseApp
    {
        private readonly IBaseService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cardService"></param>
        /// <param name="uoWFactory"></param>
        public BaseApp(IBaseService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <returns></returns>
        public List<Station> GetStationList()
        {
            return _Service.GetStationList();
        }
        /// <summary>
        /// 获取卡状态列表
        /// </summary>
        /// <returns></returns>
        public List<CardState> GetCardStateList()
        {
            return _Service.GetCardStateList();
        }
        /// <summary>
        /// 获取散户卡级别列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            var lst = _Service.GetRetailTypeList();
            lst.Insert(0, new RetailType { retailTypeID = 0, retailTypeName = "普通用户" });
            return lst;
        }

        /// <summary>
        /// 获取优惠类型列表
        /// </summary>
        /// <returns></returns>
        public List<preType> GetPreIdList()
        {
            return _Service.GetPreIdList();
        }
        /// <summary>
        /// 获取支付方式列表
        /// </summary>
        /// <returns></returns>
        public List<PayWay> GetPayWayList()
        {
            return _Service.GetPayWayList();
        }
        /// <summary>
        /// 获取班号
        /// </summary>
        /// <returns></returns>
        public List<ShiftNo> GetShiftNoList(string stationNo, string bussDate)
        {
            return _Service.GetShiftNoList(stationNo, bussDate);
        }
        /// <summary>
        /// 获取油品信息
        /// </summary>
        /// <returns></returns>
        public List<OilInfo> GetOilInfoList()
        {
            return _Service.GetOilInfoList();
        }
        /// <summary>
        /// 获取油枪信息
        /// </summary>
        /// <returns></returns>
        public List<TerminalInfo> GetTerminalInfoList(string stationNo)
        {
            return _Service.GetTerminalInfoList(stationNo);
        }
        /// <summary>
        /// 获取交易类型
        /// </summary>
        /// <returns></returns>
        public List<TradeTypeInfo> GetTradeTypeInfoList()
        {
            return _Service.GetTradeTypeInfoList();
        }

        /// <summary>
        /// 获取卡类型
        /// </summary>
        /// <returns></returns>
        public List<CardTypeInfo> GetCardTypeInfoList()
        {
            return _Service.GetCardTypeInfoList();
        }
        /// <summary>
        /// 油站员工信息
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployeeList(string stationNo)
        {
            return _Service.GetEmployeeList(stationNo);
        }
    }
}
