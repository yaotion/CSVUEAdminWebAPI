using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.Img.Utils;

namespace CS.Img.Base
{
    public class BaseApp : IBaseApp
    {
        private readonly IBaseService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cardService"></param>
        /// <param name="uoWFactory"></param>
        public BaseApp(IBaseService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <returns></returns>
        public List<Station> GetStationList()
        {
            return _Service.GetStationList();
        }
        /// <summary>
        /// 获取卡状态列表
        /// </summary>
        /// <returns></returns>
        public List<CardState> GetCardStateList()
        {
            return _Service.GetCardStateList();
        }
        /// <summary>
        /// 获取散户卡级别列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            return _Service.GetRetailTypeList();
        }
    }
}
