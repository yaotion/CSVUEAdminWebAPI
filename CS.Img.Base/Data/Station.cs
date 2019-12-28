using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Img.Base
{
    /// <summary>
    /// 油站信息
    /// </summary>
    public class Station
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno = "";
        /// <summary>
        /// 油站名称
        /// </summary>
        public string stationname = "";
    }
    /// <summary>
    /// 卡状态
    /// </summary>
    public class CardState
    {
        /// <summary>
        /// 卡状态编号
        /// </summary>
        public int cardState { get; set; }
        /// <summary>
        /// 卡状态名称
        /// </summary>
        public string cardStateName { get; set; }
    }
    /// <summary>
    /// 散户卡类型
    /// </summary>
    public class RetailType
    {
        /// <summary>
        /// 散户卡类型编号
        /// </summary>
        public int retailTypeID { get; set; }
        /// <summary>
        /// 散户卡类型名称
        /// </summary>
        public string retailTypeName { get; set; }
    }
    /// <summary>
    /// 优惠类型
    /// </summary>
    public class preType
    {
        /// <summary>
        /// 优惠类型编号
        /// </summary>
        public int preId { get; set; }
        /// <summary>
        /// 优惠类型名称
        /// </summary>
        public string preName { get; set; }
        
    }
    /// <summary>
    /// 支付方式
    /// </summary>
    public class PayWay
    {
        /// <summary>
        /// 支付方式编号
        /// </summary>
        public int Pay_Way { get; set; }
        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string Way_Name { get; set; }
    }
    /// <summary>
    /// 班号
    /// </summary>
    public class ShiftNo
    {
        /// <summary>
        /// 班号
        /// </summary>
        public int Shift_No { get; set; }
    }
    /// <summary>
    /// 油品信息
    /// </summary>
    public class OilInfo
    {
        /// <summary>
        /// 油品编号
        /// </summary>
        public string OilCode { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string OilName { get; set; }
    }
    /// <summary>
    /// 油枪信息
    /// </summary>
    public class TerminalInfo
    {
        /// <summary>
        /// 油枪号
        /// </summary>
        public string Terminal { get; set; }
    }
    /// <summary>
    /// 交易类型
    /// </summary>
    public class TradeTypeInfo
    {
        /// <summary>
        /// 交易类型编号
        /// </summary>
        public int TradeType { get; set; }
        /// <summary>
        /// 交易类型名称
        /// </summary>
        public string TradeTypeName { get; set; }
    }
    /// <summary>
    /// 卡类型
    /// </summary>
    public class CardTypeInfo
    {
        /// <summary>
        /// 卡类型
        /// </summary>
        public string CardType { get; set; }
        /// <summary>
        /// 卡类型名称
        /// </summary>
        public string CardTypeName { get; set; }
    }
    /// <summary>
    /// 油站员工信息
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Emp_Name { get; set; }
    }
}
