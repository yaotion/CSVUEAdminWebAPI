using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OilInfo
{
    /// <summary>
    /// 油品信息Service实现
    /// </summary>
    public class OilInfoService : IOilInfoService
    {
        private readonly IOilInfoRepository _Repository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public OilInfoService(IOilInfoRepository repository)
        {
            _Repository = repository;
        }
        /// <summary>
        /// 获取所有油品
        /// </summary>
        /// <returns></returns>
        public IList<OilInfo> GetOilInfoList()
        {
            return _Repository.GetOilInfoList();
        }

        /// <summary>
        /// 添加常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        public void OilInfoAdd(OilInfo oilInfo)
        {
            _Repository.OilInfoAdd(oilInfo);
        }
        /// <summary>
        /// 修改常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        public void OilInfoUpdate(OilInfo oilInfo)
        {
            _Repository.OilInfoUpdate(oilInfo);
        }
        /// <summary>
        /// 删除常用油品
        /// </summary>
        /// <param name="oilCode"></param>
        public void OilInfoDelete(string oilCode)
        {
            _Repository.OilInfoDelete(oilCode);
        }
    }
}
