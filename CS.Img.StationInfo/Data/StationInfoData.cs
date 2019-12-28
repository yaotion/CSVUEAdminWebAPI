using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.StationInfo
{
    /// <summary>
    /// 站点类型
    /// </summary>
    public enum StationType
    {
       /// <summary>
       /// 油站
       /// </summary>
        steOil,
        /// <summary>
        /// 发卡点
        /// </summary>
        steSale
    }
    /// <summary>
    /// 站点基础信息
    /// </summary>
    public class StationInfo
    {
        /// <summary>
        /// 站点编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 注册密码
        /// </summary>
        public string SecCode { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        public string BriefName { get; set; }
        /// <summary>
        /// 站点负责人
        /// </summary>
        public string Master { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string TelNo { get; set; }
       /// <summary>
       /// 税号
       /// </summary>
        public string TaxCode { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public decimal TaxRate { get; set; }
        /// <summary>
        /// 开户行名称
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 开户行账号
        /// </summary>
        public string BankAccNo { get; set; }
        /// <summary>
        /// 油站地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 油站类型
        /// </summary>
        public StationType StationType { get; set; }
        /// <summary>
        /// 油站类型名称
        /// </summary>
        public string StationTypeName {
            get {
                switch (StationType)
                {
                    case StationType.steOil:
                        return "油站";
                    case StationType.steSale:
                        return "发卡点";
                    default:
                        break;
                }
                return "错误的站点类型";
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 最近传输时间
        /// </summary>
        public string LastTransTime { get; set; }
    }
}
