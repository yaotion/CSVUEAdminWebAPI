using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Discount
{
  
    /// <summary>
    /// 明折明扣活动信息
    /// </summary>
    public class DiscountAct
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public string ActID { get; set; }
        /// <summary>
        /// 活动姓名
        /// </summary>
        public string ActName { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public DateTime ActStartTime { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public DateTime ActEndTime { get; set; }       
    }
    /// <summary>
    /// 明折明扣活动操作日志信息
    /// </summary>
    public class DiscountActLog
    {
        /// <summary>
        /// 日志编号
        /// </summary>
        public int LogId { get; set; }
        /// <summary>
        /// 日志类型
        /// </summary>
        public int LogType { get; set; }
        /// <summary>
        /// 日志时间
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptID { get; set; }
        /// <summary>
        /// 操作员名称
        /// </summary>
        public string OptName { get; set; }
         /// <summary>
         /// 活动编号
         /// </summary>
        public string ActID { get; set; }
        /// <summary>
        /// 活动姓名
        /// </summary>
        public string ActName { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public string ActStartTime { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string ActEndTime { get; set; }
    }
    /// <summary>
    /// 明折明扣活动内容
    /// </summary>
    public class DiscountContent
    {
        /// <summary>
        /// 活动内容编号 
        /// </summary>
        public string DisID { get; set; }
        /// <summary>
        /// 所属活动编号
        /// </summary>
        public string ActID { get; set; }
        /// <summary>
        /// 限制油站编号 以|分隔符分割 
        /// </summary>
        public string StationID { get; set; }
        /// <summary>
        /// 限制油站名称 以|分隔符分割 
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 优惠对象编号 
        /// </summary>
        public string DisObjectID { get; set; }        
        /// <summary>
        /// 优惠对象名称
        /// </summary>
        public string DisObjectName { get; set; }
        /// <summary>
        /// 优惠对象类型(散户、单位客户、限制积分卡账户)
        /// </summary>
        public int DisObjectType { get; set; }
        /// <summary>
        ///  限制油品编号 以|分隔符分割 
        /// </summary>
        public string OilCode { get; set; }
        /// <summary>
        /// 优惠力度
        /// </summary>
        public decimal DCTMoney { get; set; }
        /// <summary>
        /// 最小升数
        /// </summary>
        public decimal ValidMinVol { get; set; }
    }

}
