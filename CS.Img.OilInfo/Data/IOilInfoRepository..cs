using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OilInfo
{
    /// <summary>
    /// 站点信息Repository接口
    /// </summary>
    public interface IOilInfoRepository
    {
        /// <summary>
        /// 获取常用油品
        /// </summary>
        /// <returns></returns>
        IList<OilInfo> GetOilInfoList();
        /// <summary>
        /// 添加常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        void OilInfoAdd(OilInfo oilInfo);
        /// <summary>
        /// 修改常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        void OilInfoUpdate(OilInfo oilInfo);
        /// <summary>
        /// 删除常用油品
        /// </summary>
        /// <param name="oilCode"></param>
        void OilInfoDelete(string oilCode);
    }
}
