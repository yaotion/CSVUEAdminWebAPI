using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PaywayInfo
{
    /// <summary>
    /// 站点信息Repository实现
    /// </summary>
    public class PaywayInfoRepository : CSRepository, IPaywayInfoRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public PaywayInfoRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取所有支付方式
        /// </summary>
        /// <returns></returns>
        public IList<PaywayInfo> GetPaywayInfoList()
        {
            string strSql = @"select * from pay_way order by CAST(pay_way AS int)";
            string strWhere = "";
           
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
              
            };
            return DBContext.Query<PaywayInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 添加支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        public void AddPaywayInfo(PaywayInfo paywayInfo)
        {
            string strSql = @"insert into pay_way (pay_way,way_name) 
                                values (@Pay_way,@Way_name)";

            var sqlParams = new
            {
                paywayInfo.Pay_way,
                paywayInfo.Way_name
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改支付方式
        /// </summary>
        /// <param name="paywayInfo"></param>
        public void UpdatePaywayInfo(PaywayInfo paywayInfo) {
            string strSql = @"update pay_way set way_name = @Way_name where pay_way = @Pay_way";

            var sqlParams = new
            {
                paywayInfo.Pay_way,
                paywayInfo.Way_name
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除支付方式
        /// </summary>
        /// <param name="payway"></param>
        public void DeletePaywayInfo(string payway) {
            string strSql = @"delete from pay_way where pay_way = @Pay_way";

            var sqlParams = new
            {
                Pay_way = payway
            };
            DBContext.Execute(strSql, sqlParams);
        }
    }
}
