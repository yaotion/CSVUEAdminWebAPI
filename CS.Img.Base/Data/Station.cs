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
}
