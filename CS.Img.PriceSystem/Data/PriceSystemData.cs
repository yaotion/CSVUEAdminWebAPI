using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PriceSystem
{

    /// <summary>
    /// 价格体系信息
    /// </summary>
    public class PriceSet
    {
        /// <summary>
        /// 体系编号
        /// </summary>
        public int PriceSetNo { get; set; }
        /// <summary>
        /// 体系名称
        /// </summary>
        public string PriceSetName { get; set; }
        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime UseTime { get; set; }
        /// <summary>
        /// 是否生效
        /// </summary>
        public int PriceUse { get; set; }
        /// <summary>
        /// 包含策略数量
        /// </summary>
        public string ContentSum { get; set; }
        /// <summary>
        /// 包含信息数量
        /// </summary>
        public string InfoSum { get; set; }
        /// <summary>
        /// 更新标志
        /// </summary>
        public string IUpdateFlag { get; set; }
    }
    /// <summary>
    /// 价格体系信息
    /// </summary>
    public class PriceContent
    {
        /// <summary>
        /// 策略编号
        /// </summary>
        public int ContentNo { get; set; }
        /// <summary>
        /// 所属体系编号
        /// </summary>
        public int PriceSetNo { get; set; }
        /// <summary>
        /// 策略名称
        /// </summary>
        public string ContentName { get; set; }
        /// <summary>
        /// 策略是否启用
        /// </summary>
        public int ContentUse { get; set; }
        /// <summary>
        /// 策略类型1、不限时间，2限日期区间，3限小时区间
        /// </summary>
        public int ContentType { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartHour { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndHour { get; set; }
        /// <summary>
        /// 每天
        /// </summary>
        public int PerDay { get; set; }
        /// <summary>
        /// 每月
        /// </summary>
        public int PerMonth { get; set; }
        /// <summary>
        /// 更新标志
        /// </summary>
        public int IUpdateFlag { get; set; }

    }

    /// <summary>
    /// 价格体系使用油站
    /// </summary>
    public class PriceStation
    {
        /// <summary>
        /// 所属价格体系
        /// </summary>
        public int PriceSetNo { get; set; }
        /// <summary>
        /// 体系限于油站编号
        /// </summary>
        public int PriceStationNo { get; set; }
        /// <summary>
        /// 油站名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PUBflag { get; set; }
        /// <summary>
        /// 更新标志
        /// </summary>
        public int IUpdateFlag { get; set; }
        
    }
    /// <summary>
    /// 油站设置信息
    /// </summary>
    public class PriceStationSet
    {
        /// <summary>
        /// 所属价格体系
        /// </summary>
        public int PriceSetNo { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油站名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 设置标志，0=取消，1=设置
        /// </summary>
        public int SetFlag { get; set; }
    }
    /// <summary>
    /// 价格策略油品
    /// </summary>
    public class PriceContentOil
    {
        /// <summary>
        /// 记录编号
        /// </summary>
        public int PriceInfoNo { get; set; }
        /// <summary>
        /// 所属策略编号
        /// </summary>
        public int PriceSetContent { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string OilCode { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string OilName { get; set; }
        /// <summary>
        /// 新单价
        /// </summary>
        public decimal NewPrice { get; set; }
        /// <summary>
        /// 老单价
        /// </summary>
        public decimal OldPrice { get; set; }

    }
    /// <summary>
    /// 策略油品设置信息
    /// </summary>
    public class PriceContentOilSet
    {
        /// <summary>
        /// 所属价格体系
        /// </summary>
        public int PriceSetContent { get; set; }
        /// 油品编号
        /// </summary>
        public string OilCode { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string OilName { get; set; }
        /// <summary>
        /// 新单价
        /// </summary>
        public decimal NewPrice { get; set; }
        /// <summary>
        /// 设置标志，0=取消，1=设置
        /// </summary>
        public int SetFlag { get; set; }
    }
}
