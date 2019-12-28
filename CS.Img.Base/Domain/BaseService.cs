using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Base
{
    public class BaseService : IBaseService
    {
        private readonly IBaseRepository _Repository;

        public BaseService(IBaseRepository repository)
        {
            _Repository = repository;
        }
        public List<Station> GetStationList()
        {
            return _Repository.GetStationList();
        }

        /// <summary>
        /// 获取卡状态列表
        /// </summary>
        /// <returns></returns>
        public List<CardState> GetCardStateList()
        {
            return _Repository.GetCardStateList();
        }
        /// <summary>
        /// 获取散户卡级别列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            return _Repository.GetRetailTypeList();
        }
        /// <summary>
        /// 获取优惠类型列表
        /// </summary>
        /// <returns></returns>
        public List<preType> GetPreIdList()
        {
            return _Repository.GetPreIdList();
        }

        /// <summary>
        /// 获取支付方式列表
        /// </summary>
        /// <returns></returns>
        public List<PayWay> GetPayWayList()
        {
            return _Repository.GetPayWayList();
        }
        /// <summary>
        /// 获取班号
        /// </summary>
        /// <returns></returns>
        public List<ShiftNo> GetShiftNoList(string stationNo, string bussDate)
        {
            return _Repository.GetShiftNoList(stationNo, bussDate);
        }
        /// <summary>
        /// 获取油品信息
        /// </summary>
        /// <returns></returns>
        public List<OilInfo> GetOilInfoList()
        {
            return _Repository.GetOilInfoList();
        }
        /// <summary>
        /// 获取油枪信息
        /// </summary>
        /// <returns></returns>
        public List<TerminalInfo> GetTerminalInfoList(string stationNo)
        {
            return _Repository.GetTerminalInfoList(stationNo);
        }
        /// <summary>
        /// 获取交易类型
        /// </summary>
        /// <returns></returns>
        public List<TradeTypeInfo> GetTradeTypeInfoList()
        {
            return _Repository.GetTradeTypeInfoList();
        }
        /// <summary>
        /// 获取卡类型
        /// </summary>
        /// <returns></returns>
        public List<CardTypeInfo> GetCardTypeInfoList()
        {
            return _Repository.GetCardTypeInfoList();
        }
        /// <summary>
        /// 油站员工信息
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployeeList(string stationNo)
        {
            return _Repository.GetEmployeeList(stationNo);
        }
    }
}
