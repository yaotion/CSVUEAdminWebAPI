using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OilInfo
{
  
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

        /// <summary>
        /// 是否启用
        /// </summary>
        public int OilEnabled { get; set; }

        /// <summary>
        /// 密度
        /// </summary>
        public decimal OilDensity { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal OilPrice { get; set; }

    }
}
