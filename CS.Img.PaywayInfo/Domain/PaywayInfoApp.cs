using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PaywayInfo
{
    /// <summary>
    /// 站点信息App接口实现
    /// </summary>
    public class PaywayInfoApp : IPaywayInfoApp
    {
        private readonly IPaywayInfoService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public PaywayInfoApp(IPaywayInfoService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }
        /// <summary>
        /// 获取所有支付方式
        /// </summary>
        /// <returns></returns>
        public IList<PaywayInfo> GetPaywayInfoList()
        {
            return _Service.GetPaywayInfoList();
        }
        /// <summary>
        /// 添加支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        public void AddPaywayInfo(PaywayInfo paywayInfo)
        {
            _Service.AddPaywayInfo(paywayInfo);
        }
        /// <summary>
        /// 修改支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        public void UpdatePaywayInfo(PaywayInfo paywayInfo)
        {
            _Service.UpdatePaywayInfo(paywayInfo);
        }
        /// <summary>
        /// 删除支付方式
        /// </summary>
        /// <param name="payway"></param>
        public void DeletePaywayInfo(string payway)
        {
            _Service.DeletePaywayInfo(payway);
        }
    }
}
