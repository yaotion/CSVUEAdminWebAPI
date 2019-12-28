using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PriceSystem
{
    /// <summary>
    /// 价格体系Repository接口
    /// </summary>
    public interface IPriceSystemRepository
    {
        /// <summary>
        /// 获取价格体系列表
        /// </summary>
        /// <returns></returns>
        List<PriceSet> GetPriceSetList();
        /// <summary>
        /// 添加价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        void AddPriceSet(PriceSet priceSet);
        /// <summary>
        /// 修改价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        void UpdatePriceSet(PriceSet priceSet);
        /// <summary>
        /// 删除价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        void DeletePriceSet(int priceSetNo);

        /// <summary>
        /// 获取价格策略列表
        /// </summary>
        /// <returns></returns>
        List<PriceContent> GetPriceContentList(int priceSetNo);
        /// <summary>
        /// 清除价格体系内得所有策略
        /// </summary>
        /// <param name="priceSetNo"></param>
        void ClearPriceContent(int priceSetNo);
        /// <summary>
        /// 添加价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        void AddPriceContent(PriceContent priceContent);
        /// <summary>
        /// 修改价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        void UpdatePriceContent(PriceContent priceContent);
        /// <summary>
        /// 删除价格策略
        /// </summary>
        /// <param name="priceContentNo"></param>
        void DeletePriceContent(int priceContentNo);

        /// <summary>
        /// 获取体系内油站列表
        /// </summary>
        /// <returns></returns>
        List<PriceStation> GetPriceStationList(int priceSetNo);
        /// <summary>
        /// 删除体系适用油站
        /// </summary>
        /// <returns></returns>
        void DeletePriceStation(int PriceSetNo, string StationNo);        
        /// <summary>
        /// 添加体系适用油站
        /// </summary>
        /// <returns></returns>
        void AddPriceStation(int PriceSetNo, string StationNo, string StationName);
        /// <summary>
        /// 清除价格体系内得所有站点
        /// </summary>
        /// <param name="priceSetNo"></param>
        void ClearPriceStation(int priceSetNo);

        /// <summary>
        /// 获取策略油品价格信息
        /// </summary>
        /// <returns></returns>
        List<PriceContentOil> GetPriceContentOilList(int priceContentID);        
        /// <summary>
        /// 删除策略内油品
        /// </summary>
        /// <returns></returns>
        void DeletePriceContentOil(int priceContentID, string oilCode);
        /// <summary>
        /// 添加策略内油品信息
        /// </summary>
        /// <returns></returns>
        void AddPriceContentOil(int priceContentID, string oilCode, string oilNamee, decimal newPrice);
        /// <summary>
        /// 清除价格体系内得所有油品
        /// </summary>
        /// <param name="priceSetNo"></param>
        void ClearPriceSetOil(int priceSetNo);
        /// <summary>
        /// 清除价格策略得油品信息
        /// </summary>
        /// <param name="priceContentNo"></param>
        void ClearPirceContentOil(int priceContentNo);
    }

}
