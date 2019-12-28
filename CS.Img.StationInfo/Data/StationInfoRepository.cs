using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.StationInfo
{
    /// <summary>
    /// 站点信息Repository实现
    /// </summary>
    public class StationInfoRepository: CSRepository,IStationInfoRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public StationInfoRepository(CSDBContext context)
            : base(context)
        { }

        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <param name="stationType"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public  IList<StationInfo> GetStationInfoList(int stationType, string stationNo)
        {
            string strSql = @"select * from stationInfo where 1=1 {0} order by stationNo";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (stationType > -1)
            {
                strWhere += " and stationType = @stationType";
            }          
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                stationType,
                stationNo
            };
            return DBContext.Query<StationInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 修改站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        /// <returns></returns>
        public void UpdateStationInfo(StationInfo stationInfo)
        {
            string strSql = @"update StationInfo set StationName = @StationName, SecCode=@SecCode,BriefName=@BriefName,Master=@Master,
                                TelNo=@TelNo,TaxCode=@TaxCode,TaxRate=@TaxRate,BankName=@BankName,BankAccNo=@BankAccNo,Address=@Address,
                                StationType=@StationType,Memo=@Memo
                                where StationNo=@StationNo";

            var sqlParams = new
            {
                stationInfo.StationNo,
                stationInfo.StationName,
                stationInfo.SecCode,
                stationInfo.BriefName,
                stationInfo.Master,
                stationInfo.TelNo,
                stationInfo.TaxCode,
                stationInfo.TaxRate,
                stationInfo.BankName,
                stationInfo.BankAccNo,
                stationInfo.Address,
                stationInfo.StationType,
                stationInfo.Memo
            };
            DBContext.Execute(strSql, sqlParams);
        }

        /// <summary>
        /// 删除站点信息
        /// </summary>
        /// <param name="stationNo"></param>
        public void DeleteStationInfo(string stationNo)
        {
            string strSql = @"delete from StationInfo  where StationNo=@StationNo";

            var sqlParams = new
            {
                StationNo = stationNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 添加站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        public void AddStationInfo(StationInfo stationInfo)
        {
            string strSql = @"insert into StationInfo (StationNo,StationName , SecCode,BriefName,Master,
                                TelNo,TaxCode,TaxRate,BankName,BankAccNo,Address,StationType,Memo) 
                                values (@StationNo,@StationName,@SecCode,@BriefName,@Master,
                                @TelNo,@TaxCode,@TaxRate,@BankName,@BankAccNo,@Address,@StationType,@Memo)";

            var sqlParams = new
            {
                stationInfo.StationNo,
                stationInfo.StationName,
                stationInfo.SecCode,
                stationInfo.BriefName,
                stationInfo.Master,
                stationInfo.TelNo,
                stationInfo.TaxCode,
                stationInfo.TaxRate,
                stationInfo.BankName,
                stationInfo.BankAccNo,
                stationInfo.Address,
                stationInfo.StationType,
                stationInfo.Memo
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 初始化站点
        /// </summary>
        /// <param name="stationNo"></param>
        public void InitStationInfo(string stationNo)
        {
            string strSql = @"update StationInfo set SecMAC= ''   where StationNo=@StationNo";

            var sqlParams = new
            {
                StationNo = stationNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
    }
}
