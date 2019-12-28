using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PaywayInfo
{
    /// <summary>
    /// 站点信息Service实现
    /// </summary>
    public class PaywayInfoService : IPaywayInfoService
    {
        private readonly IPaywayInfoRepository _Repository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public PaywayInfoService(IPaywayInfoRepository repository)
        {
            _Repository = repository;
        }
        /// <summary>
        /// 获取所有支付方式
        /// </summary>
        /// <returns></returns>
        public IList<PaywayInfo> GetPaywayInfoList()
        {
            return _Repository.GetPaywayInfoList();
        }
        /// <summary>
        /// 添加支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        public void AddPaywayInfo(PaywayInfo paywayInfo)
        {
            _Repository.AddPaywayInfo(paywayInfo);
        }
        /// <summary>
        /// 修改支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        public void UpdatePaywayInfo(PaywayInfo paywayInfo)
        {
            _Repository.UpdatePaywayInfo(paywayInfo);
        }
        /// <summary>
        /// 删除支付方式
        /// </summary>
        /// <param name="payway"></param>
        public void DeletePaywayInfo(string payway)
        {
            _Repository.DeletePaywayInfo(payway);
        }

    }
}
