using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CS.Img.Utils;
using UnitOfWorkWithDapper;

namespace CS.Img.Station
{
    /// <summary>
    /// 用户卡数据仓储接口
    /// </summary>
    public class StationRepository : CSRepository, IStationRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public StationRepository(CSDBContext context)
            : base(context)
        { }


        /// <summary>
        /// 获取油罐状态记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="oilCode"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<TankStor> GetTankStor(string beginTime, string endTime, string oilCode, string stationNo)
        {
            string strSql = @"select * from TankStor t inner join
                (
                select max(AutoID) AutoID,st_no,tank_no from TankStor 
                where 1=1 {0} 
                group by st_no,tank_no
                ) tg on t.st_no = tg.st_no and t.tank_no=tg.tank_no and t.AutoID = tg.AutoID order by t.st_no,t.tank_no";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and st_no = @StationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and LogTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and LogTime <= @ETime";
            }
            if (!string.IsNullOrEmpty(oilCode))
            {
                strWhere += " and oilCode = @oilCode";
            }


            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo,
                oil_code = oilCode
            };

            return DBContext.Query<TankStor>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取油站日报按枪号
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByMach> GetRptDayByMach(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select stationno,terminal,oil_code,oil_name,min(pump_qty1) pump_qty1,MAX(pump_qty2) pump_qty2,sum(sum_qty) sum_qty,sum(sum_money) sum_money
                from dbo.rpt_mach where 1=1 {0} 
                group by stationno,terminal,oil_code,oil_name order by stationno,terminal,oil_code,oil_name";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationno = @StationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and buss_date >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and buss_date <= @ETime";
            }



            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<RptDayByMach>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油站日报按油品
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByOil> GetRptDayByOil(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select stationno,oil_code,oil_name,price,
                                sum(sum_qty0) SJQtys,sum(sum_money0) SJMoneys,sum(sum_qty1) XJQtys,sum(sum_money1) XJMoneys,
                                sum(sum_qty2) YPQtys,sum(sum_money2) YPMoneys,sum(sum_qty3) YHKQtys,sum(sum_money3) YHKMoneys,
                                sum(sum_qty4) XYKQtys,sum(sum_money4) XYKMoneys,sum(sum_qty5) JZQtys,sum(sum_money5) JZMoneys,
                                sum(sum_qty6) QTQtys,sum(sum_money6) QTMoneys,sum(sum_qty7) QT1Qtys,sum(sum_money7) QT1Moneys,
                                sum(sum_qty10) WXQtys,sum(sum_money10) WXMoneys,sum(sum_qty11) ZFBQtys,sum(sum_money11) ZFBMoneys,
                                sum(sum_qty12) YLQtys,sum(sum_money12) YLMoneys
                                from dbo.rpt_oil where 1=1 {0} 
                                group by stationno,oil_code,oil_name,price order by stationno,oil_code,oil_name,price";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationno = @StationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and buss_date >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and buss_date <= @ETime";
            }



            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<RptDayByOil>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取油站日报按油罐
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByTank> GetRptDayByTank(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select tankSum.*,tankMin.start_li,tankMax.end_li end_li from
                                (
                                select stationno,oil_code,oil_name,tank_no,
                                MAX(buss_date + cast( shift_no as varchar)) endDate,min(buss_date + cast( shift_no as varchar)) startDate,
                                sum(add_li) add_li,sum(sale_li) sale_li,sum(lost_li)  lost_li
                                from dbo.rpt_tank where 1=1 {0}
                                group by stationno,tank_no,oil_code,oil_name 
                                ) tankSum 
                                inner join rpt_tank tankMin on tankSum.stationno=tankMin.stationno and tankSum.tank_no=tankMin.tank_no
					                                and tankSum.startDate =(tankMin.buss_date + cast(tankMin.shift_no as varchar))
                                inner join rpt_tank tankMax on tankSum.stationno=tankMax.stationno and tankSum.tank_no=tankMax.tank_no
					                                and tankSum.endDate =(tankMax.buss_date + cast( tankMax.shift_no as varchar))
                                order by stationno,tank_no,oil_code,oil_name";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationno = @StationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and buss_date >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and buss_date <= @ETime";
            }



            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<RptDayByTank>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 油站日报按加油员加油量
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByEmpQty> GetRptDayByEmpQty(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select stationno,emp_no,emp_name,sum(sum_qty) sum_qty from  rpt_operqty 
                                where 1 = 1
                                group by stationno,emp_no,emp_name order by stationno,emp_no,emp_name";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationno = @StationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and buss_date >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and buss_date <= @ETime";
            }



            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<RptDayByEmpQty>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 油站日报按加油员金额
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<RptDayByEmpMoney> GetRptDayByEmpMoney(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select stationno,emp_no,emp_name,oil_code,oil_name,
                                sum(sum_money1) XJMoneys,sum(sum_money2) YPMoneys,sum(sum_money3) YHKMoneys,
                                sum(sum_money5) JZMoneys,sum(sum_money6) QTMoneys,sum(sum_money7) QT1Moneys,
                                sum(sum_money10) WXMoneys,sum(sum_money11) ZFBMoneys,sum(sum_money12) YLMoneys
                                from  rpt_opermoney where 1 = 1
                                group by stationno,emp_no,emp_name,oil_code,oil_name 
                                order by stationno,emp_no,emp_name,oil_code,oil_name";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationno = @StationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and buss_date >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and buss_date <= @ETime";
            }



            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<RptDayByEmpMoney>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取卸油记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        public IList<OilAdd> GetOilAddRecord(string beginTime, string endTime, string stationNo, string tankNo)
        {
            string strSql = @"Select CONVERT (nvarchar(10), AddTime,20) as AddTime,tank_no,oil_name,start_oilh,start_vol,start_temp,
                                start_dens,start_wt,end_oilh,end_vol,end_temp,end_dens,end_wt,qty_vol,qty_wt,doc_vol,doc_dens,doc_wt,
                                lost_vol,lost_wt,start_time,end_time  
                                from OilAdd where AddFlag=2 {0} order by AddTime";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationno = @StationNo ";
            }
            if (!string.IsNullOrEmpty(tankNo))
            {
                strWhere += " and tank_no = @tankNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and AddTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and AddTime <= @ETime";
            }



            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo,
                tankNo
            };

            return DBContext.Query<OilAdd>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油站的油罐信息
        /// </summary>
        /// <param name="stationNo"></param>    
        /// <returns></returns>
        public IList<string> GetStationTanks(string stationNo)
        {
            string strSql = @"select tank_no as TankNo from Tank where check_Flag = 1 {0} order by tank_no";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationno = @StationNo ";
            }


            strSql = string.Format(strSql, strWhere);
            var sqlParams = new

            {
                StationNo = stationNo
            };

            return DBContext.Query<string>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油品信息修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<OilChange> GetOilChangeRecord(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select * from oiltype  where 1 = 1 {0} order by stationNo,ChangeTime";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and ChangeTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and ChangeTime <= @ETime";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<OilChange>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油机信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<Machine> GetMachineRecord(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select * from machine  where 1 = 1 {0} order by stationNo,ChangeTime";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and ChangeTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and ChangeTime <= @ETime";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<Machine>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油罐信息记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<Tank> GetTankRecord(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select * from tank  where 1 = 1 {0} order by stationNo,tank_no";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and ChangeTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and ChangeTime <= @ETime";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<Tank>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取操作员日志
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<OperLog> GetOperLog(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select * from operlog  where 1 = 1 {0} order by stationNo,OptTime";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and OptTime <= @ETime";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<OperLog>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油罐库存记录(班报)
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="tankNo"></param>
        /// <returns></returns>
        public IList<TankShift> GetTankShift(string beginTime, string endTime, string stationNo, string tankNo)
        {
            string strSql = @"select * from ShiftTank  where 1 = 1 {0} order by stationNo,tank_no";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(tankNo))
            {
                strWhere += " and tank_no = @tankNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and AddTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and AddTime <= @ETime";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo,
                tankNo
            };
            return DBContext.Query<TankShift>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取本班加油明细
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        public IList<TradeShiftNowDetail> GetTradeShiftNowDetail(string BussDate, int ShiftNo, string stationNo, int PayWay)
        {
            string strSql = @"Select stationno,flow_no,P.Way_Name,terminal,oil_code ,oil_name ,price,qty,money,money_sale, 
                mach_time from trade T inner join Pay_Way P On T.Pay_Way = P.Pay_Way
                where 1 = 1 {0}
                Order By stationno,mach_time,oil_code, terminal";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(BussDate))
            {
                strWhere += " and buss_date = @BussDate ";
            }
            if (ShiftNo > 0)
            {
                strWhere += " and Shift_No = @ShiftNo";
            }
            if (PayWay >= 0)
            {
                strWhere += " and T.Pay_Way = @PayWay";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                BussDate,
                ShiftNo,
                PayWay,
                stationNo
            };
            return DBContext.Query<TradeShiftNowDetail>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取本班加油量按油品统计
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        public IList<TradeShiftNowByOil> GetTradeShiftNowByOil(string BussDate, int ShiftNo, string stationNo, int PayWay)
        {

            string strSql = @" select stationNo, Oil_code, oil_name, SUM(qty) SumQty, SUM(money) SumMoney from trade 
                                where 1 = 1 {0} group by stationno,oil_code,oil_name order by stationno, oil_code, oil_name";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(BussDate))
            {
                strWhere += " and buss_date = @BussDate ";
            }
            if (ShiftNo > 0)
            {
                strWhere += " and Shift_No = @ShiftNo";
            }
            if (PayWay >= 0)
            {
                strWhere += " and Pay_Way = @PayWay";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                BussDate,
                ShiftNo,
                PayWay,
                stationNo
            };
            return DBContext.Query<TradeShiftNowByOil>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取本班加油量按油枪统计
        /// </summary>    
        /// <param name="BussDate"></param>
        /// <param name="ShiftNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="PayWay"></param>
        /// <returns></returns>
        public IList<TradeShiftNowByTerminal> GetTradeShiftNowByTerminal(string BussDate, int ShiftNo, string stationNo, int PayWay)
        {
            string strSql = @" select stationNo,terminal,Oil_code,oil_name,SUM(qty) SumQty,SUM(money) SumMoney from trade 
                            where 1=1 {0} group by stationno,terminal,oil_code,oil_name  order by stationno,terminal,oil_code,oil_name";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(BussDate))
            {
                strWhere += " and buss_date = @BussDate ";
            }
            if (ShiftNo > 0)
            {
                strWhere += " and Shift_No = @ShiftNo";
            }
            if (PayWay >= 0)
            {
                strWhere += " and Pay_Way = @PayWay";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                BussDate,
                ShiftNo,
                PayWay,
                stationNo
            };
            return DBContext.Query<TradeShiftNowByTerminal>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取当班信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public ShiftInfo GetShiftNow(string stationNo)
        {

            ShiftInfo result = new ShiftInfo();
            string strSql = @" select top 1 StationNo,Buss_Date,Shift_No from Shift 
                                where StationNo=@stationNo order by buss_date desc,shift_no desc ";

            var sqlParams = new
            {
                stationNo
            };

            var shiftList = DBContext.Query<ShiftInfo>(strSql, sqlParams).ToList();
            if (shiftList.Count > 0)
            {
                result = shiftList[0];
            }
            return result;


        }
        /// <summary>
        /// 获取油罐报警记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<TankAlarm> GetTankAlarm(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"Select stationno,Buss_date,Shift_no,Tank_no,Oil_code,T.Name As Alarm_type,Emp_no,Start_time,End_time,water_height,oil_height,oil_temp 
                from warning_rec W join warningType T on W.Alarm_Type = T.WarningType   where 1=1 {0} order by stationno,id";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and Start_time >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and Start_time <= @ETime";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };
            return DBContext.Query<TankAlarm>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取交易符合查询的 where条件组合
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public string GetTradeQuerySqlWhere(TradeQuery tradeQuery)
        {
            string strWhere = "";
            if (!string.IsNullOrEmpty(tradeQuery.StationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }

            if (!string.IsNullOrEmpty(tradeQuery.BeginTime))
            {
                strWhere += " and Mach_Time >= @STime";
            }
            if (!string.IsNullOrEmpty(tradeQuery.EndTime))
            {
                strWhere += " and Mach_Time <= @ETime";
            }
            if (!string.IsNullOrEmpty(tradeQuery.BussDate))
            {
                strWhere += " and Buss_Date = @BussDate";
            }
            if (tradeQuery.ShiftNo > 0)
            {
                strWhere += " and Shift_No = @ShiftNo";
            }
            if (!string.IsNullOrEmpty(tradeQuery.OilCode))
            {
                strWhere += " and Oil_Code = @OilCode";
            }
            if (!string.IsNullOrEmpty(tradeQuery.Terminal))
            {
                strWhere += " and Terminal = @Terminal";
            }
            if (tradeQuery.Payway > -1)
            {
                strWhere += " and Pay_Way = @Payway";
            }
            if (!string.IsNullOrEmpty(tradeQuery.CardType))
            {
                strWhere += " and Card_Type = @CardType";
            }
            if (tradeQuery.TradeType > -1)
            {
                strWhere += " and t_Type = @TradeType";
            }
            if (!string.IsNullOrEmpty(tradeQuery.EmpNo))
            {
                strWhere += " and emp_no = @EmpNo";
            }
            if (!string.IsNullOrEmpty(tradeQuery.CardNo))
            {
                strWhere += " and card_no = @CardNo";
            }
            return strWhere;
        }
        /// <summary>
        /// 获取交易符合查询的 SqlParams
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public dynamic GetTradeQuerySqlParams(TradeQuery tradeQuery)
        {
            var sqlParams = new
            {
                STime = tradeQuery.BeginTime,
                ETime = tradeQuery.EndTime,
                tradeQuery.StationNo,
                tradeQuery.BussDate,
                tradeQuery.ShiftNo,
                tradeQuery.OilCode,
                tradeQuery.Terminal,
                tradeQuery.Payway,
                tradeQuery.CardType,
                tradeQuery.TradeType,
                tradeQuery.EmpNo,
                tradeQuery.CardNo,
            };
            return sqlParams;
        }
        /// <summary>
        /// 查询加油
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<Trade> GetTrades(TradeQuery tradeQuery)
        {
            string strSql = @"select * from Trade where 1=1 {0} order by Mach_Time";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<Trade>(strSql, sqlParams);
        }
        /// <summary>
        /// 查询加油统计按照交易类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByTradeType> GetTradeSumByTradeType(TradeQuery tradeQuery)
        {
            string strSql = @"select t_Type TradeType,TradeType.TypeName TradeTypeName,sum(Qty) SumQty,sum(money) SumMoney from Trade 
                            left join TradeType on  trade.t_type = TradeType.TradeType 
                            where 1=1 {0}  group by StationNo,trade.t_type,TypeName order by StationNo,trade.t_type";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<TradeSumByTradeType>(strSql, sqlParams);
        }
        /// <summary>
        /// 查询加油统计按照卡号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByCard> GetTradeSumByCard(TradeQuery tradeQuery)
        {
            string strSql = @"select st.*,
                            (case when (u.AccNo = '00000000000000000000') then u.HolderName when (u.AccNo is null) then st.emp_name else cf.AccName end) accname from
                            (
                            select stationno,card_no,max(emp_name) emp_name,sum(Qty) SumQty,sum(money) SumMoney from Trade  
                            where 1=1 {0}  group by stationno,card_no,emp_no
                            ) st 
                            left join UserCardInfo u on Card_No = u.CardNo
                            left join CustomerInfo c on u.AccNo = c.AccNo
                            left join customerinfo cf on c.FatherAccno = cf.accNo
                            order by stationno,card_no";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<TradeSumByCard>(strSql, sqlParams);
        }
        /// <summary>
        /// 查询加油统计按照卡类型
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByCardType> GetTradeSumByCardType(TradeQuery tradeQuery)
        {
            string strSql = @"select card_type ,CardType.TypeName CardTypeName,sum(Qty) SumQty,sum(money) SumMoney from Trade 
                            left join CardType on  trade.card_type = CardType.CardType 
                            where 1=1  {0} group by StationNo,trade.card_type,TypeName order by StationNo,trade.card_type";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<TradeSumByCardType>(strSql, sqlParams);

        }
        /// <summary>
        /// 查询加油统计按照员工
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByEmpNo> GetTradeSumByEmpNo(TradeQuery tradeQuery)
        {
            string strSql = @"select Emp_No,sum(Qty) SumQty,sum(money) SumMoney from Trade 
                where 1=1 {0}  group by StationNo,Emp_No order by StationNo,Emp_No";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<TradeSumByEmpNo>(strSql, sqlParams);
        }
        /// <summary>
        /// 查询加油统计按照油品
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByOil> GetTradeSumByOil(TradeQuery tradeQuery)
        {
            string strSql = @"select oil_code,oil_name,sum(Qty) SumQty,sum(money) SumMoney from Trade 
                where 1=1 {0}  group by StationNo,oil_code,oil_name order by StationNo,oil_code,oil_name";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<TradeSumByOil>(strSql, sqlParams);
        }
        /// <summary>
        /// 查询加油统计按照枪号
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByTerminal> GetTradeSumByTerminal(TradeQuery tradeQuery)
        {
            string strSql = @"select terminal,sum(Qty) SumQty,sum(money) SumMoney from Trade 
                where 1=1 {0}  group by StationNo,terminal order by StationNo,terminal";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<TradeSumByTerminal>(strSql, sqlParams);
        }
        /// <summary>
        /// 查询加油统计按照结算方式
        /// </summary>
        /// <param name="tradeQuery"></param>
        /// <returns></returns>
        public IList<TradeSumByPayWay> GetTradeSumByPayWay(TradeQuery tradeQuery)
        {
            string strSql = @"select Trade.pay_way,way_name,sum(Qty) SumQty,sum(money) SumMoney from Trade
                                left join pay_way on trade.pay_way = pay_way.pay_way
                                where 1 = 1 {0}  group by StationNo,Trade.pay_way,way_name order by StationNo, Trade.pay_way";
            string strWhere = GetTradeQuerySqlWhere(tradeQuery);
            strSql = string.Format(strSql, strWhere);
            var sqlParams = GetTradeQuerySqlParams(tradeQuery);
            return DBContext.Query<TradeSumByPayWay>(strSql, sqlParams);
        }
        /// <summary>
        /// 查询加油站综合日报表
        /// </summary>
        /// <param name="bussDate"></param>
        /// <returns></returns>
        public IList<Rpt_Day_OilTank> GetRptDayOilTank(string bussDate)
        {
            string strSql = @"select st_no stationNo,rptday,oil_code,price,sum_money0 SJMoneys,sum_money1 XJMoneys,sum_money2 YPMoneys,sum_money3 YHKMoneys, 
                            sum_money4 XYKMoneys,sum_money5 JZMoneys,sum_money6 QTMoneys,sum_money7 QT1Moneys, all_qty TotalQtys,month_qty MonthQtys,
                            (sum_money0+sum_money1+sum_money2+sum_money3+sum_money4+sum_money5+sum_money6+sum_money7) TotalMoneys, 
                            End_li,CanAdd  from day_rpt_OilTank where rptday=@bussDate order by st_no,oil_code,price";
            var sqlParams = new
            {
                bussDate
            };
            return DBContext.Query<Rpt_Day_OilTank>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 查询员工卡
        /// </summary>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<EmpCard> GetEmpCard(string stationNo)
        {
            string strSql = @"select Emp_Name,Emp_No,Card_No,pum_holder_certificate_no CerNo,StationNo 
                from ic_white_card where 1=1 and StationNo = @stationNo order by Card_No";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }            
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                stationNo
            };
            return DBContext.Query<EmpCard>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 查询员工卡对账单
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<EmpCardBill> GetEmpCardBill(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"exec up_EmpReport @STime,@ETime,@stationNo";
            string strWhere = "";
            if (string.IsNullOrEmpty(stationNo))
            {
                return new List<EmpCardBill>();
            }
            if (string.IsNullOrEmpty(beginTime))
            {
                return new List<EmpCardBill>();
            }
            if (string.IsNullOrEmpty(endTime))
            {
                return new List<EmpCardBill>();
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo = stationNo
            };

            return DBContext.Query<EmpCardBill>(strSql, sqlParams).ToList();
        }
    }
}
