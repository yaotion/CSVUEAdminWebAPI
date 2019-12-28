using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Card
{
    /// <summary>
    /// 用户卡仓储操作接口
    /// </summary>
    public interface ICardRepository
    {
        /// <summary>
        /// 获取用户卡售卡记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserSaleTrade> GetUserSaleTrade(string stationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取用户卡补卡记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserRecardRecord> GetUserRecardRecord(string stationNo, string beginTime, string endTime);
        /// <summary>
        /// 获取用户卡挂失记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserLossCardRecord> GetUserLossCardRecord(string stationNo, string beginTime, string endTime);
        /// <summary>
        /// 获取用户解挂记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserUnLossCardRecord> GetUserUnLossCardRecord(string stationNo, string beginTime, string endTime);
        /// <summary>
        /// 获取解灰记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserUnGreyCardRecord> GetUserUnGreyCardRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取散户卡储值记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserDepositRecord> GetUserDepositRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取单位客户存钱记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustPayMoneyRecord> GetCustPayMoneyRecord(string stationNo, string beginTime, string endTime);
        /// <summary>
        /// 获取单位客户划账记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustChangeMoneyRecord> GetCustChangeMoneyRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        ///客户卡储值交易
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustDepositRecord> GetCustDepositRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        ///客户卡扣款交易
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustUnDepositRecord> GetCustUnDepositRecord(string stationNo, string beginTime, string endTime);
        /// <summary>
        ///散户卡扣款交易
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserUnDepositRecord> GetUserUnDepositRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        ///单位客户开户记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustCreateRecord> GetCustCreateRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        ///单位客户销户记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustDestroyRecord> GetCustDestroyRecord(string stationNo, string beginTime, string endTime);
        /// <summary>
        ///卡密码修改纪录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserChangePinRecord> GetChangePinRecord(string stationNo, string beginTime, string endTime);


        /// <summary>
        /// 重装卡密码修改记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserReloadPinRecord> GetReloadPinRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        /// 卡信息修改记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CardUpdateRecord> GetCardUpdateRecord(string stationNo, string beginTime, string endTime);
        /// <summary>
        /// 退卡记录查询
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CardReturnRecord> GetCardReturnRecord(string stationNo, string beginTime, string endTime);

        /// <summary>
        /// 挂失记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CardLossRecord> GetCardLossRecord(string stationNo, string beginTime, string endTime, int LossType);

        /// <summary>
        /// 查询用户卡信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserCardInfo> QueryUserCardInfo(string CardNo, string HolderName, string Mobile, string CerNo, string Car, int RetailType, int CardState);

        /// <summary>
        /// 获取用户卡详细信息
        /// </summary>
        /// <param name="CardNo"></param>
        /// <returns></returns>
        bool FindUserCardInfo(string CardNo, out UserCardInfoDetail CardDetail);
        /// <summary>
        /// 查询单位账户信息
        /// </summary>
        /// <param name="AccNo">账户编号</param>
        /// <param name="HelpSign">助记符</param>
        /// <param name="AccName">单位名称</param>
        /// <param name="AccType">账号类型</param>
        /// <returns></returns>
        IList<CustomerInfo> QueryCustomerInfo(string AccNo, string HelpSign, string AccName, int AccType);

        /// <summary>
        /// 查询单位用户卡信息
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<UserCardInfo> QueryCustCardInfo(string AccNo);
        /// <summary>
        /// 获取指定卡号在指定时段的对账单
        /// </summary>
        /// <param name="CardNo">卡号</param>
        /// <param name="beginTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns></returns>
        IList<CardBill> GetCardBillRecord(string CardNo, string beginTime, string endTime);

        /// <summary>
        /// 获取指定卡号在指定时段的对账单
        /// </summary>
        /// <param name="AccNo">卡号</param>
        /// <param name="beginTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns></returns>
        IList<CustBill> GetCustBillRecord(string AccNo, string beginTime, string endTime);

        /// <summary>
        /// 获取用户卡消费纪录
        /// </summary>
        /// <param name="CardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CardTradeRecord> GetCardTradeRecord(string CardNo, string beginTime, string endTime);
        /// <summary>
        /// 获取用户卡积分账单
        /// </summary>
        /// <param name="CardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CardScoreRecord> GetCardScoreRecord(string CardNo, string beginTime, string endTime);
        /// <summary>
        /// 用户卡积分消费记录
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="CardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CardScorePayRecord> GetCardScorePayRecord(string StationNo, string CardNo, string beginTime, string endTime);
        #region 发卡点清算汇总表相关
        /// <summary>
        /// 售卡数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        int GetSaleCardCount(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 挂失数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        int GetLossCardCount(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 开户数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        int GetNewCustomerCount(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 销户数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        int GetDestroyCustomerCount(string StationNo, string beginTime, string endTime);

        /// <summary>
        /// 转账金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetCustChangeMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 反转账金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetCustReChangeMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 储值金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetUserDepositMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 圈提金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetUserReDepositMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 存钱金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetCustomerSaveMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 冲正金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetCustomerReSaveMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 散户退款金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetUserReturnMoneySum(string StationNo, string beginTime, string endTime);

        /// <summary>
        /// 单位销户金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetCustReturnMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 退至单位账号的金额
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        decimal GetCustBackAccMoneySum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 获取客户存钱按账户类型分类统计
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<MoneyGroupSum> GetCustSaveGroupMoneySum(string StationNo, string beginTime, string endTime);


        #endregion  发卡点清算汇总表相关
        /// <summary>
        /// 获取操作日志的分组统计信息
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<FunctionSum> GetOptGroupSum(string StationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取限制账户划账记录
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustChangeLimitRecord> GetCustChangeLimitRecord(string StationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取制卡记录列表
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<MakeCardRecord> GetMakeCardRecordList(string beginTime, string endTime);
        /// <summary>
        /// 获取白名单卡列表
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<WhiteCard> GetWhiteCardList(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// PSAM卡信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<PSAMCard> GetPSAMCardList(string beginTime, string endTime);
        /// <summary>
        /// 获取油站清存汇总信息
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<OilEmpCardSum> GetOilEmpCardSum(string StationNo, string beginTime, string endTime);
        /// <summary>
        /// 查询优惠记录
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="preState"></param>
        /// <param name="preId"></param>
        /// <returns></returns>
        IList<CardPreRecord> GetCardPreRecord(string cardNo, string beginTime, string endTime, int preState, int preId);
        /// <summary>
        /// 检索卡号
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        IList<CardSearch> CardSearch(string cardNo);

        /// 获取明折明扣纪录
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<MZMKRecord> GetMZMKRecord(string cardNo, string beginTime, string endTime);

        /// <summary>
        /// 获取油站调价记录
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<StationChangePrice> GetStationChangePriceRecord(string StationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取油站最后传输时间
        /// </summary>
        /// <returns></returns>
        IList<StationInfo> GetStationInfos(StationType stationType);
        /// <summary>
        /// 获取黑名单列表
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="BlackListTypeID"></param>
        /// <returns></returns>
        IList<BlackCard> GetBlackList(string cardNo, string beginTime, string endTime, int BlackListTypeID);

        /// <summary>
        /// 获取最新黑名单校验结果
        /// </summary>
        /// <returns></returns>
        IList<BlackListCheck> GetBlackListCheckList();

        /// <summary>
        /// 获取当前黑名单版本信息
        /// </summary>
        /// <returns></returns>
        BlackListVersion GetBlackListVersion();
        /// <summary>
        /// 获取单位的金额统计
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustMoneySum> GetCustMoneySum(string beginTime, string endTime);
        /// <summary>
        /// 获取单位积分信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CustScoreSum> GetCustScoreSum(string beginTime, string endTime);
        /// <summary>
        /// 获取卡出入库记录
        /// </summary>
        ///<param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<CardInout> GetCardInoutRecord(string StationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取支票 接收记录
        /// </summary>
        ///<param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<ChequeReceive> GetChequeReceiveRecord(string StationNo, string beginTime, string endTime);

        /// <summary>
        /// 获取日结信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<SettleInfo> GetAllSettle(string beginTime, string endTime);
        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        IList<DeductUpdateLog> GetDeductUpdateLog(string beginTime, string endTime);
        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cardNo"></param>
        /// <param name="onlyUnBalance"></param>
        /// <returns></returns>
        IList<UserCardBalance> GetUserCardBalance(string beginTime, string endTime,string cardNo,int onlyUnBalance);

        /// <summary>
        /// 按单价合计交易累计
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<TradeSumGroupByPrice> GetTradeSumGroupByPrice(string beginTime, string endTime, string stationNo);

        /// <summary>
        /// 获取开票纪录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stationNo"></param>
        /// <param name="invoiceType"></param>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        IList<InvoiceTrade> GetInvoiceTrade(string beginTime, string endTime, string stationNo,int invoiceType,string cardNo);

       
        

    }
}
