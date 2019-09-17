using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Base
{
    /// <summary>
    /// 基础数据仓储层接口
    /// </summary>
    public  interface IBaseRepository
    {
        /// <summary>
        /// 获取站点信息列表
        /// </summary>
        /// <returns></returns>
         List<Station> GetStationList();
         /// <summary>
         /// 获取卡状态列表
         /// </summary>
         /// <returns></returns>
         List<CardState> GetCardStateList();

         /// <summary>
         /// 获取散户卡级别列表
         /// </summary>
         /// <returns></returns>
         List<RetailType> GetRetailTypeList();
    }
}
