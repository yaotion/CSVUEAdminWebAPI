using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.PriceSystem
{
    /// <summary>
    /// 储值赠送信息Repository实现
    /// </summary>
    public class PriceSystemRepository : CSRepository, IPriceSystemRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public PriceSystemRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取价格体系列表
        /// </summary>
        /// <returns></returns>
        public List<PriceSet> GetPriceSetList()
        {
            string strSql = @"select * from PriceSet  order by PriceSetNo";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {

            };
            return DBContext.Query<PriceSet>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 添加价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        public void AddPriceSet(PriceSet priceSet)
        {
            string strSql = @"insert into PriceSet (PriceSetNo,PriceSetName,UseTime,PriceUse,ContentSum,InfoSum,iUpdateFlag)
                (select ISNULL(max(PriceSetNo),0) + 1,@PriceSetName,@UseTime,1,0,0,1 from PriceStation)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                priceSet.PriceSetName,
                priceSet.UseTime
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        public void UpdatePriceSet(PriceSet priceSet)
        {
            string strSql = @"update PriceSet set PriceSetName=@PriceSetName,UseTime=@UseTime where PriceSetNo=@PriceSetNo ";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                priceSet.PriceSetNo,
                priceSet.PriceSetName,
                priceSet.UseTime
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除价格体系
        /// </summary>
        /// <param name="priceSet"></param>
        public void DeletePriceSet(int priceSetNo)
        {
            string strSql = @"delete from PriceSet  where PriceSetNo=@PriceSetNo ";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo = priceSetNo
            };
            DBContext.Execute(strSql, sqlParams);
        }

        /// <summary>
        /// 获取价格策略列表
        /// </summary>
        /// <returns></returns>
        public List<PriceContent> GetPriceContentList(int priceSetNo)
        {
            string strSql = @"select * from PriceContent where PriceSetNo=@PriceSetNo  order by ContentNo";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo = priceSetNo
            };
            return DBContext.Query<PriceContent>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 清除价格体系内得所有策略
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceContent(int priceSetNo)
        {
            string strSql = @"delete from PriceContent  where PriceSetNo=@PriceSetNo ";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo = priceSetNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 添加价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        public void AddPriceContent(PriceContent priceContent)
        {
            string strSql = @"insert into PriceContent (ContentNo,PriceSetNo,ContentName,ContentUse,ContentType,StartHour,EndHour)
                (select ISNULL(max(ContentNo),0) + 1,@PriceSetNo,@ContentName,1,@ContentType,@StartHour,@EndHour from PriceContent)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                priceContent.PriceSetNo,
                priceContent.ContentName,
                priceContent.ContentType,
                priceContent.StartHour,
                priceContent.EndHour
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改价格策略
        /// </summary>
        /// <param name="priceContent"></param>
        public void UpdatePriceContent(PriceContent priceContent)
        {
            string strSql = @"update PriceContent set ContentName=@ContentName,ContentType=@ContentType,StartHour=@StartHour,EndHour=@EndHour
                                where ContentNo=@ContentNo ";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                priceContent.ContentNo,
                priceContent.ContentName,
                priceContent.ContentType,
                priceContent.StartHour,
                priceContent.EndHour
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除价格策略
        /// </summary>
        /// <param name="priceContentNo"></param>
        public void DeletePriceContent(int priceContentNo)
        {
            string strSql = @"delete from PriceContent where ContentNo=@ContentNo ";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                ContentNo = priceContentNo
            };
            DBContext.Execute(strSql, sqlParams);
        }

        /// <summary>
        /// 获取体系内油站列表
        /// </summary>
        /// <returns></returns>
        public List<PriceStation> GetPriceStationList(int priceSetNo)
        {
            string strSql = @"select PriceStationNo,PriceSetNo,st_name StationName,st_no StationNo,PUBflag,iUpdateFlag from PriceStation where PriceSetNo=@PriceSetNo  order by st_name";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo = priceSetNo
            };
            return DBContext.Query<PriceStation>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 设置体系适用油站
        /// </summary>
        /// <returns></returns>
        public void DeletePriceStation(int PriceSetNo,string StationNo)
        {
            string strSql = @"delete from PriceStation where PriceSetNo=@PriceSetNo and st_no =@StationNo";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo,
                StationNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 添加体系适用油站
        /// </summary>
        /// <returns></returns>
        public void AddPriceStation(int PriceSetNo, string StationNo, string StationName)
        {
            string strSql = @"insert into PriceStation (PriceStationNo,PriceSetNo,st_name,st_no)
                (select ISNULL(max(PriceStationNo),0) + 1,@PriceSetNo,@StationName,@StationNo from PriceStation)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo,
                StationNo,
                StationName
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 清除价格体系内得所有站点
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceStation(int priceSetNo)
        {
            string strSql = @"delete from PriceStation  where PriceSetNo=@PriceSetNo ";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo = priceSetNo
            };
            DBContext.Execute(strSql, sqlParams);
        }

        /// <summary>
        /// 获取策略油品价格信息
        /// </summary>
        /// <returns></returns>
        public List<PriceContentOil> GetPriceContentOilList(int priceContentID)
        {
            string strSql = @"select PriceInfoNo,PriceSetContent,oil_code OilCode,oil_name OilName,NewPrice,OldPrice from PriceSetInfo where PriceSetContent=@PriceSetContent  order by oil_code";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetContent = priceContentID
            };
            return DBContext.Query<PriceContentOil>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 删除策略内油品
        /// </summary>
        /// <returns></returns>
        public void DeletePriceContentOil(int priceContentID, string oilCode)
        {
            string strSql = @"delete from PriceSetInfo where PriceSetContent=@PriceSetContent and oil_code =@OilCode";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetContent = priceContentID,
                OilCode = oilCode 
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 添加策略内油品信息
        /// </summary>
        /// <returns></returns>
        public void AddPriceContentOil(int priceContentID, string oilCode, string oilName, decimal newPrice)
        {
            string strSql = @"insert into PriceSetInfo (PriceInfoNo,PriceSetContent,oil_code,oil_name,NewPrice,OldPrice)
                (select ISNULL(max(PriceInfoNo),0) + 1,@PriceSetContent,@OilCode,@OilName,@NewPrice,0 from PriceSetInfo)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetContent = priceContentID,
                OilName = oilName,
                OilCode = oilCode,
                NewPrice= newPrice
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 清除价格体系内得所有油品
        /// </summary>
        /// <param name="priceSetNo"></param>
        public void ClearPriceSetOil(int priceSetNo)
        {
            string strSql = @"delete from PriceSetInfo  where PriceSetContent in  (select ContentNo from  PriceContent where PriceSetNo=@PriceSetNo )";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetNo = priceSetNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 清除价格策略得油品信息
        /// </summary>
        /// <param name="priceContentNo"></param>
        public void ClearPirceContentOil(int priceContentNo)
        {
            string strSql = @"delete from PriceSetInfo  where PriceSetContent = @PriceSetContent";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                PriceSetContent = priceContentNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
    }
}
