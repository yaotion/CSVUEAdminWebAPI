using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.Img.Utils;

namespace CS.Img.Base
{
    /// <summary>
    /// 基础数据仓储实现类
    /// </summary>
    public class BaseRepository :CSRepository,IBaseRepository
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="context"></param>
        public BaseRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取油站列表
        /// </summary>
        /// <returns></returns>
        public List<Station> GetStationList()
        {
            string strSql = "select stationno stationno,stationname stationname from stationinfo order by stationno";
            return DBContext.Query<Station>(strSql).ToList();
        }
        /// <summary>
        /// 获取卡状态列表
        /// </summary>
        /// <returns></returns>
        public List<CardState> GetCardStateList()
        {
            string strSql = "select TypeID CardState,TypeName CardStateName from appTypes where GroupID = 3 order by TypeID";
            return DBContext.Query<CardState>(strSql).ToList();
        }

        /// <summary>
        /// 获取散户卡级别列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            string strSql = "select * from UserCardRetailType order by RetailTypeID";
            return DBContext.Query<RetailType>(strSql).ToList();
        }
    }
}
