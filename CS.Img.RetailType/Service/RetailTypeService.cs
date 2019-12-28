using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.RetailType
{
    /// <summary>
    /// 散户类型信息Service实现
    /// </summary>
    public class RetailTypeService : IRetailTypeService
    {
        private readonly IRetailTypeRepository _Repository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public RetailTypeService(IRetailTypeRepository repository)
        {
            _Repository = repository;
        }
        /// <summary>
        /// 获取散户类型列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            return _Repository.GetRetailTypeList();
        }
        /// <summary>
        /// 添加散户类型
        /// </summary>
        /// <param name="retailType"></param>
        public void AddRetailType(RetailType retailType)
        {
            _Repository.AddRetailType(retailType);
        }
        /// <summary>
        /// 修改散户类型
        /// </summary>
        /// <param name="retailType"></param>
        public void UpdateRetailType(RetailType retailType)
        {
            _Repository.UpdateRetailType(retailType);
        }
        /// <summary>
        /// 删除散户类型
        /// </summary>
        /// <param name="retailTypeID"></param>
        public void DeleteRetailType(int retailTypeID)
        {
            _Repository.DeleteRetailType(retailTypeID);
        }
        /// <summary>
        /// 获取指定散户类型的卡信息
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <returns></returns>
        public List<RetailTypeCard> GetRetailTypeCardList(int retailTypeID)
        {
            return _Repository.GetRetailTypeCardList(retailTypeID);
        }

        /// <summary>
        /// 修改散户卡的级别
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <param name="cardNo"></param>
        public void UpdateCardRetailType(int retailTypeID, string cardNo)
        {
            _Repository.UpdateCardRetailType(retailTypeID, cardNo);
        }
    }
}
