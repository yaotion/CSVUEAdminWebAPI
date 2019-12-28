using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Deposit
{
    /// <summary>
    /// 储值赠送信息Repository实现
    /// </summary>
    public class DepositRepository : CSRepository, IDepositRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public DepositRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取活动列表
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="actName"></param>
        /// <returns></returns>
        public List<DepositAct> GetActList(string beginTime, string endTime, string actName)
        {
            string strSql = @"select * from UserDepositAct where Flag = 0 {0} order by Createtime desc";
            string strWhere = "";
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and startTm >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and endTm >= @ETime";
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
            return DBContext.Query<DepositAct>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="act"></param>
        public void AddAct(DepositAct act)
        {
            string strSql = @"insert into UserDepositAct  (ActName,StartTm,EndTm,Flag,Createtime) values (@ActName,@StartTm,@EndTm,@Flag,@Createtime)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                act.ActName,
                act.StartTm,
                act.EndTm,
                Flag = 0,
                Createtime = DateTime.Now
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改活动
        /// </summary>
        /// <param name="act"></param>
        public void UpdateAct(DepositAct act)
        {
            string strSql = @"update UserDepositAct set ActName=@ActName,startTm=@StartTm,EndTm = @EndTm where id=@Id";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                act.Id,
                act.ActName,
                act.StartTm,
                act.EndTm
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteAct(int actID)
        {
            string strSql = @"update UserDepositAct set Flag = 1  where Id=@Id";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                id=actID
            };
            DBContext.Execute(strSql, sqlParams);
        }

        

        /// <summary>
        /// 获取指定活动的 活动内容
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DepositContent> GetDepositContentList(int actID)
        {
            string strSql = @"select u.*,c.AccName,(case when t.RetailTypeName is null then '普通用户' else t.RetailTypeName end) RetailTypeName from dbo.UserDepositActContent u
                                left join CustomerInfo c on u.accno = c.AccNo
                                left join UserCardRetailType t on  u.RetailTypeID = t.RetailTypeID
                                where 1=1 and ActID = @ActID and Flag = 0 order by CreateTime";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                ActID = actID
            };
            return DBContext.Query<DepositContent>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 添加活动内容
        /// </summary>
        /// <param name="content"></param>
        public void AddContent(DepositContent content)
        {
            string strSql = @"insert into UserDepositActContent (Actid,DepositMin,DepositMax,DepositBonus,Accno,Flag,Createtime,BonusType,RetailTypeID,OilCode,StationLst)
                            values (@ActID,@DepositMin,@DepositMax,@DepositBonus,@AccNo,@Flag,@Createtime,@BonusType,@RetailTypeID,@OilCode,@StationLst)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {                
                content.ActID,
                content.DepositMin,
                content.DepositMax,
                content.DepositBonus,
                content.AccNo,
                content.Flag,
                content.CreateTime,
                content.BonusType,
                content.RetailTypeID,
                content.OilCode,
                content.StationLst,
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改活动内容
        /// </summary>
        /// <param name="content"></param>
        public void UpdateContent(DepositContent content)
        {
            string strSql = @"update UserDepositActContent set ActID=@ActID,DepositMin=@DepositMin,DepositMax=@DepositMax,DepositBonus=@DepositBonus,
                                AccNo=@AccNo,BonusType=@BonusType,RetailTypeID=@RetailTypeID,OilCode=@OilCode,StationLst=@StationLst where Id=@Id";                                
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                content.Id,
                content.ActID,
                content.DepositMin,
                content.DepositMax,
                content.DepositBonus,
                content.AccNo,
                content.BonusType,
                content.RetailTypeID,
                content.OilCode,
                content.StationLst
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="contentID"></param>
        public void DeleteContent(int contentID)
        {
            string strSql = @"update UserDepositActContent set Flag = 1  where  Id = @Id";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                Id = contentID
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除活动内容
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteActContent(int actID)
        {
            string strSql = @"update UserDepositActContent set Flag = 1  where  actID = @ActID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                ActID = actID
            };
            DBContext.Execute(strSql, sqlParams);
        }
       
    }
}
