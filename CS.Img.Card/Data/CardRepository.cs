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
                CardState = CardState
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
                CardNo = CardNo
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
                AccNo = AccNo,
                HelpSign = "%" + HelpSign + "%",
                AccName = "%" + AccName + "%",
                AccType = AccType
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
                CardNo = CardNo,
                STime = beginTime,
                ETime = endTime
            };
            return DBContext.Query<CardBill>(strSql, sqlParams).ToList();
        }
    }
}
