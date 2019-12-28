using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CS.Img.Utils;
using UnitOfWorkWithDapper;

namespace CS.Img.Card
{
    /// <summary>
    /// 用户卡数据仓储接口
    /// </summary>
    public class CardRepository : CSRepository, ICardRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public CardRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取用户卡售卡交易
        /// </summary>
        /// <returns></returns>
        public IList<UserSaleTrade> GetUserSaleTrade(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT s.*,u.AccNo as accname,u.HolderName as cardname FROM SaleCardLog s 
            left join UserCardInfo u on s.CardNo = u.CardNo where 1=1 ";
            if (stationNo != "")
            {
                strSql += " and s.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and OptTime <= @EndTime";
            }

            strSql += " order by s.opttime";

            return DBContext.Query<UserSaleTrade>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }


        /// <summary>
        /// 获取用户卡售卡交易
        /// </summary>
        /// <returns></returns>
        public IList<UserRecardRecord> GetUserRecardRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.*, b.StationName,a.OldCardNo as CardNo,a.AccNo as AccName FROM RECARDLOG a, StationInfo b  WHERE  a.StationNo = b.StationNo ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and OptTime <= @EndTime";
            }
            strSql += " order by a.opttime";


            return DBContext.Query<UserRecardRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        /// 获取用户卡挂失记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserLossCardRecord> GetUserLossCardRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.LogFlowNo, a.CardNo, b.StationName,a.StationNo, a.LossTime as OptTime, a.OptName, a.OptNo, a.LossReason, a.MasterName, a.FrmId, a.Memo, a.ShiftNo FROM LossCardLog a, StationInfo b 
                WHERE (a.StationNo = b.StationNo) ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.LossTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.LossTime <= @EndTime";
            }
            strSql += " order by a.LossTime";


            return DBContext.Query<UserLossCardRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }
        /// <summary>
        /// 获取用户解挂记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserUnLossCardRecord> GetUserUnLossCardRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.LogFlowNo, a.CardNo, b.StationName,a.StationNo, a.UnLossTime as OptTime, a.OptName, a.OptNo, a.UnLossReason as LossReason, a.MasterName, a.FrmId, a.Memo, a.ShiftNo FROM UnLossCardLog a, StationInfo b 
                WHERE (a.StationNo = b.StationNo) ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.UnLossTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.UnLossTime <= @EndTime";
            }
            strSql += " order by a.UnLossTime";


            return DBContext.Query<UserUnLossCardRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        /// 获取解灰记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserUnGreyCardRecord> GetUserUnGreyCardRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.TradeFlowNo, a.StationNo, a.OptNo, a.OptName, a.CardNo, a.UngreyMoney, a.CardBalance,
                                a.greyTime, a.OptTime, b.StationName 
                                FROM  UnGreyLog AS a LEFT OUTER JOIN StationInfo AS b ON a.StationNo = b.StationNo ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<UserUnGreyCardRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        /// 获取散户卡储值记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserDepositRecord> GetUserDepositRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.*,b.StationName FROM UserDepositTrade a
                                LEFT OUTER JOIN StationInfo AS b ON a.StationNo = b.StationNo  where 1=1 ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<UserDepositRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }
        /// <summary>
        /// 获取单位客户存钱记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustPayMoneyRecord> GetCustPayMoneyRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @" SELECT a.TradeFlowNo,a.stationno, b.StationName, a.OptName, a.OptNo, a.OptTime, a.SaveMoney,a.BonusMoney,a.SaveMoneyBase, a.AccNo, c.AccName, a.AccNoAmt,a.PAYTYPE,a.PaymentMode
	                            FROM CustPayMoneyTrade  a left outer join StationInfo b
	                            on (a.StationNo = b.StationNo) left outer join CustomerInfo c on c.AccNo=a.AccNo Where (1=1)";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CustPayMoneyRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }
        /// <summary>
        /// 获取单位客户划账记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustChangeMoneyRecord> GetCustChangeMoneyRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"  SELECT a.TradeFlowNo,a.stationno, b.StationName, a.OptName, a.OptNo, a.OptTime, a.ChangeMoney, a.SrcAccNo,c.AccName as srcaccname,
	            a.DesAccNo,d.AccName as desaccname,a.SrcAccNoAmt,a.DesAccNoAmt 
	            FROM CustChangeMoneyTrade  a left outer join StationInfo b
	            on (a.StationNo = b.StationNo) left outer join CustomerInfo c on c.AccNo=a.SrcAccNo left outer join CustomerInfo d on d.AccNo=a.DesAccNo Where (1=1)";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CustChangeMoneyRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        /// 客户卡储值交易
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustDepositRecord> GetCustDepositRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"  SELECT a.TradeFlowNo,a.StationNo, b.StationName, a.OptName, a.OptNo, a.OptTime, a.CardNo, a.DepositMoney, a.CardAmt, a.AccNo, c.AccName, a.AccNoAmt
	                                FROM CustDepositTrade  a left outer join StationInfo b
	                                on (a.StationNo = b.StationNo) left outer join CustomerInfo c on c.AccNo=a.AccNo Where (1=1) and a.SaveType = 1 ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CustDepositRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }
        /// <summary>
        /// 客户卡扣款交易
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustUnDepositRecord> GetCustUnDepositRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @" SELECT a.TradeFlowNo, b.StationName,a.StationNo, a.OptName, a.OptNo, a.OptTime, a.CardNo, a.DepositMoney, a.CardAmt, a.AccNo, c.holdername, a.AccNoAmt 
	                            FROM CustDepositTrade  a left outer join StationInfo b
	                            on (a.StationNo = b.StationNo) left outer join UserCardInfo c on c.Cardno=a.CardNo 
	                            Where (1=1) AND b.StationType=1 AND a.SaveType = 0 ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CustUnDepositRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        ///散户卡扣款交易
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserUnDepositRecord> GetUserUnDepositRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @" SELECT a.TradeFlowNo, a.ShiftNo,a.StationNo, b.StationName, u.HolderName, a.MasterName, a.FrmId, a.OptName, a.OptNo,
		                             a.OptTime, a.CardNo, a.SaveMoney,a.CardAmt,a.PayType, a.CheckNo, a.Memo,a.DisCountMoney 
	                            FROM UserDepositTrade a, StationInfo b, usercardinfo u  
	                            WHERE (a.StationNo = b.StationNo) AND b.StationType=1 AND a.SaveType=0  AND a.CardNo=u.CardNo  ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<UserUnDepositRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }


        /// <summary>
        ///单位客户开户记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustCreateRecord> GetCustCreateRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @" SELECT     a.LogFlowNo, a.StationNo, a.OptNo, a.OptName, a.OptTime, a.FunctionNo, a.FunctionType, a.MemoTxt as accname,
                                b.StationName,c.BankName,c.BankAccNo 
	                        FROM  OperateLog AS a LEFT OUTER JOIN  StationInfo AS b ON a.StationNo = b.StationNo LEFT OUTER JOIN Customerinfo c ON a.MemoTxt=c.AccName 
	                        WHERE     (a.FunctionNo = 'Act_custopen')";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CustCreateRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }
        /// <summary>
        ///单位客户销户记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustDestroyRecord> GetCustDestroyRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @" SELECT * FROM CustDestroyTrade a where 1=1 ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CustDestroyRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        ///卡密码修改纪录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserChangePinRecord> GetChangePinRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.LogFlowNo, a.CardNo,a.StationNo, b.StationName, a.ShiftNo, a.OptName, a.ChangeTime optTime, a.OptNo, 
                                a.ChangeReason, a.MasterName, a.FrmId, a.Memo FROM ChangeCardPinLog a, StationInfo b 
                             WHERE (a.StationNo = b.StationNo) ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.ChangeTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.ChangeTime <= @EndTime";
            }
            strSql += " order by a.ChangeTime";


            return DBContext.Query<UserChangePinRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        /// 重装卡密码修改记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserReloadPinRecord> GetReloadPinRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.LogFlowNo, a.CardNo,a.StationNo, b.StationName, a.ReloadTime OptTime, a.OptName, a.ShiftNo, a.OptNo, a.ReloadReason,
                                    a.MasterName, a.FrmId, a.Memo FROM ReloadCardPinLog a, StationInfo b 
                            WHERE (a.StationNo = b.StationNo) ";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.ReloadTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.ReloadTime <= @EndTime";
            }
            strSql += " order by a.ReloadTime";


            return DBContext.Query<UserReloadPinRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }
        /// <summary>
        /// 获取卡信息修改纪录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>

        public IList<CardUpdateRecord> GetCardUpdateRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT   a.LogFlowNo, a.StationNo, a.OptNo, a.OptName, a.OptTime, a.FunctionNo, a.FunctionType, a.MemoTxt as cardno, b.StationName 
                                FROM	OperateLog AS a LEFT OUTER JOIN  StationInfo AS b ON a.StationNo = b.StationNo 
                                WHERE   (a.FunctionNo = 'Act_modcard')";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CardUpdateRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        /// 退卡记录查询
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CardReturnRecord> GetCardReturnRecord(string stationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT  b.StationName,a.*,
                                (case AccNo when '00000000000000000000' then '现金返还' else '账户返还' end) PAYTYPE 
                              FROM ReturnCardTrade a, StationInfo b  WHERE (a.StationNo = b.StationNo)  AND b.StationType=1";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.OptTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.OptTime <= @EndTime";
            }
            strSql += " order by a.OptTime";


            return DBContext.Query<CardReturnRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime }).ToList();
        }

        /// <summary>
        /// 挂失记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CardLossRecord> GetCardLossRecord(string stationNo, string beginTime, string endTime, int LossType)
        {
            string strSql = @"SELECT a.LogFlowNo, a.CardNo,a.StationNo, b.StationName, a.LossTime OptTime, a.OptName, a.OptNo, a.LossReason, a.MasterName, a.FrmId, a.Memo, a.ShiftNo,c.holdername 
                                FROM LossCardLog a, StationInfo b,UserCardInfo c 
                            WHERE (a.StationNo = b.StationNo) AND (a.CardNo = c.CardNo) AND b.StationType=1";
            if (stationNo != "")
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (beginTime != "")
            {
                strSql += " and a.LossTime >= @BeginTime";
            }
            if (endTime != "")
            {
                strSql += " and a.LossTime <= @EndTime";
            }
            if (LossType > -1)
            {
                strSql += " and a.ShiftNo = @ShiftNo";
            }
            strSql += " order by a.LossTime";


            return DBContext.Query<CardLossRecord>(strSql, new { StationNo = stationNo, BeginTime = beginTime, EndTime = endTime, ShiftNo = LossType }).ToList();
        }

        /// <summary>
        /// 查询用户卡信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserCardInfo> QueryUserCardInfo(string CardNo, string HolderName, string Mobile, string CerNo, string Car, int RetailType, int CardState)
        {
            string strSql = @"select u.*,a.TypeName as CardStateName,r.RetailTypeName,(Case AccNo when '00000000000000000000' then '散户' else '单位' end) AccType
                                from UserCardInfo u 
                                left join  AppTypes a on  u.CardState = a.TypeId and a.GroupID = 3
                                left join UserCardRetailType r on u.RetailTypeID = r.RetailTypeID where 1 = 1";
            if (!string.IsNullOrEmpty(CardNo))
            {
                strSql += " and u.CardNo like  @CardNo  ";
            }
            if (!string.IsNullOrEmpty(HolderName))
            {
                strSql += " and u.HolderName like  @HolderName ";
            }
            if (!string.IsNullOrEmpty(Mobile))
            {
                strSql += " and u.Mobile like @Mobile ";
            }
            if (!string.IsNullOrEmpty(CerNo))
            {
                strSql += " and u.HolderCerNo like  @HolderCerNo ";
            }
            if (!string.IsNullOrEmpty(Car))
            {
                strSql += " and u.LimitCar like @LimitCar";
            }
            if (RetailType > 0)
            {
                strSql += " and u.RetailTypeID = @RetailTypeID";
            }
            if (CardState > 0)
            {
                if (CardState < 10)
                {
                    strSql += " and u.CardState = @CardState";
                }
                if (CardState == 100)
                {
                    strSql += " and u.CardState < 2";
                }
                if (CardState == 101)
                {
                    strSql += " and u.CardState >= 2";
                }
            }
            strSql += " order by u.CardNo";

            var sqlParams = new
            {
                CardNo = "%" + CardNo,
                HolderName = HolderName + "%",
                Mobile = Mobile + "%",
                HolderCerNo = "%" + CerNo + "%",
                LimitCar = "%" + Car + "%",
                RetailTypeID = RetailType,
                CardState
            };
            return DBContext.Query<UserCardInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取用户卡详细信息
        /// </summary>
        /// <param name="CardNo"></param>
        /// <returns></returns>
        public bool FindUserCardInfo(string CardNo, out UserCardInfoDetail CardDetail)
        {
            CardDetail = null;
            string strSql = @"select u.*,c.AccName,a.TypeName as CardStateName,r.RetailTypeName,(Case u.AccNo when '00000000000000000000' then '散户' else '单位' end) AccType

                                from UserCardInfo u 
                                left join  AppTypes a on  u.CardState = a.TypeId and a.GroupID = 3
                                left join customerinfo c on u.AccNo = c.AccNo
                                left join UserCardRetailType r on u.RetailTypeID = r.RetailTypeID where CardNo = @CardNo";


            var sqlParams = new
            {
                CardNo
            };
            var result = DBContext.Query<UserCardInfoDetail>(strSql, sqlParams).ToList();
            if (result.Count > 0)
            {
                CardDetail = result[0];
                return true;
            }
            return false;
        }
        /// <summary>
        /// 查询单位账户信息
        /// </summary>
        /// <param name="HelpSign">助记符</param>
        /// <param name="AccName">单位名称</param>
        /// <param name="AccType">账号类型</param>
        /// <returns></returns>
        public IList<CustomerInfo> QueryCustomerInfo(string AccNo, string HelpSign, string AccName, int AccType)
        {
            string strSql = @"select * from CustomerInfo where 1 = 1";
            if (!string.IsNullOrEmpty(AccNo))
            {
                strSql += " and AccNo =  @AccNo  ";
            }
            if (!string.IsNullOrEmpty(HelpSign))
            {
                strSql += " and HelpSign like  @HelpSign  ";
            }
            if (!string.IsNullOrEmpty(AccName))
            {
                strSql += " AccName like  @AccName  ";
            }
            if (AccType > 0)
            {
                strSql += " AccType = @AccType";
            }
            strSql += " order by AccNo";

            var sqlParams = new
            {
                AccNo,
                HelpSign = "%" + HelpSign + "%",
                AccName = "%" + AccName + "%",
                AccType
            };
            return DBContext.Query<CustomerInfo>(strSql, sqlParams).ToList();


        }
        /// <summary>
        /// 查询单位用户卡信息
        /// </summary>
        /// <param name="AccNo">单位账号</param>
        /// <returns></returns>
        public IList<UserCardInfo> QueryCustCardInfo(string AccNo)
        {
            string strSql = @"select u.*,a.TypeName as CardStateName,r.RetailTypeName,(Case u.AccNo when '00000000000000000000' then '散户' else '单位' end) AccType
                                from UserCardInfo u 
                                left join  AppTypes a on  u.CardState = a.TypeId and a.GroupID = 3
                                left join UserCardRetailType r on u.RetailTypeID = r.RetailTypeID where 1 = 1 and u.AccNo like @AccNo";

            strSql += " order by u.CardNo";

            var sqlParams = new
            {
                AccNo = AccNo + "%"
            };
            return DBContext.Query<UserCardInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取指定卡号在指定时段的对账单
        /// </summary>
        /// <param name="CardNo">卡号</param>
        /// <param name="beginTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns></returns>
        public IList<CardBill> GetCardBillRecord(string CardNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT Emp_No as OptNo,* FROM vCardBill WHERE CardNo=@CardNo AND OptTime>=@STime AND OptTime<@ETime ORDER BY OILCTC ,CTC ,OptTime";

            var sqlParams = new
            {
                CardNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<CardBill>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取指定单位账户在指定时段的对账单
        /// </summary>
        /// <param name="AccNo">卡号</param>
        /// <param name="beginTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns></returns>
        public IList<CustBill> GetCustBillRecord(string AccNo, string beginTime, string endTime)
        {
            string strSql = @"Select * from vAccBillRep WHERE SUBSTRING(AccNo,1,4)=@AccNo AND OptTime >=@STime AND OptTime <@ETime order by OptTime";

            var sqlParams = new
            {
                AccNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<CustBill>(strSql, sqlParams).ToList();

        }
        /// <summary>
        /// 获取用户卡消费纪录
        /// </summary>
        /// <param name="CardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CardTradeRecord> GetCardTradeRecord(string CardNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT EMP_NO as OptNo,* FROM vCardBillRep WHERE TypeID2 in (0,11,12,5) and CardNo=@CardNo AND OptTime>=@STime AND OptTime<@ETime order by OptTime";

            var sqlParams = new
            {
                CardNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<CardTradeRecord>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取用户卡积分账单
        /// </summary>
        /// <param name="CardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CardScoreRecord> GetCardScoreRecord(string CardNo, string beginTime, string endTime)
        {
            string strSql = @"execute up_centbill @STime,@ETime,@CardNo";

            var sqlParams = new
            {
                CardNo,
                STime = beginTime,
                ETime = endTime
            };

            return DBContext.Query<CardScoreRecord>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 用户卡积分消费记录
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="CardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CardScorePayRecord> GetCardScorePayRecord(string StationNo, string CardNo, string beginTime, string endTime)
        {
            string strSql = @"Select * from CentPayLog where OptType=2 ";
            if (StationNo != "")
            {
                strSql += " and stationNo = @StationNo ";
            }
            if (CardNo != "")
            {
                strSql += " and CardNo = @CardNo ";
            }
            if (beginTime != "")
            {
                strSql += " and OptTime >= @STime";
            }
            if (endTime != "")
            {
                strSql += " and OptTime <= @ETime";
            }
            strSql += " order by OptTime";
            var sqlParams = new
            {
                CardNo,
                STime = beginTime,
                ETime = endTime,
                StationNo
            };

            return DBContext.Query<CardScorePayRecord>(strSql, sqlParams).ToList();
        }

        #region 发卡点清算汇总表相关
        /// <summary>
        /// 售卡数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public int GetSaleCardCount(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT count(*) as SaleNum FROM SaleCardLog a,StationInfo b WHERE  b.StationType=1 AND a.StationNo=b.StationNo";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }

            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<int>(strSql, sqlParams);
        }
        /// <summary>
        /// 挂失数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public int GetLossCardCount(string StationNo, string beginTime, string endTime) {
            string strSql = @"SELECT count(*) as SaleNum FROM LossCardLog a,StationInfo b WHERE  b.StationType=1 AND a.StationNo=b.StationNo";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and LossTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and LossTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<int>(strSql, sqlParams);
        }
        /// 开户数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public int GetNewCustomerCount(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT count(*) as OpenAccNum FROM CustomerInfo a,StationInfo b WHERE  b.StationType=1 AND a.StationNo=b.StationNo and ACCTYPE = 0 ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and StartTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and StartTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<int>(strSql, sqlParams);

        }
        /// <summary>
        /// 销户数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public int GetDestroyCustomerCount(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT count(*) as DelAccNum FROM CustDestroyTrade a,StationInfo b WHERE   b.StationType=1 AND a.StationNo=b.StationNo ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<int>(strSql, sqlParams);

        }

        /// <summary>
        /// 转账金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetCustChangeMoneySum(string StationNo, string beginTime, string endTime)
        {

            string strSql = @"SELECT ISNULL(sum(ChangeMoney),0) as NUM1 FROM CustChangeMoneyTrade a,StationInfo b  WHERE   b.StationType=1 AND a.StationNo=b.StationNo and LEN(a.srcaccno)=4 ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);
        }
        /// <summary>
        /// 反转账金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetCustReChangeMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT ISNULL(sum(ChangeMoney),0) as NUM1 FROM CustChangeMoneyTrade a,StationInfo b  WHERE   b.StationType=1 AND a.StationNo=b.StationNo and LEN(a.srcaccno)=8 ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);
        }
        /// <summary>
        /// 储值金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetUserDepositMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT ISNULL(SUM(a.SaveMoney), 0) AS returnMoney FROM UserDepositTrade AS a 
	                            LEFT OUTER JOIN UserCardInfo AS b ON a.CardNo = b.CardNo 
	                            WHERE  (b.AccNo = '00000000000000000000') AND (a.SaveType = 1) ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);
        }
        /// <summary>
        /// 圈提金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetUserReDepositMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT ISNULL(SUM(a.SaveMoney), 0) AS returnMoney FROM UserDepositTrade AS a 
	                            LEFT OUTER JOIN UserCardInfo AS b ON a.CardNo = b.CardNo 
	                            WHERE  (b.AccNo = '00000000000000000000') AND (a.SaveType = 0) ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);
        }
        /// <summary>
        /// 存钱金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetCustomerSaveMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT isnull(Sum(SaveMoney),0) as unitsave FROM CustPayMoneyTrade a,StationInfo b WHERE b.StationType=1 AND a.StationNo=b.StationNo AND  a.ShiftNo<>2 ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);

        }
        /// <summary>
        /// 冲正金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetCustomerReSaveMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT isnull(Sum(ChangeMoney),0) as ChangeMoney FROM CustChangeMoneyTrade a ,StationInfo b  WHERE  b.StationType=1 AND a.StationNo=b.StationNo AND DESACCNO='0000' ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);

        }
        /// <summary>
        /// 散户退款金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetUserReturnMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT isnull(Sum(ReturnMoney),0) as delaccmoney FROM ReturnCardTrade a ,StationInfo b  WHERE   b.StationType=1 AND a.StationNo=b.StationNo AND ACCNO='00000000000000000000'";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);

        }


        /// <summary>
        /// 单位账户销户金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetCustReturnMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT isnull(Sum(ReturnMoney),0) as delaccmoney FROM CustDestroyTrade a,StationInfo b WHERE  b.StationType=1 AND a.StationNo=b.StationNo ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);

        }
        /// <summary>
        /// 退至单位账户的余额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal GetCustBackAccMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT ISNULL(sum(ChangeMoney),0) as NUM1 FROM CustChangeMoneyTrade a,StationInfo b  WHERE   b.StationType=1 AND a.StationNo=b.StationNo and LEN(a.srcaccno)=8  ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.ExecuteScalar<decimal>(strSql, sqlParams);
        }
        /// <summary>
        /// 获取客户存钱按账户类型分类统计
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<MoneyGroupSum> GetCustSaveGroupMoneySum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"Select isnull(SUM(ISNULL(PayAMN, 0)), 0) as SumMoney, CustomerPayType as GroupName from vAccBillRep_withstno                    
                                left join CustomerInfo on SUBSTRING(vAccBillRep_withstno.AccNo, 1, 4)=CustomerInfo.AccNo                                                     
                                where  CustomerInfo.AccNo<>'0000' and vAccBillRep_withstno.Accno<>'0000' and AccType=0 and vAccBillRep_withstno.TypeId1=1 ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            strSql += "  group by CustomerInfo.CustomerPayType ";
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };

            return DBContext.Query<MoneyGroupSum>(strSql, sqlParams).ToList();
        }


        #endregion  发卡点清算汇总表相关
        /// <summary>
        /// 获取操作日志的分组统计信息
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<FunctionSum> GetOptGroupSum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT FunctionNo,COUNT(*) FunctionCount FROM OperateLog a,StationInfo b  WHERE  b.StationType=1 AND a.StationNo=b.StationNo ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            strSql += " group by FunctionNo";
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };

            return DBContext.Query<FunctionSum>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取限制账户划账记录
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustChangeLimitRecord> GetCustChangeLimitRecord(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"select b.stationname,a.* from AccLimitLog a left outer join stationinfo b on a.StationNo=b.StationNo Where 1=1 ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            strSql += " order by OptTime";
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };

            return DBContext.Query<CustChangeLimitRecord>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 查询制卡记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<MakeCardRecord> GetMakeCardRecordList(string beginTime, string endTime)
        {
            string strSql = @"select m.CardNo,OptTime,opt.OptName,t.TypeName CardTypeName from MakeCardLog m 
                                left join CardType t on m.CardType=t.CardType 
                                left join OperatorInfo opt on m.OptNo = opt.OptNo 
                                where 1=1  ";

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            strSql += " order by OptTime";
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<MakeCardRecord>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取白名单卡列表
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<WhiteCard> GetWhiteCardList(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"select b.stationname,opt.OptName,a.MakeTime optTime,a.* from WhiteListCard a 
                                left outer join stationinfo b on a.StationNo=b.StationNo 
                                left outer join OperatorInfo opt on a.OptNo=opt.OptName Where 1=1";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            strSql += " order by OptTime";
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };

            return DBContext.Query<WhiteCard>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// PSAM卡信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<PSAMCard> GetPSAMCardList(string beginTime, string endTime)
        {
            string strSql = @"select StartTime as BeginDate,ValidTime as EndDate,MakeTime as OptTime,* from PSAMCardInfo where 1=1  ";

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and MakeTime >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and MakeTime <= @ETime";
            }
            strSql += " order by MakeTime";
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<PSAMCard>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取油站清存汇总信息
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="shiftNo"></param>
        /// <returns></returns>
        public IList<OilEmpCardSum> GetOilEmpCardSum(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT '员工卡' as CardTypeName,count(*) as CountSum,isnull(sum(qty),0) as QtySum,isnull(sum(amn),0) as MoneySum FROM OilTrade a WHERE 
                                T_TYPE IN (0,1,2,4) AND card_type NOT IN ('00', '01', '99') AND ASN<>'00000000000000000000'  
                                {0}
                                union
                                SELECT '非卡' as CardTypeName,count(*) as CountSum,isnull(sum(qty),0) as QtySum,isnull(sum(amn),0) as MoneySum FROM OilTrade a WHERE  
                                T_TYPE=7 {1}";
            string strLimit = "";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strLimit += " and a.stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strLimit += " and a.Mach_Time >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strLimit += " and a.Mach_Time <= @ETime";
            }
            strSql = string.Format(strSql, strLimit, strLimit);
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };

            return DBContext.Query<OilEmpCardSum>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 查询优惠记录
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="preState"></param>
        /// <param name="preId"></param>
        /// <returns></returns>
        public IList<CardPreRecord> GetCardPreRecord(string cardNo, string beginTime, string endTime, int preState, int preId)
        {
            string strSql = @"select cf.AccName AccName,u.AccNo ,* from PreEndPrice p 
                                left join UserCardInfo u on p.Cardno=u.CardNo 
                                left join CustomerInfo c on u.AccNo = c.AccNo 
                                left join CustomerInfo cf on cf.accNo = c.FatherAccNo where 1=1  ";

            if (preId >= 0)
            {
                strSql += " and preId = @preId";
            }
            if (preState >= 0)
            {
                strSql += " and State = @preState";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and PreTime >= @STime";
            }
            if (!string.IsNullOrEmpty(cardNo))
            {
                strSql += " and p.CardNo like @CardNo";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and PreTime <= @ETime";
            }
            strSql += " order by PreTime";
            var sqlParams = new
            {
                preState,
                preId,
                cardNo = "%" + cardNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<CardPreRecord>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 检索卡号
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        public IList<CardSearch> CardSearch(string cardNo)
        {
            string strSql = @"select CardNo from UserCardInfo where 1=1  ";



            if (!string.IsNullOrEmpty(cardNo))
            {
                strSql += " and CardNo like @CardNo";
            }

            strSql += " order by cardNo";
            var sqlParams = new
            {
                cardNo = "%" + cardNo
            };
            return DBContext.Query<CardSearch>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取明折明扣纪录
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<MZMKRecord> GetMZMKRecord(string cardNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT a.ASN as CardNo,b.HolderName,a.Qty, a.Money_Sale, a.Money_Pre,
                            case a.Flag_Sign when 1 then '实时优惠' when 2 then '返还优惠' else '未优惠' end as Flag_Sign,a.Mach_Time,a.stationno  
                            FROM OilTradeUser AS a LEFT OUTER JOIN UserCardInfo AS b ON a.ASN = b.CardNo 
                            where a.Money_Pre<>0 ";


            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and a.Mach_Time >= @STime";
            }
            if (!string.IsNullOrEmpty(cardNo))
            {
                strSql += " and a.ASN like @CardNo";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and a.Mach_Time <= @ETime";
            }
            strSql += " order by a.Mach_Time";
            var sqlParams = new
            {

                cardNo = "%" + cardNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<MZMKRecord>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油站调价记录
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<StationChangePrice> GetStationChangePriceRecord(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"select stationno,terminal,oil_code,oil_name,mach_time,flow_no,
                            (select top 1 price from trade t2 where t2.terminal=t.terminal and t2.stationno=t.stationno and t2.mach_time < t.mach_time and t_type=0 order by mach_time desc) oldPrice,
                            (select top 1 price from trade t2 where t2.terminal=t.terminal and t2.stationno=t.stationno and t2.mach_time > t.mach_time and t_type=0 order by mach_time) newPrice,
                            (select top 1 flow_no from trade t2 where t2.terminal=t.terminal and t2.stationno=t.stationno and t2.mach_time < t.mach_time and t_type=0 order by mach_time desc) oldFlowNo,
                            (select top 1 flow_no from trade t2 where t2.terminal=t.terminal and t2.stationno=t.stationno and t2.mach_time > t.mach_time and t_type=0 order by mach_time) newFlowNo
                            from trade t  where t_type=8 ";
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and stationNo = @StationNo ";
            }

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and mach_time >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and mach_time <= @ETime";
            }
            strSql += " order by stationno,terminal, mach_time";
            var sqlParams = new
            {
                StationNo,
                STime = beginTime,
                ETime = endTime
            };

            return DBContext.Query<StationChangePrice>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取油站最后传输时间
        /// </summary>
        /// <returns></returns>
        public IList<StationInfo> GetStationInfos(StationType stationType)
        {
            string strSql = @"select * from StationInfo where StationType=@StationType order by StationNo";

            var sqlParams = new
            {
                StationType = Convert.ToInt32(stationType)
            };

            return DBContext.Query<StationInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取黑名单列表
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="BlackListTypeID"></param>
        /// <returns></returns>
        public IList<BlackCard> GetBlackList(string cardNo, string beginTime, string endTime, int BlackListTypeID)
        {
            string strSql = @"select * from
                                (
                                Select a.cardNo as cardNo,u.holdername as holderName,a.begintime as OptTime,2 as BlackListTypeID from NewDelBlackList a inner join usercardinfo u on a.cardno=u.cardno 
                                union
                                Select a.cardNo as cardNo,u.holdername as holderName,a.begintime as OptTime,1 as BlackListTypeID from NewAddBlackList a inner join usercardinfo u on a.cardno=u.cardno 
                                union
                                Select a.cardNo as cardNo,u.holdername as holderName,a.begintime as OptTime,0 as BlackListTypeID from BaseBlackList a  inner join usercardinfo u on a.cardno=u.cardno 
                                ) blackList where 1=1";


            if (BlackListTypeID >= 0)
            {
                strSql += " and BlackListTypeID = @BlackListTypeID";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and OptTime >= @STime";
            }
            if (!string.IsNullOrEmpty(cardNo))
            {
                strSql += " and CardNo like @CardNo";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and OptTime <= @ETime";
            }
            strSql += " order by CardNo";
            var sqlParams = new
            {
                BlackListTypeID,
                cardNo = "%" + cardNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<BlackCard>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取最新黑名单校验结果
        /// </summary>
        /// <returns></returns>
        public IList<BlackListCheck> GetBlackListCheckList()
        {
            string strSql = @" select* from
                                (
                                select StationNo, BlackListType, MAX(id) maxResultID from BlackListResult group by StationNo, BlackListType
                                ) s left join BlackListResult c on s.StationNo = c.StationNo and s.maxResultID = c.id
                                order by s.StationNo,c.BlackListType";
            var sqlParams = new
            {

            };
            return DBContext.Query<BlackListCheck>(strSql, sqlParams).ToList();

        }

        /// <summary>
        /// 获取当前黑名单版本信息
        /// </summary>
        /// <returns></returns>
        public BlackListVersion GetBlackListVersion()
        {
            string strSql = @"select BlackVer,AddBlackVer,DelBlackVer from SYSCONF where InfoID = 1";
            var sqlParams = new
            {

            };
            var blackListVersions = DBContext.Query<BlackListVersion>(strSql, sqlParams).ToList();
            if (blackListVersions.Count > 0)
                return blackListVersions[0];
            return new BlackListVersion();
        }
        /// <summary>
        /// 获取单位的金额统计
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustMoneySum> GetCustMoneySum(string beginTime, string endTime)
        {
            string strSql = @" exec [up_allsettle_accquery] @STime,@ETime,-1,'','' ";

            string sTime = "";
            string eTime = "";

            if (!string.IsNullOrEmpty(beginTime))
            {
                sTime = beginTime;
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                eTime = endTime;
            }
            var sqlParams = new
            {
                STime = sTime,
                ETime = eTime
            };
            return DBContext.Query<CustMoneySum>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取单位积分统计信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustScoreSum> GetCustScoreSum(string beginTime, string endTime)
        {
            string strSql = @" exec [up_AllPoint] @STime,@ETime";

            string sTime = "";
            string eTime = "";

            if (!string.IsNullOrEmpty(beginTime))
            {
                sTime = beginTime;
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                eTime = endTime;
            }
            var sqlParams = new
            {
                STime = sTime,
                ETime = eTime
            };
            return DBContext.Query<CustScoreSum>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取卡片出入库记录
        /// </summary>
        ///<param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CardInout> GetCardInoutRecord(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"exec up_CardManagement @StationNo,@STime,@ETime";
            string sNo = "";
            string sTime= "";
            string eTime = "";
            if (!string.IsNullOrEmpty(StationNo))
            {
                sNo = StationNo;
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                sTime = beginTime;
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                eTime = endTime;
            }
            var sqlParams = new
            {
                STime = sTime,
                ETime = eTime,
                StationNo = sNo
            };
            return DBContext.Query<CardInout>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取支票接收记录
        /// </summary>
        ///<param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<ChequeReceive> GetChequeReceiveRecord(string StationNo, string beginTime, string endTime)
        {
            string strSql = @"SELECT     a.ChequeNo, a.ChequeMoney, a.ReceiveDate, CASE ISNULL(Flag_effc, 0) WHEN 0 THEN '否' WHEN 1 THEN '是' END AS IsEffctiveName, 
                    CASE ISNULL(Flag_return, 0) WHEN 0 THEN '否' WHEN 1 THEN '是' END AS IsReturnName, a.AccNo, a.AccName, a.OptNo_receive OptNo, d.OptName, 
                    a.StationNo 
                    FROM         ChequeReceive AS a LEFT OUTER JOIN 
                    StationInfo AS b ON a.StationNo = b.StationNo LEFT OUTER JOIN 
                    CustomerInfo AS c ON c.AccNo = a.AccNo LEFT OUTER JOIN 
                    OperatorInfo AS d ON a.OptNo_receive = d.OptNo 
                    WHERE     (1 = 1) ";
       
            if (!string.IsNullOrEmpty(StationNo))
            {
                strSql += " and a.StationNo = @StationNo and bStationType=1 ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and a.ReceiveDate >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and a.ReceiveDate <= @ETime";
            }
            strSql += " order by a.ReceiveDate";
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                StationNo
            };

            return DBContext.Query<ChequeReceive>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取日结信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<SettleInfo> GetAllSettle(string beginTime, string endTime)
        {
            string strSql = @"exec up_allsettle @STime,@ETime,@IsDayRect,@OptTime,@OptNo";

            string sTime = "";
            string eTime = "";
  
            if (!string.IsNullOrEmpty(beginTime))
            {
                sTime = beginTime;
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                eTime = endTime;
            }
            var sqlParams = new
            {
                STime = sTime,
                ETime = eTime,
                IsDayRect = "0",
                OptTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                OptNo = "0001"
            };
            return DBContext.Query<SettleInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<DeductUpdateLog> GetDeductUpdateLog(string beginTime, string endTime)
        {
            string strSql = @"SELECT * FROM ModifyDeductLog a WHERE (1=1)  ";

     

            if (!string.IsNullOrEmpty(beginTime))
            {
                strSql += " and a.OptTime>= STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strSql += " and a.OptTime<= ETime";
            }
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<DeductUpdateLog>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cardNo"></param>
        /// <param name="onlyUnBalance"></param>
        /// <returns></returns>
        public IList<UserCardBalance> GetUserCardBalance(string beginTime, string endTime, string cardNo, int onlyUnBalance)
        {
            string strSql = @"exec up_usercardbalance @STime,@ETime,@SelectSQL";

            string sTime = "";
            string eTime = "";

            if (!string.IsNullOrEmpty(beginTime))
            {
                sTime = beginTime;
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                eTime = endTime;
            }

            string strSelectSQL = "select * from #tmpUserBalance where 1=1 ";
            if (!string.IsNullOrEmpty(cardNo))
            {
                strSelectSQL +=" and cardNo like '%" + cardNo + "%'";
            }

            if (onlyUnBalance > 0)
            {
                strSelectSQL += " and difference <>0 ";
            }
            strSelectSQL += " order by difference desc,cardNo";
            var sqlParams = new
            {
                STime = sTime,
                ETime = eTime,
                SelectSQL = strSelectSQL
            };
            return DBContext.Query<UserCardBalance>(strSql, sqlParams).ToList();
        }


        /// <summary>
        /// 按单价合计交易累计
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<TradeSumGroupByPrice> GetTradeSumGroupByPrice(string beginTime, string endTime, string stationNo)
        {
            string strSql = @"select stationno,oil_code,price,pay_way,Sum(qty) SumQty,Sum(money)SumMoney from (
                    select t.stationno,oil_code,price,pay_way,qty ,money ,
                    case  when (u.AccNo is null) then 'emp' when RTRIM(u.AccNo)='00000000000000000000' then 'user' else 'cust' end as cardAcc,
                    case when (c.customerPayType = 1) then 1 else 0 end IsJiZhang
                    from trade t 
                    left join UserCardInfo u on t.card_no = u.CardNo
                    left join CustomerInfo c on u.AccNo = c.AccNo where 1=1 and money >0 and price >0 {0}) t group by stationno,oil_code,price,pay_way order by stationno,oil_code,price,pay_way ";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and t.stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and t.mach_time >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and t.mach_time <= @ETime";
            }
            strSql = string.Format(strSql,strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                stationNo
            };

            return DBContext.Query<TradeSumGroupByPrice>(strSql, sqlParams).ToList();
        }

        /// <summary>
        /// 获取开票纪录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="invoiceType"></param>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        public IList<InvoiceTrade> GetInvoiceTrade(string beginTime, string endTime, string stationNo, int invoiceType, string cardNo)
        {
            string strSql = @"SELECT a.*,b.HolderName FROM Invoice_OilTrade AS a  
                                LEFT JOIN  UserCardInfo AS b ON a.ASN = b.CardNo WHERE 1=1 ";
            string strWhere = "";
            if (!string.IsNullOrEmpty(stationNo))
            {
                strWhere += " and stationNo = @stationNo ";
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and mach_time >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and mach_time <= @ETime";
            }
            if (!string.IsNullOrEmpty(cardNo))
            {
                cardNo += " and ASN like  @CardNo";
            }
            if (invoiceType > 1)
            {
                cardNo += " and Invoice_type = @Invoice_type";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                STime = beginTime,
                ETime = endTime,
                stationNo,
                CardNo = "%" + cardNo,
                Invoice_type = invoiceType
            };

            return DBContext.Query<InvoiceTrade>(strSql, sqlParams).ToList();
        }

      
    }
}
