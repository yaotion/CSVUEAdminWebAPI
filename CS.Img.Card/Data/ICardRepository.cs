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
        IList<CardLossRecord> GetCardLossRecord(string stationNo, string beginTime, string endTime,int LossType);
        
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
        IList<CustomerInfo> QueryCustomerInfo(string AccNo,string HelpSign,string AccName,int AccType);

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
    }
}
