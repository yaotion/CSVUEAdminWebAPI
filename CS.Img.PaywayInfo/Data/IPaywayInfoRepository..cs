using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PaywayInfo
{
    /// <summary>
    /// 站点信息Repository接口
    /// </summary>
    public interface IPaywayInfoRepository
    {
        /// <summary>
        /// 获取支付方式
        /// </summary>
        /// <returns></returns>
        IList<PaywayInfo> GetPaywayInfoList();

        /// <summary>
        /// 添加支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        void AddPaywayInfo(PaywayInfo paywayInfo);
        /// <summary>
        /// 修改支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        void UpdatePaywayInfo(PaywayInfo paywayInfo);
        /// <summary>
        /// 删除支付方式
        /// </summary>
        /// <param name="payway"></param>
        void DeletePaywayInfo(string payway);
    }
}
