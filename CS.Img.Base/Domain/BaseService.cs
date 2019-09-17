using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Base
{
    public class BaseService : IBaseService
    {
        private readonly IBaseRepository _Repository;

        public BaseService(IBaseRepository repository)
        {
            _Repository = repository;
        }
        public List<Station> GetStationList()
        {
            return _Repository.GetStationList();
        }

        /// <summary>
        /// 获取卡状态列表
        /// </summary>
        /// <returns></returns>
        public List<CardState> GetCardStateList()
        {
            return _Repository.GetCardStateList();
        }
        /// <summary>
        /// 获取散户卡级别列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            return _Repository.GetRetailTypeList();
        }

    }
}
