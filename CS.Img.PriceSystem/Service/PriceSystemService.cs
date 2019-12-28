using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PriceSystem
{
    /// <summary>
    /// 价格体系信息Service实现
    /// </summary>
    public class PriceSystemService : IPriceSystemService
    {
        private readonly IPriceSystemRepository _Repository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public PriceSystemService(IPriceSystemRepository repository)
        {
            _Repository = repository;
        }
        /// <summary>
        /// 获取价格体系列表
        /// </summary>
        /// <returns></returns>
        public List<PriceSet> GetPriceSetList()
        {
            return _Repository.GetPriceSetList();
        }
        /// <summary>
        /// 添加价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        public void AddPriceSet(PriceSet priceSet)
        {
            _Repository.AddPriceSet(priceSet);
        }
        /// <summary>
        /// 修改价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        public void UpdatePriceSet(PriceSet priceSet)
        {
            _Repository.UpdatePriceSet(priceSet);
        }
        /// <summary>
        /// 删除价格体系
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void DeletePriceSet(int priceSetNo)
        {
            _Repository.DeletePriceSet(priceSetNo);
        }

        /// <summary>
        /// 获取价格策略列表
        /// </summary>
        /// <returns></returns>
        public List<PriceContent> GetPriceContentList(int priceSetNo)
        {
            return _Repository.GetPriceContentList(priceSetNo);
        }
        /// <summary>
        /// 清除价格体系内得所有策略
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceContent(int priceSetNo)
        {
            _Repository.ClearPriceContent(priceSetNo);
        }
        /// <summary>
        /// 添加价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        public void AddPriceContent(PriceContent priceContent)
        {
            _Repository.AddPriceContent(priceContent);
        }
        /// <summary>
        /// 修改价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        public void UpdatePriceContent(PriceContent priceContent)
        {
            _Repository.UpdatePriceContent(priceContent);
        }
        /// <summary>
        /// 删除价格策略
        /// </summary>
        /// <param name="priceContentNo"></param>
        public void DeletePriceContent(int priceContentNo)
        {
            _Repository.DeletePriceContent(priceContentNo);
        }

        /// <summary>
        /// 获取体系内油站列表
        /// </summary>
        /// <returns></returns>
        public List<PriceStation> GetPriceStationList(int priceSetNo)
        {
            return _Repository.GetPriceStationList(priceSetNo);
        }
        /// <summary>
        /// 设置体系适用油站
        /// </summary>
        /// <returns></returns>
        public void DeletePriceStation(int PriceSetNo, string StationNo)
        {
            _Repository.DeletePriceStation(PriceSetNo, StationNo);
        }
        /// <summary>
        /// 添加体系适用油站
        /// </summary>
        /// <returns></returns>
        public void AddPriceStation(int PriceSetNo, string StationNo, string StationName)
        {
            _Repository.AddPriceStation(PriceSetNo, StationNo, StationName);
        }
        /// <summary>
        /// 清除价格体系内得所有站点
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceStation(int priceSetNo)
        {
            _Repository.ClearPriceStation(priceSetNo);
        }

        /// <summary>
        /// 获取策略油品价格信息
        /// </summary>
        /// <returns></returns>
        public List<PriceContentOil> GetPriceContentOilList(int priceContentID)
        {

            return _Repository.GetPriceContentOilList(priceContentID);
        }
        /// <summary>
        /// 删除策略内油品
        /// </summary>
        /// <returns></returns>
        public void DeletePriceContentOil(int priceContentID, string oilCode)
        {
            _Repository.DeletePriceContentOil(priceContentID, oilCode);
        }
        /// <summary>
        /// 添加策略内油品信息
        /// </summary>
        /// <returns></returns>
        public void AddPriceContentOil(int priceContentID, string oilCode, string oilName, decimal newPrice)
        {
            _Repository.AddPriceContentOil(priceContentID, oilCode, oilName, newPrice);
        }

        /// <summary>
        /// 清除价格体系内得所有油品
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceSetOil(int priceSetNo)
        {
            _Repository.ClearPriceSetOil(priceSetNo);
        }
        /// <summary>
        /// 清除价格策略得油品信息
        /// </summary>
        /// <param name="priceContentNo"></param>
        public void ClearPirceContentOil(int priceContentNo)
        {
            _Repository.ClearPirceContentOil(priceContentNo);
        }
    }
}
