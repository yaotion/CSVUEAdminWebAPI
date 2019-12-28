using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.RetailType
{
  
    /// <summary>
    /// 散户类型信息
    /// </summary>
    public class RetailType
    {
        /// <summary>
        /// 散户类型编号
        /// </summary>
        public int RetailTypeID { get; set; }
        /// <summary>
        /// 散户类型名称
        /// </summary>
        public string RetailTypeName { get; set; }       
        
    }
    /// <summary>
    /// 卡信息
    /// </summary>
    public class RetailTypeCard
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 散户类型编号
        /// </summary>
        public int RetailTypeID { get; set; }
        /// <summary>
        /// 散户类型名称
        /// </summary>
        public string RetailTypeName { get; set; }
    }


    public class TempCard
    {
        public string CardNo { get; set; }
    }
    public class UpdateCards
    {
        public int RetailTypeID { get; set; }
        public List<TempCard> CardList { get; set; }
    }
}
