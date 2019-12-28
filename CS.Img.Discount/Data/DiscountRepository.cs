using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Discount
{
    /// <summary>
    /// 明折明扣信息Repository实现
    /// </summary>
    public class DiscountRepository : CSRepository, IDiscountRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public DiscountRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取活动列表
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="actName"></param>
        /// <returns></returns>
        public List<DiscountAct> GetActList(string beginTime, string endTime, string actName)
        {
            string strSql = @"select * from DiscountActivity where 1=1 {0} order by ActEndTime desc";
            string strWhere = "";
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and ActEndTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and ActEndTime >= @ETime";
            }
            if (!string.IsNullOrEmpty(actName))
            {
                strWhere += " and ActName like ActName";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                Stime = beginTime,
                ETime = endTime,
                ActName = "%" + actName + "%"
            };
            return DBContext.Query<DiscountAct>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="act"></param>
        public void AddAct(DiscountAct act)
        {
            string strSql = @"insert into DiscountActivity  (ActID,ActName,ActStartTime,ActEndTime) values (@ActID,@ActName,@ActStartTime,@ActEndTime)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                act.ActID,
                act.ActName,
                act.ActStartTime,
                act.ActEndTime
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改活动
        /// </summary>
        /// <param name="act"></param>
        public void UpdateAct(DiscountAct act)
        {
            string strSql = @"update DiscountActivity set ActName=@ActName,ActStartTime=@ActStartTime,ActEndTime = @ActEndTime where ActID=@ActID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                act.ActID,
                act.ActName,
                act.ActStartTime,
                act.ActEndTime
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteAct(string actID)
        {
            string strSql = @"delete from DiscountActivity  where ActID=@ActID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                ActID = actID
            };
            DBContext.Execute(strSql, sqlParams);
        }

        

        /// <summary>
        /// 获取指定活动的 活动内容
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DiscountContent> GetDiscountContentList(string actID)
        {
            string strSql = @"select * from DiscountAcco where 1=1 and ActID = @ActID order by DisObjectType,DisObjectID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                ActID = actID
            };
            return DBContext.Query<DiscountContent>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 添加活动内容
        /// </summary>
        /// <param name="content"></param>
        public void AddContent(DiscountContent content)
        {
            string strSql = @"insert into DiscountAcco (DisID,ActID,StationID,StationName,DisObjectID,DisObjectName,DisObjectType,OilCode,DCTMoney,ValidMinVol)
                            values (@DisID,@ActID,@StationID,@StationName,@DisObjectID,@DisObjectName,@DisObjectType,@OilCode,@DCTMoney,@ValidMinVol)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                content.DisID,
                content.ActID,
                content.StationID,
                content.StationName,
                content.DisObjectID,
                content.DisObjectName,
                content.DisObjectType,
                content.OilCode,
                content.DCTMoney,
                content.ValidMinVol
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改活动内容
        /// </summary>
        /// <param name="content"></param>
        public void UpdateContent(DiscountContent content)
        {
            string strSql = @"update DiscountAcco set StationID=@StationID,StationName=@StationName,DisObjectID=@DisObjectID,DisObjectName=@DisObjectName,
                                    DisObjectType=@DisObjectType,OilCode=@OilCode,DCTMoney=@DCTMoney,ValidMinVol=@ValidMinVol
                                where  DisID = @DisID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                content.DisID,
                content.ActID,
                content.StationID,
                content.StationName,
                content.DisObjectID,
                content.DisObjectName,
                content.DisObjectType,
                content.OilCode,
                content.DCTMoney,
                content.ValidMinVol
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="disID"></param>
        public void DeleteContent(string disID)
        {
            string strSql = @"delete DiscountAcco  where  DisID = @DisID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                DisID = disID
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除活动内容
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteActContent(string actID)
        {
            string strSql = @"delete DiscountAcco  where  ActID = @ActID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                ActID = actID
            };
            DBContext.Execute(strSql, sqlParams);
        }

        /// <summary>
        /// 获取活动日志
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DiscountActLog> GetActLogList(string actID)
        {
            string strSql = @"select * from DiscountActivityLog where 1=1 and ActID = @ActID order by LogTime";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                ActID = actID
            };
            return DBContext.Query<DiscountActLog>(strSql, sqlParams).ToList();
        }
    }
}
