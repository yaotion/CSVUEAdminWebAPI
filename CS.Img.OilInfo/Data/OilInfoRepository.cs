using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OilInfo
{
    /// <summary>
    /// 站点信息Repository实现
    /// </summary>
    public class OilInfoRepository : CSRepository, IOilInfoRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public OilInfoRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取所有支付方式
        /// </summary>
        /// <returns></returns>
        public IList<OilInfo> GetOilInfoList()
        {
            string strSql = @"select oAll.OilCode,oAll.OilName,
                                case when o.OilPrice is null then 0 else 1 end OilEnabled,
                                o.OilDensity,o.OilPrice from OilList oAll left join OilInfo o on 
                                oAll.OilCode = o.OilCode order by OilEnabled desc,oAll.OilCode";
            string strWhere = "";
           
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
              
            };
            return DBContext.Query<OilInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 添加常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        public void OilInfoAdd(OilInfo oilInfo)
        {
            string strSql = @"insert into OilInfo (OilCode,OilName,OilPrice,OilDensity) 
                                values (@OilCode,@OilName,@OilPrice,@OilDensity)";

            var sqlParams = new
            {
                oilInfo.OilCode,
                oilInfo.OilName,
                oilInfo.OilPrice,
                oilInfo.OilDensity
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改常用油品
        /// </summary>
        /// <param name="oilInfo"></param>
        public void OilInfoUpdate(OilInfo oilInfo)
        {
            string strSql = @"update OilInfo set OilPrice=@OilPrice,OilDensity=@OilDensity where OilCode=@OilCode";
                                ;

            var sqlParams = new
            {
                oilInfo.OilCode,
                oilInfo.OilName,
                oilInfo.OilPrice,
                oilInfo.OilDensity
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除常用油品
        /// </summary>
        /// <param name="oilCode"></param>
        public void OilInfoDelete(string oilCode)
        {
            string strSql = @"delete from OilInfo where OilCode=@OilCode";
            

            var sqlParams = new
            {
                OilCode = oilCode
            };
            DBContext.Execute(strSql, sqlParams);
        }
    }
}
