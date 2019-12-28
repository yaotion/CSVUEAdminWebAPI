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

        /// <summary>
        /// 获取优惠类型列表
        /// </summary>
        /// <returns></returns>
        public List<preType> GetPreIdList()
        {
            List<preType> rlt = new List<preType>()
            {
                new preType(){ preId =-1,preName="所有优惠方式"},
                new preType(){ preId =0,preName="时间段内累计优惠"},
                new preType(){ preId =1,preName="单次加油优惠"},
                new preType(){ preId =2,preName="持卡人生日当天优惠"},
                new preType(){ preId =3,preName="节假日单次优惠"},
                new preType(){ preId =4,preName="指定时间在指定加油站加油优惠"},
                new preType(){ preId =5,preName="企业卡用户时间段内单次优惠"},
                new preType(){ preId =6,preName="个人卡加油到一定金额进行优惠"},
                new preType(){ preId =7,preName="夜间设定时间进行优惠"},
                new preType(){ preId =8,preName="在指定时间段内累计加油超出优惠"},
                new preType(){ preId =9,preName="在该时间段内办卡享受该时间段内优惠"},
                 new preType(){ preId =99,preName="明折明扣返还"}
            };


            return rlt;
        }
        /// <summary>
        /// 获取支付方式列表
        /// </summary>
        /// <returns></returns>
        public List<PayWay> GetPayWayList()
        {
            string strSql = "select * from pay_way order by pay_way";
            return DBContext.Query<PayWay>(strSql).ToList();
        }
        /// <summary>
        /// 获取班号
        /// </summary>
        /// <returns></returns>
        public List<ShiftNo> GetShiftNoList(string stationNo, string bussDate)
        {
            string strSql = "select * from shift where stationno = @stationNo and buss_date = @bussDate";
            var sqlParams = new {
                stationNo,
                bussDate
            };
            return DBContext.Query<ShiftNo>(strSql,sqlParams).ToList();
        }
        /// <summary>
        /// 获取油品信息
        /// </summary>
        /// <returns></returns>
        public List<OilInfo> GetOilInfoList()
        {
            string strSql = "select * from OilInfo order by OilCode";
            return DBContext.Query<OilInfo>(strSql).ToList();
        }
        /// <summary>
        /// 获取油枪信息
        /// </summary>
        /// <returns></returns>
        public List<TerminalInfo> GetTerminalInfoList(string stationNo)
        {
            string strSql = "select * from Machine where stationno = @stationNo order by Terminal";
            var sqlParams = new
            {
                stationNo
            };
            return DBContext.Query<TerminalInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取交易类型
        /// </summary>
        /// <returns></returns>
        public List<TradeTypeInfo> GetTradeTypeInfoList()
        {
            string strSql = "select TradeType,TypeName TradeTypeName from TradeType order by TradeType";
            return DBContext.Query<TradeTypeInfo>(strSql).ToList();
        }

        /// <summary>
        /// 获取卡类型
        /// </summary>
        /// <returns></returns>
        public List<CardTypeInfo> GetCardTypeInfoList()
        {
            string strSql = "select CardType,TypeName CardTypeName from CardType order by CardType";
            return DBContext.Query<CardTypeInfo>(strSql).ToList();
        }
        /// <summary>
        /// 油站员工信息
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployeeList(string stationNo)
        {
            string strSql = "select * from employee where stationno = @stationNo order by stationno,emp_No";
            var sqlParams = new
            {
                stationNo
            };
            return DBContext.Query<Employee>(strSql, sqlParams).ToList();
        }
    }
}
