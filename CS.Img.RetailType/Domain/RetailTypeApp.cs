using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.RetailType
{
    /// <summary>
    /// 散户类型信息App接口实现
    /// </summary>
    public class RetailTypeApp : IRetailTypeApp
    {
        private readonly IRetailTypeService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public RetailTypeApp(IRetailTypeService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }

        /// <summary>
        /// 获取散户类型列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            return _Service.GetRetailTypeList();
        }
        /// <summary>
        /// 添加散户类型
        /// </summary>
        /// <param name="retailType"></param>
        public void AddRetailType(RetailType retailType)
        {
            _Service.AddRetailType(retailType);
        }
        /// <summary>
        /// 修改散户类型
        /// </summary>
        /// <param name="retailType"></param>
        public void UpdateRetailType(RetailType retailType)
        {
            _Service.UpdateRetailType(retailType);
        }
        /// <summary>
        /// 删除散户类型
        /// </summary>
        /// <param name="retailTypeID"></param>
        public void DeleteRetailType(int retailTypeID)
        {
            _Service.DeleteRetailType(retailTypeID);
        }
        /// <summary>
        /// 获取指定散户类型的卡信息
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <returns></returns>
        public List<RetailTypeCard> GetRetailTypeCardList(int retailTypeID)
        {
            return _Service.GetRetailTypeCardList(retailTypeID);
        }
        /// <summary>
        /// 修改散户卡的级别
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <param name="cardNo"></param>
        public void UpdateCardRetailType(int retailTypeID, string cardNo)
        {
            _Service.UpdateCardRetailType(retailTypeID, cardNo);
        }
    }
}
