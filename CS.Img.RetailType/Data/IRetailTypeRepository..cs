using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.RetailType
{
    /// <summary>
    /// 散户类型信息Repository接口
    /// </summary>
    public interface IRetailTypeRepository
    {
        /// <summary>
        /// 获取散户类型列表
        /// </summary>
        /// <returns></returns>
        List<RetailType> GetRetailTypeList();

        /// <summary>
        /// 添加散户类型
        /// </summary>
        /// <param name="retailType"></param>
        void AddRetailType(RetailType retailType);
        /// <summary>
        /// 修改散户类型
        /// </summary>
        /// <param name="retailType"></param>
        void UpdateRetailType(RetailType retailType);

        /// <summary>
        /// 删除散户类型
        /// </summary>
        /// <param name="retailTypeID"></param>
        void DeleteRetailType(int retailTypeID);
      
        /// <summary>
        /// 获取指定散户类型的卡信息
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <returns></returns>
        List<RetailTypeCard> GetRetailTypeCardList(int retailTypeID);
        /// <summary>
        /// 修改散户卡的级别
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <param name="cardNo"></param>
        void UpdateCardRetailType(int retailTypeID,string cardNo);
    }

    
}
