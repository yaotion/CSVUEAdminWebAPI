using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.Img.Utils;

namespace CS.Img.Card
{
    /// <summary>
    /// 卡操作应用层
    /// </summary>
    public class CardApp : ICardApp
    {
        private readonly ICardService _cardService;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cardService"></param>
        /// <param name="uoWFactory"></param>
        public CardApp(ICardService cardService, CSUoWFactory uoWFactory)
        {
            _cardService = cardService;
            _uoWFactory = uoWFactory;
        }
        /// <summary>
        /// 获取用户卡售卡记录
        /// </summary>
        /// <returns></returns>
        public IList<UserSaleTrade> GetUserSaleTrade(string stationNo, string beginTime, string endTime)
        {
            return _cardService.GetUserSaleTrade(stationNo, beginTime, endTime);
        }

        /// <summary>
        /// 获取用户卡补卡记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserRecardRecord> GetUserRecardRecord(string stationNo, string beginTime, string endTime)
        {
            return _cardService.GetUserRecardRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetUserLossCardRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetUserUnLossCardRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetUserUnGreyCardRecord(stationNo, beginTime, endTime);
        }


        /// <summary>
        /// 获取用户卡储值记录
        /// </summary>
        /// <param name="stationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<UserDepositRecord> GetUserDepositRecord(string stationNo, string beginTime, string endTime)
        {
            return _cardService.GetUserDepositRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCustPayMoneyRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCustChangeMoneyRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCustDepositRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCustUnDepositRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetUserUnDepositRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCustCreateRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCustDestroyRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetChangePinRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetReloadPinRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCardUpdateRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCardReturnRecord(stationNo, beginTime, endTime);
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
            return _cardService.GetCardLossRecord(stationNo, beginTime, endTime, LossType);
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
            return _cardService.QueryUserCardInfo(CardNo, HolderName, Mobile, CerNo, Car, RetailType, CardState);
        }
        /// <summary>
        /// 获取用户卡详细信息
        /// </summary>
        /// <param name="CardNo"></param>
        /// <returns></returns>
        public bool FindUserCardInfo(string CardNo, out UserCardInfoDetail CardDetail)
        {
            return _cardService.FindUserCardInfo(CardNo, out CardDetail);
        }
        /// <summary>
        /// 查询单位账户信息
        /// </summary>
        ///<param name="AccNo">账户</param>
        /// <param name="HelpSign">助记符</param>
        /// <param name="AccName">单位名称</param>
        /// <param name="AccType">账号类型</param>
        /// <returns></returns>
        public IList<CustomerInfo> QueryCustomerInfo(string AccNo, string HelpSign, string AccName, int AccType)
        {
            return _cardService.QueryCustomerInfo(AccNo, HelpSign, AccName, AccType);
        }

        /// <summary>
        /// 查询单位用户卡信息
        /// </summary>
        /// <param name="AccNo">单位账号</param>
        /// <returns></returns>
        public IList<UserCardInfo> QueryCustCardInfo(string AccNo)
        {
            return _cardService.QueryCustCardInfo(AccNo);
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
            return _cardService.GetCardBillRecord(CardNo, beginTime, endTime);
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
            return _cardService.GetCustBillRecord(AccNo, beginTime, endTime);
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
            return _cardService.GetCardTradeRecord(CardNo, beginTime, endTime);
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
            return _cardService.GetCardScoreRecord(CardNo, beginTime, endTime);
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
            return _cardService.GetCardScorePayRecord(StationNo, CardNo, beginTime, endTime);
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
            return _cardService.GetSaleCardCount(StationNo, beginTime, endTime);
        }
        /// <summary>
        /// 挂失数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public int GetLossCardCount(string StationNo, string beginTime, string endTime)
        {
            return _cardService.GetLossCardCount(StationNo, beginTime, endTime);
        }
        /// 开户数量
        /// </summary>
        /// <param name="StationNo"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public int GetNewCustomerCount(string StationNo, string beginTime, string endTime)
        {
            return _cardService.GetNewCustomerCount(StationNo, beginTime, endTime);
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
            return _cardService.GetDestroyCustomerCount(StationNo, beginTime, endTime);
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
            return _cardService.GetCustChangeMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetCustReChangeMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetUserDepositMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetUserReDepositMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetCustomerSaveMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetCustomerReSaveMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetUserReturnMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetCustBackAccMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetCustSaveGroupMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetCustReturnMoneySum(StationNo, beginTime, endTime);
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
            return _cardService.GetOptGroupSum(StationNo, beginTime, endTime);
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
            return _cardService.GetCustChangeLimitRecord(StationNo, beginTime, endTime);
        }

        /// <summary>
        /// 查询制卡记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<MakeCardRecord> GetMakeCardRecordList(string beginTime, string endTime)
        {
            return _cardService.GetMakeCardRecordList(beginTime, endTime);
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
            return _cardService.GetWhiteCardList(StationNo, beginTime, endTime);
        }

