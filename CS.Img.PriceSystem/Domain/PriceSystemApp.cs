using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PriceSystem
{
    /// <summary>
    /// 散户类型信息App接口实现
    /// </summary>
    public class PriceSystemApp : IPriceSystemApp
    {
        private readonly IPriceSystemService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public PriceSystemApp(IPriceSystemService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }

        /// <summary>
        /// 获取价格体系列表
        /// </summary>
        /// <returns></returns>
        public List<PriceSet> GetPriceSetList()
        {
            return _Service.GetPriceSetList();
        }
        /// <summary>
        /// 添加价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        public void AddPriceSet(PriceSet priceSet)
        {
            _Service.AddPriceSet(priceSet);
        }
        /// <summary>
        /// 修改价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        public void UpdatePriceSet(PriceSet priceSet)
        {
            _Service.UpdatePriceSet(priceSet);
        }
        /// <summary>
        /// 删除价格体系
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void DeletePriceSet(int priceSetNo)
        {
            using (var tran = _uoWFactory.Create())
            {
                _Service.ClearPriceStation(priceSetNo);
                _Service.ClearPriceSetOil(priceSetNo);
                _Service.ClearPriceContent(priceSetNo);
                _Service.DeletePriceSet(priceSetNo);
                tran.SaveChanges();
            }
        }

        /// <summary>
        /// 获取价格策略列表
        /// </summary>
        /// <returns></returns>
        public List<PriceContent> GetPriceContentList(int priceSetNo)
        {
            return _Service.GetPriceContentList(priceSetNo);
        }
        /// <summary>
        /// 清除价格体系内得所有策略
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceContent(int priceSetNo)
        {
            _Service.ClearPriceContent(priceSetNo);
        }
        /// <summary>
        /// 添加价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        public void AddPriceContent(PriceContent priceContent)
        {
            _Service.AddPriceContent(priceContent);
        }
        /// <summary>
        /// 修改价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        public void UpdatePriceContent(PriceContent priceContent)
        {
            _Service.UpdatePriceContent(priceContent);
        }
        /// <summary>
        /// 删除价格策略
        /// </summary>
        /// <param name="priceContentNo"></param>
        public void DeletePriceContent(int priceContentNo)
        {
            using (var tran = _uoWFactory.Create())
            {
                _Service.ClearPirceContentOil(priceContentNo);
                _Service.DeletePriceContent(priceContentNo);
                tran.SaveChanges();
            }
            _Service.DeletePriceContent(priceContentNo);
        }

        /// <summary>
        /// 获取体系内油站列表
        /// </summary>
        /// <returns></returns>
        public List<PriceStation> GetPriceStationList(int priceSetNo)
        {
            return _Service.GetPriceStationList(priceSetNo);
        }
        /// <summary>
        /// 设置体系适用油站
        /// </summary>
        /// <returns></returns>
        public void DeletePriceStation(int PriceSetNo, string StationNo)
        {
            _Service.DeletePriceStation(PriceSetNo, StationNo);
        }
        /// <summary>
        /// 添加体系适用油站
        /// </summary>
        /// <returns></returns>
        public void AddPriceStation(int PriceSetNo, string StationNo, string StationName)
        {
            _Service.AddPriceStation(PriceSetNo, StationNo, StationName);
        }
        /// <summary>
        /// 设置价格体系适用油站
        /// </summary>
        /// <returns></returns>
        public void SetPriceStation(PriceStationSet priceStationSet)
        {
            if (priceStationSet.SetFlag == 0)
                _Service.DeletePriceStation(priceStationSet.PriceSetNo, priceStationSet.StationNo);

            if (priceStationSet.SetFlag == 1)
            { 
                _Service.AddPriceStation(priceStationSet.PriceSetNo, priceStationSet.StationNo,priceStationSet.StationName);                
            }
            
        }
        /// <summary>
        /// 清除价格体系内得所有站点
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceStation(int priceSetNo)
        {
            _Service.ClearPriceStation(priceSetNo);
        }

        /// <summary>
        /// 获取策略油品价格信息
        /// </summary>
        /// <returns></returns>
        public List<PriceContentOil> GetPriceContentOilList(int priceContentID)
        {

            return _Service.GetPriceContentOilList(priceContentID);
        }
        /// <summary>
        /// 删除策略内油品
        /// </summary>
        /// <returns></returns>
        public void DeletePriceContentOil(int priceContentID, string oilCode)
        {
            _Service.DeletePriceContentOil(priceContentID, oilCode);
        }
        /// <summary>
        /// 添加策略内油品信息
        /// </summary>
        /// <returns></returns>
        public void AddPriceContentOil(int priceContentID, string oilCode, string oilName, decimal newPrice)
        {
            _Service.AddPriceContentOil(priceContentID, oilCode, oilName, newPrice);
        }
        /// <summary>
        /// 设置价格体系适用油站
        /// </summary>
        /// <returns></returns>
        public void SetPriceContentOil(PriceContentOilSet priceContentOilSet)
        {
            if (priceContentOilSet.SetFlag == 0)
                _Service.DeletePriceContentOil(priceContentOilSet.PriceSetContent, priceContentOilSet.OilCode);

            if (priceContentOilSet.SetFlag == 1)
            {
                _Service.AddPriceContentOil(priceContentOilSet.PriceSetContent, priceContentOilSet.OilCode, priceContentOilSet.OilName, priceContentOilSet.NewPrice);
            }

        }
        /// <summary>
        /// 清除价格体系内得所有油品
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceSetOil(int priceSetNo)
        {
            _Service.ClearPriceSetOil(priceSetNo);
        }
        /// <summary>
        /// 清除价格策略得油品信息
        /// </summary>
        /// <param name="priceContentNo"></param>
        public void ClearPirceContentOil(int priceContentNo)
        {
            _Service.ClearPirceContentOil(priceContentNo);
        }

    }
}
