using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Deposit
{
  
    /// <summary>
    /// 储值赠送活动信息
    /// </summary>
    public class DepositAct
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActName { get; set; }
        /// <summary>
        /// 启用标志 0:启用，!=0禁用
        /// </summary>
        public string Flag { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTm { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTm { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createtime { get; set; }
        
    }

    /// <summary>
    /// 储值赠送活动内容
    /// </summary>
    public class DepositContent
    {
        /// <summary>
        /// 活动内容编号
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        /// 所属活动编号
        /// </summary>
        public int ActID { get; set; }
        /// <summary>
        /// 最小金额
        /// </summary>
        public decimal DepositMin { get; set; }
        /// <summary>
        /// 最大金额
        /// </summary>
        public decimal DepositMax { get; set; }
        /// <summary>
        /// 优惠金额，比例时为小数
        /// </summary>
        public decimal DepositBonus { get; set; }
        /// <summary>
        /// 优惠类型，1未按比例，0为固定金额
        /// </summary>
        public int BonusType { get; set; }
        /// <summary>
        /// 优惠对象:单位编号，散户时为0000
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 散户类型名称
        /// </summary>
        public string RetailTypeName { get; set; }
        /// <summary>
        /// 标志1为启用，0位禁用
        /// </summary>
        public int Flag { get; set; }
        /// <summary>
        /// 优惠对象：散户类型
        /// </summary>
        public int RetailTypeID { get; set; }
        /// <summary>
        ///  限制油品编号 以|分隔符分割 
        /// </summary>
        public string OilCode { get; set; }
        /// <summary>
        /// 限制油站编号 以|分隔符分割 
        /// </summary>
        public string StationLst { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

    }

}