        /// <summary>
        /// PSAM卡信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<PSAMCard> GetPSAMCardList(string beginTime, string endTime)
        {
            return _cardService.GetPSAMCardList(beginTime, endTime);
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
            return _cardService.GetOilEmpCardSum(StationNo, beginTime, endTime);
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
            return _cardService.GetCardPreRecord(cardNo, beginTime, endTime, preState, preId);
        }
        /// <summary>
        /// 检索卡号
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        public IList<CardSearch> CardSearch(string cardNo)
        {
            return _cardService.CardSearch(cardNo);
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
            return _cardService.GetMZMKRecord(cardNo, beginTime, endTime);

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
            return _cardService.GetStationChangePriceRecord(StationNo, beginTime, endTime);

        }

        /// <summary>
        /// 获取油站最后传输时间
        /// </summary>
        /// <returns></returns>
        public IList<StationInfo> GetStationInfos(StationType stationType)
        {
            return _cardService.GetStationInfos(stationType);
        }

        /// <summary>
        /// 获取油站最后传输时间
        /// </summary>
        /// <returns></returns>
        public StationTransResp GetStationLastTransRecord()
        {
            return _cardService.GetStationLastTransRecord();
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
            return _cardService.GetBlackList(cardNo, beginTime, endTime, BlackListTypeID);
        }

        /// <summary>
        /// 获取最新黑名单校验结果
        /// </summary>
        /// <returns></returns>
        public IList<BlackListCheck> GetBlackListCheckList()
        {
            return _cardService.GetBlackListCheckList();
        }
        /// <summary>
        /// 获取当前黑名单版本信息
        /// </summary>
        /// <returns></returns>
        public BlackListVersion GetBlackListVersion()
        {
            return _cardService.GetBlackListVersion();
        }

        /// <summary>
        /// 获取单位的金额统计
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustMoneySum> GetCustMoneySum(string beginTime, string endTime)
        {
            return _cardService.GetCustMoneySum(beginTime, endTime);
        }
        /// <summary>
        /// 获取单位积分统计信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<CustScoreSum> GetCustScoreSum(string beginTime, string endTime)
        {
            return _cardService.GetCustScoreSum(beginTime, endTime);
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
            return _cardService.GetCardInoutRecord(StationNo, beginTime, endTime);
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
            return _cardService.GetChequeReceiveRecord(StationNo, beginTime, endTime);
        }
        /// <summary>
        /// 获取日结信息
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<SettleInfo> GetAllSettle(string beginTime, string endTime)
        {
            return _cardService.GetAllSettle(beginTime, endTime);
        }
        /// <summary>
        /// 获取日结信息合计
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public SettleSum GetAllSettleSum(string beginTime, string endTime)
        {
            SettleSum sum = new SettleSum();
            var settleList = _cardService.GetAllSettle(beginTime, endTime);
            var filterSettleList = settleList.Where(x=>x.AccNo.Trim() == "ALL");
            foreach (var item in filterSettleList)
            {

                sum.SaveMoney += item.SaveMoney;

                // 优惠返还

                sum.PreMoney += item.PreMoney;

                // 期初单位账户余额

                sum.OldAccBalance += item.OldAccBalance;

                // 期末单位账户余额

                sum.AccBalance += item.AccBalance;

                // 期初卡账余额

                sum.OldCardAccBalance += item.OldCardAccBalance;

                // 期末卡账余额

                sum.CardAccBalance += item.CardAccBalance;

                // 期初单位卡余额

                sum.OldCardBalance += item.OldCardBalance;

                // 期末单位卡余额

                sum.CardBalance += item.CardBalance;

                // 冲正金额

                sum.AccCorrect += item.AccCorrect;

                // 划账金额

                sum.AccViment += item.AccViment;

                // 反划账金额

                sum.AccUnViment += item.AccUnViment;

                // 圈存

                sum.AccDeposit += item.AccDeposit;

                // 扣款

                sum.AccUnDeposit += item.AccUnDeposit;

                // 解灰

                sum.AccUnGrey += item.AccUnGrey;

                // 消费

                sum.AccConsume += item.AccConsume;

                // 销户

                sum.AccDelete += item.AccDelete;

                // 储值

                sum.UserDeposit += item.UserDeposit;
                // 扣款

                sum.UserUnDeposit += item.UserUnDeposit;

                // 解灰

                sum.UserUngrey += item.UserUngrey;

                // 消费

                sum.UserConsume += item.UserConsume;

                // 用户卡优惠返还

                sum.UserPre += item.UserPre;

                // 退卡

                sum.UserReturnCard += item.UserReturnCard;

                // 期初用户卡余额

                sum.OldUserCardBalance += item.OldUserCardBalance;

                // 期末用户卡余额

                sum.UserCardBalance += item.UserCardBalance;

                // 备付金

                sum.PreRefund += item.PreRefund;
                if (item.IsBalance > 0)
                {
                    item.IsBalance = 1;
                }
            }
            sum.nowDate = DateTime.Now.ToString("yyyy-MM-dd");
            return sum;
        }

        /// <summary>
        /// 获取扣款额度修改记录
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public IList<DeductUpdateLog> GetDeductUpdateLog(string beginTime, string endTime)
        {
            return _cardService.GetDeductUpdateLog(beginTime, endTime);
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
            return _cardService.GetUserCardBalance(beginTime, endTime, cardNo, onlyUnBalance);
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
            return _cardService.GetTradeSumGroupByPrice(beginTime, endTime, stationNo);
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
            return _cardService.GetInvoiceTrade(beginTime, endTime, stationNo, invoiceType, cardNo);
        }

       
    }
}
