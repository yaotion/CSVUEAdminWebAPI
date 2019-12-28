using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OilInfo
{
    /// <summary>
    /// 站点信息App接口实现
    /// </summary>
    public class OilInfoApp : IOilInfoApp
    {
        private readonly IOilInfoService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public OilInfoApp(IOilInfoService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }
        /// <summary>
        /// 获取所有油品
        /// </summary>
        /// <returns></returns>
        public IList<OilInfo> GetOilInfoList()
        {
            return _Service.GetOilInfoList();
        }
        /// <summary>
        /// 添加常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        public void OilInfoAdd(OilInfo oilInfo)
        {
            _Service.OilInfoAdd(oilInfo);
        }
        /// <summary>
        /// 修改常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        public void OilInfoUpdate(OilInfo oilInfo)
        {
            _Service.OilInfoUpdate(oilInfo);
        }
        /// <summary>
        /// 删除常用油品
        /// </summary>
        /// <param name="oilCode"></param>
        public void OilInfoDelete(string oilCode)
        {
            _Service.OilInfoDelete(oilCode);
        }
    }
}
