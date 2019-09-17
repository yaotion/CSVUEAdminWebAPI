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
    public class CardApp :ICardApp  
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
            return _cardService.FindUserCardInfo(CardNo,out CardDetail);
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
            return _cardService.QueryCustomerInfo(AccNo,HelpSign, AccName, AccType);
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
    }
}
