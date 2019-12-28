using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Card
{
    /// <summary>
    /// 油站类型
    /// </summary>
    public enum StationType
    {
        /// <summary>
        /// 油站
        /// </summary>
        stStation,
        /// <summary>
        /// 发卡点
        /// </summary>
        stSale
    }
    /// <summary>
    /// 用户卡挂失记录
    /// </summary>
    public class UserLossCardRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 售卡时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 挂失原因
        /// </summary>
        public string LossReason { get; set; }
    }

    /// <summary>
    ///用户卡补卡记录
    /// </summary>
    public class UserRecardRecord
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 办理时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 老卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 新卡号 
        /// </summary>
        public string NewCardNo { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
    }

    /// <summary>
    /// 用户卡售卡记录
    /// </summary>
    public class UserSaleTrade
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 售卡时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

        public string cardname { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
    }
    /// <summary>
    ///用户卡解挂记录
    /// </summary>
    public class UserUnLossCardRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 挂原因
        /// </summary>
        public string LossReason { get; set; }
    }

    /// <summary>
    ///解灰记录
    /// </summary>
    public class UserUnGreyCardRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }


        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 解灰金额
        /// </summary>
        public decimal UngreyMoney { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal CardBalance { get; set; }
    }
    /// <summary>
    /// 散户卡储值记录
    /// </summary>
    public class UserDepositRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string cardname { get; set; }
        /// <summary>
        /// 储值金额
        /// </summary>
        public string SaveMoney { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public string CardAmt { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public string BonusMoney { get; set; }
        /// <summary>
        /// 折扣金额
        /// </summary>
        public string DiscountMoney { get; set; }
        /// <summary>
        /// 支付方式编号
        /// </summary>
        public string PAYTYPEID { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PAYTYPE { get; set; }
        /// <summary>
        /// 实收金额
        /// </summary>
        public string SaveMoneyBase { get; set; }


    }
    /// <summary>
    /// 单位客户存钱记录
    /// </summary>
    public class CustPayMoneyRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        public string BussType { get; set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 储值金额
        /// </summary>
        public decimal SaveMoney { get; set; }
        /// <summary>
        /// 赠送金额
        /// </summary>
        public decimal BonusMoney { get; set; }
        /// <summary>
        /// 实付金额
        /// </summary>
        public decimal SaveMoneyBase { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal AccNoAmt { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PAYTYPE { get; set; }
        /// <summary>
        /// 计算类型
        /// </summary>
        public string PaymentMode { get; set; }
    }


    /// <summary>
    /// 单位客户划账记录
    /// </summary>
    public class CustChangeMoneyRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal ChangeMoney { get; set; }
        /// <summary>
        /// 源账户编号
        /// </summary>
        public string SrcAccNo { get; set; }
        /// <summary>
        /// 源账户名称
        /// </summary>
        public string SrcAccName { get; set; }
        /// <summary>
        /// 目标账户编号 
        /// </summary>
        public string DesAccNo { get; set; }
        /// <summary>
        /// 源账户余额
        /// </summary>
        public string SrcAccNoAmt { get; set; }
        /// <summary>
        /// 目标账户余额
        /// </summary>
        public string DesAccNoAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal AccNoAmt { get; set; }
        /// <summary>
        /// 持卡人
        /// </summary>
        public string Master { get; set; }
    }
    /// <summary>
    /// 客户卡储值交易
    /// </summary>
    public class CustDepositRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 单位编号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 储值金额
        /// </summary>
        public decimal DepositMoney { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal CardAmt { get; set; }
        /// <summary>
        /// 卡号 
        /// </summary>
        public string CardNo { get; set; }
        public string Master { get; set; }
        /// <summary>
        /// 单位账户余额
        /// </summary>
        public decimal AccNoAmt { get; set; }
    }
    /// <summary>
    /// 客户卡扣款交易
    /// </summary>
    public class CustUnDepositRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 单位编号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 储值金额
        /// </summary>
        public decimal DepositMoney { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal CardAmt { get; set; }
        /// <summary>
        /// 卡号 
        /// </summary>
        public string CardNo { get; set; }
        public string Master { get; set; }
        /// <summary>
        /// 单位账户余额
        /// </summary>
        public decimal AccNoAmt { get; set; }
    }

    /// <summary>
    /// 散户卡扣款交易
    /// </summary>
    public class UserUnDepositRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人
        /// </summary>
        public string HolderName { get; set; }

        /// <summary>
        /// 扣款金额
        /// </summary>
        public decimal SaveMoney { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal CardAmt { get; set; }

    }
    /// <summary>
    /// 单位客户开户记录
    /// </summary>
    public class CustCreateRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 开户卡
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 银行账号
        /// </summary>
        public string BankAccNo { get; set; }
    }

    /// <summary>
    /// 单位客户销户记录
    /// </summary>
    public class CustDestroyRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 销户账号
        /// </summary>
        public string DestroyAccNo { get; set; }
        /// <summary>
        /// 销户单位
        /// </summary>
        public string DestroyAccName { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal ReturnMoney { get; set; }
    }

    /// <summary>
    ///卡修改密码记录
    /// </summary>
    public class UserChangePinRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string ChangeReason { get; set; }
    }

    /// <summary>
    ///卡修改密码记录
    /// </summary>
    public class UserReloadPinRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string ReloadReason { get; set; }
    }
    /// <summary>
    ///卡信息修改记录
    /// </summary>
    public class CardUpdateRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

    }

    /// <summary>
    /// 退卡记录
    /// </summary>
    public class CardReturnRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal ReturnMoney { get; set; }
        /// <summary>
        /// 退卡原因
        /// </summary>
        public string ReturnReason { get; set; }
        /// <summary>
        /// 返还形式
        /// </summary>
        public string PAYTYPE { get; set; }
    }

    /// <summary>
    /// 挂失记录
    /// </summary>
    public class CardLossRecord
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 挂失原因
        /// </summary>
        public string LossReason { get; set; }
        /// <summary>
        /// 挂失标志，0为挂失，1为有卡退卡，2为无卡退卡
        /// </summary>
        public int ShiftNo { get; set; }
    }

    public class UserCardInfo
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public int HolderCerType { get; set; }
        /// <summary>
        /// 证件类型名称
        /// </summary>
        public string HolderCerTypeName { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string HolderCerNo { get; set; }
        /// <summary>
        /// 有效期开始时间
        /// </summary>
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 有效期结束时间
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 限车牌
        /// </summary>
        public string LimitCar { get; set; }
        /// <summary>
        /// 限油品
        /// </summary>

        public string LimitOil { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal Moneys { get; set; }
        /// <summary>
        /// 卡状态
        /// </summary>
        public int CardState { get; set; }
        /// <summary>
        /// 卡状态名称
        /// </summary>
        public string CardStateName { get; set; }
        /// <summary>
        /// 散户卡级别
        /// </summary>
        public int RetailTypeID { get; set; }
        /// <summary>
        /// 散户卡级别
        /// </summary>
        public int RetailTypeName { get; set; }
        //账户类别 "散户","单位"
        public string AccType { get; set; }

    }

    public class UserCardInfoDetail
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public int HolderCerType { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday { get; set; }
        /// <summary>
        /// 密码提示问题
        /// </summary>
        public string PWDHint { get; set; }
        /// <summary>
        /// 卡账余额
        /// </summary>
        public decimal AccMoney { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string HolderJob { get; set; }
        /// <summary>
        /// 公司名字
        /// </summary>
        public string HolderCompanyName { get; set; }
        /// <summary>
        /// 公司 地址
        /// </summary>
        public string HolderCompanyAddr { get; set; }
        /// <summary>
        /// 公司电话
        /// </summary>
        public string HolderCompanyTelephone { get; set; }
        /// <summary>
        /// 公司 传真
        /// </summary>
        public string HolderCompanyFax { get; set; }
        /// <summary>
        /// 制卡时间
        /// </summary>
        public string MakeTime { get; set; }
        /// <summary>
        /// 是否有密码
        /// </summary>
        public string HasPWDName { get; set; }
        /// <summary>
        /// 密码答案
        /// </summary>
        public string PWDAnswer { get; set; }
        /// <summary>
        /// 证件类型名称
        /// </summary>
        public string HolderCerTypeName { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string HolderCerNo { get; set; }
        /// <summary>
        /// 有效期开始时间
        /// </summary>
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 有效期结束时间
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 限车牌
        /// </summary>
        public string LimitCar { get; set; }
        /// <summary>
        /// 限油品
        /// </summary>

        public string LimitOil { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal Moneys { get; set; }
        /// <summary>
        /// 卡状态
        /// </summary>
        public int CardState { get; set; }
        /// <summary>
        /// 卡状态名称
        /// </summary>
        public string CardStateName { get; set; }
        /// <summary>
        /// 散户卡级别
        /// </summary>
        public int RetailTypeID { get; set; }
        /// <summary>
        /// 散户卡级别
        /// </summary>
        public int RetailTypeName { get; set; }
        //账户类别 "散户","单位"
        public string AccType { get; set; }

    }
    /// <summary>
    /// 单位客户的树装形式
    /// </summary>
    public class CustomerInfoTree
    {
        public string id { get; set; }
        public string label { get; set; }
        public List<CustomerInfoTree> children = new List<CustomerInfoTree>();
    }
    /// <summary>
    /// 单位客户信息
    /// </summary>
    public class CustomerInfo
    {
        // 姓名
        public string HolderName { get; set; }
        // 手机号
        public string TaxCode { get; set; }
        public string CustName { get; set; }
        /// <summary>
        /// 单位账户余额
        /// </summary>
        public string AccMoney { get; set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 所属账户编号
        /// </summary>
        public string FatherAccNo { get; set; }
        /// <summary>
        /// 助记符
        /// </summary>
        public string HelpSign { get; set; }
        /// <summary>
        /// 账户级别
        /// </summary>
        public int AccLevel { get; set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndDate { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string CustCerNo { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 银行账号
        /// </summary>
        public string BankAccNo { get; set; }
    }

    /// <summary>
    /// 用户卡对账单
    /// </summary>
    public class CardBill
    {
        /// <summary>
        /// 站点编号
        /// </summary>
        public string stationno { get; set; }
        /// <summary>
        /// 操作编号
        /// </summary>
        public int TypeID2 { get; set; }
        /// <summary>
        /// 操作名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 升数
        /// </summary>
        public decimal Qty { get; set; }

        public string QtyName { get; set; }

        public string AmnName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal Bal { get; set; }
        /// <summary>
        /// 油站名称
        /// </summary>
        public string StationName { get; set; }
        public int T_Type { get; set; }

        /// <summary>
        /// 加油标志
        /// </summary>
        public string OilCtc { get; set; }
        /// <summary>
        /// 储值标志
        /// </summary>
        public string CTC { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string OilCode { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amn { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string OilName { get; set; }
    }
    /// <summary>
    /// 用户卡对账单统计信息
    /// </summary>
    public class CardBillSum
    {
        /// <summary>
        /// 加油升数
        /// </summary>
        public decimal TradeQtys { get; set; }
        /// <summary>
        /// 加油金额
        /// </summary>
        public decimal TradeMoneys { get; set; }
        /// <summary>
        /// 扣款金额
        /// </summary>
        public decimal DeSaveMoneys { get; set; }
        /// <summary>
        /// 存钱金额
        /// </summary>
        public decimal SaveMoneys { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal PreMoneys { get; set; }
        /// <summary>
        /// 非油品金额
        /// </summary>
        public decimal UnOilMoneys { get; set; }
    }
    /// <summary>
    /// 单位客户账单
    /// </summary>
    public class CustBill
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        public int TypeId1 { get; set; }
        /// <summary>
        /// 业务名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 储值存钱金额
        /// </summary>
        public decimal PayAMN { get; set; }
        /// <summary>
        /// 存钱类型
        /// </summary>
        public string PayType { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public string AccBalance { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 卡账号
        /// </summary>
        public string CardAccNo { get; set; }

        /// <summary>
        /// 卡状态名称
        /// </summary>
        public string CardStateName { get; set; }

        /// <summary>
        /// 划账金额
        /// </summary>

        public decimal ChangeAMN { get; set; }
        /// <summary>
        /// 划账类型
        /// </summary>
        public string ChangeType { get; set; }
        /// <summary>
        /// 卡账余额
        /// </summary>

        public decimal CardAccBalance { get; set; }
        /// <summary>
        /// 持卡人
        /// </summary>

        public string HolderName { get; set; }
        /// <summary>
        /// 储值金额
        /// </summary>
        public decimal DepositAMN { get; set; }
        /// <summary>
        /// 储值类型
        /// </summary>
        public string DepositType { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>

        public decimal ConsumeAMN { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal CardBalance { get; set; }
    }
    /// <summary>
    /// 单位客户账单统计信息
    /// </summary>
    public class CustBillSum
    {

        /// <summary>
        /// 存钱金额
        /// </summary>
        public decimal SaveMoneys { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal PreMoneys { get; set; }
        /// <summary>
        /// 冲正金额
        /// </summary>
        public decimal CorrectMoneys { get; set; }

        /// <summary>
        /// 客户转帐金额
        /// </summary>
        public decimal VirementMoneys { get; set; }

        /// <summary>
        /// UnVirement金额
        /// </summary>
        public decimal UnVirementMoneys { get; set; }
        /// <summary>
        /// 客户储值金额
        /// </summary>
        public decimal DepositMoneys { get; set; }
        /// <summary>
        /// 客户退卡金额
        /// </summary>
        public decimal ReturnMoneys { get; set; }

        /// <summary>
        /// 加油升数
        /// </summary>
        public decimal TradeQtys { get; set; }
        /// <summary>
        /// 加油金额
        /// </summary>
        public decimal TradeMoneys { get; set; }

        /// <summary>
        /// 反储值金额
        /// </summary>
        public decimal UndepositMoneys { get; set; }

    }
    /// <summary>
    /// 用户卡消费纪录
    /// </summary>
    public class CardTradeRecord
    {
        public string TradeType { get; set; }
        public int TypeId2 { get; set; }
        /// <summary>
        /// 升数
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal AMN { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        public decimal BAL { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 油品
        /// </summary>
        public string OilName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 油站名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 操作员工号
        /// </summary>
        public string OptNo { get; set; }

    }
    /// <summary>
    /// 字典定义
    /// </summary>
    public class CardConst
    {
        public static string[] TradeTypeName =
        {
            "正常加油",
            "逃卡",
            "错卡",
            "补扣",
            "补充",
            "上班",
            "下班",
            "非卡",
            "油价接受",
            "卡错拒绝"
        };
    }
    /// <summary>
    /// 积分卡账单
    /// </summary>
    public class CardScoreRecord
    {
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public string OptType { get; set; }
        /// <summary>
        /// 本次积分
        /// </summary>
        public int GoodsCent { get; set; }
        /// <summary>
        /// 剩余积分
        /// </summary>
        public int CurCent { get; set; }
        /// <summary>
        /// 兑换物品
        /// </summary>
        public string GoodsName { get; set; }
    }
    /// <summary>
    /// 积分卡兑奖明细
    /// </summary>
    public class CardScorePayRecord
    {
        /// <summary>
        /// 物品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 物品数量
        /// </summary>
        public string GoodsNum { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNO { get; set; }
        /// <summary>
        /// 消耗积分
        /// </summary>
        public int GoodsCent { get; set; }
        /// <summary>
        /// 积分余额
        /// </summary>
        public int CurCent { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
    }
    /// <summary>
    /// 功能数量分类统计
    /// </summary>
    public class FunctionSum
    {
        /// <summary>
        /// 功能名称
        /// </summary>
        public string FunctionNo { get; set; }
        /// <summary>
        /// 使用数量
        /// </summary>

        public int FunctionCount { get; set; }
    }
    /// <summary>
    /// 金额分组统计
    /// </summary>
    public class MoneyGroupSum
    {
        /// <summary>
        /// 分组名称
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 统计金额
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 限制账户划账记录
    /// </summary>
    public class CustChangeLimitRecord
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油站名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 所属账户
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 操作标志
        /// </summary>
        public int flag { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>

        public string OptName { get; set; }
        /// <summary>
        /// 操作人编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// 单位助记符
        /// </summary>
        public string HelpSign { get; set; }
    }
    /// <summary>
    /// 制卡记录
    /// </summary>
    public class MakeCardRecord
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 卡类型
        /// </summary>
        public string CardTypeName { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        public string OptName { get; set; }

    }
    /// <summary>
    /// 白名单卡
    /// </summary>
    public class WhiteCard
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 站点编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作员名称
        /// </summary>
        public string OptName { get; set; }

    }
    /// <summary>
    /// PSAM卡
    /// </summary>
    public class PSAMCard
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作员名称
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 有效开始时间
        /// </summary>
        public string BeginDate { get; set; }
        /// <summary>
        /// 有效结束时间
        /// </summary>
        public string EndDate { get; set; }
        /// <summary>
        /// 终端机编号
        /// </summary>
        public string TermNo { get; set; }
        /// <summary>
        /// 重置次数
        /// </summary>
        public int RemakeNum { get; set; }
    }
    /// <summary>
    /// 油站清算汇总
    /// </summary>
    public class OilEmpCardSum
    {
        /// <summary>
        /// 卡类型
        /// </summary>
        public string CardTypeName { get; set; }
        /// <summary>
        /// 交易数量
        /// </summary>
        public int CountSum { get; set; }
        /// <summary>
        /// 总升数
        /// </summary>
        public decimal QtySum { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal MoneySum { get; set; }
    }
    /// <summary>
    /// 卡优惠记录
    /// </summary>
    public class CardPreRecord
    {
        ///卡号
        public string CardNo { get; set; }
        /// <summary>
        /// 升
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal PreMoney { get; set; }
        /// <summary>
        /// 优惠时间
        /// </summary>
        public DateTime PreTime { get; set; }
        /// <summary>
        /// 返还状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 优惠类型
        /// </summary>
        public int PreId { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        public string AccNo { get; set; }
    }
    /// <summary>
    /// 检索卡号
    /// </summary>
    public class CardSearch
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
    }
    /// <summary>
    /// 明折明扣纪录
    /// </summary>
    public class MZMKRecord
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 升数
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money_Sale { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal Money_Pre { get; set; }
        /// <summary>
        /// 返还标志
        /// </summary>
        public string Flag_Sign { get; set; }
        /// <summary>
        /// 加油时间
        /// </summary>
        public DateTime Mach_Time { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
    }

    /// <summary>
    /// 油站变价记录
    /// </summary>
    public class StationChangePrice
    {
        /// <summary>
        /// 油站
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油枪
        /// </summary>
        public string Terminal { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string oil_code { get; set; }
        /// <summary>
        /// 油品价格
        /// </summary>
        public string oil_name { get; set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public int flow_no { get; set; }

        /// <summary>
        /// 调价之前的交易流水号
        /// </summary>
        public int oldFlowNo { get; set; }
        /// <summary>
        /// 调价之后的交易流水号
        /// </summary>
        public int newFlowNo { get; set; }
        /// <summary>
        /// 调价之前的单价
        /// </summary>        
        public decimal OldPrice { get; set; }
        /// <summary>
        /// 调价之后的 单价
        /// </summary>
        public decimal NewPrice { get; set; }
        /// <summary>
        /// 加油时间
        /// </summary>
        public DateTime Mach_Time { get; set; }

    }

    /// <summary>
    /// 油站最后传输时间信息
    /// </summary>
    public class StationInfo
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油站名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 最后传输时间
        /// </summary>
        public DateTime LastTransTime { get; set; }
    }
    /// <summary>
    /// 油站最后传输信息返回结构
    /// </summary>
    public class StationTransResp
    {
        /// <summary>
        /// 油站名称列表
        /// </summary>
        public List<string> StationNameList { get; set; }
        /// <summary>
        /// 油站传输时间列表
        /// </summary>
        public List<string> StationTimeList { get; set; }
        /// <summary>
        /// 时间刻度列表
        /// </summary>
        public List<string> StandardTimeList { get; set; }
    }
    /// <summary>
    /// 黑明单卡
    /// </summary>
    public class BlackCard
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 挂失时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 黑名单类型，0基础黑名单，1新增黑名单，2新删黑名单
        /// </summary>
        public int BlackListType { get; set; }
    }
    /// <summary>
    /// 黑名单校验记录
    /// </summary>
    public class BlackListCheck
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 黑名单类型
        /// </summary>
        public int BlackListType { get; set; }
        /// <summary>
        /// 黑名单类型名称
        /// </summary>
        public string BlackListTypeName
        {
            get
            {
                switch (BlackListType)
                {
                    case 0: return "基础黑名单";
                    case 1: return "新增黑名单";
                    case 2: return "新删黑名单";
                    default: return "未知";
                }
            }
        }
        /// <summary>
        /// 油站黑名单版本号
        /// </summary>
        public int BlackListVersion { get; set; }
        /// <summary>
        /// 油站最后更新时间
        /// </summary>
        public DateTime StationUpdateTime { get; set; }
        /// <summary>
        /// 油站最后连接时间
        /// </summary>
        public DateTime PostUpdateTime { get; set; }
        /// <summary>
        /// 同步时差(分钟)
        /// </summary>
        public string TimeSpan
        {
            get
            {
                TimeSpan timeSpan = DateTime.Now - PostUpdateTime;
                if (timeSpan.Days > 0)
                {
                    return string.Format("{0}天{1}小时{2}分{3}秒", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                }
                if (timeSpan.Hours > 0)
                {
                    return string.Format("{0}小时{1}分{2}秒", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                }
                if (timeSpan.Minutes > 0)
                {
                    return string.Format("{0}分{1}秒", timeSpan.Minutes, timeSpan.Seconds);
                }
                if (timeSpan.Seconds > 0)
                {
                    return string.Format("{0}秒", timeSpan.Seconds);
                }
                return "0秒";
            }
        }
        /// <summary>
        /// 是否超时
        /// </summary>
        public string IsTimeout
        {
            get
            {
                TimeSpan timeSpan = DateTime.Now - PostUpdateTime;
                if (timeSpan.TotalMinutes > 5) return "超时";
                if (IsEqual == 0) return "不等";
                return "正常";
            }
        }
        /// <summary>
        /// 版本是否相等
        /// </summary>
        public int IsEqual { get; set; }


    }
    /// <summary>
    /// 黑名单版本
    /// </summary>
    public class BlackListVersion
    {
        /// <summary>
        /// 基础黑名单版本
        /// </summary>
        public int BlackVer { get; set; }
        /// <summary>
        /// 新增黑名单版本
        /// </summary>
        public int AddBlackVer { get; set; }
        /// <summary>
        /// 新删黑名单版本
        /// </summary>
        public int DelBlackVer { get; set; }
    }
    /// <summary>
    /// 单位金额统计
    /// </summary>
    public class CustMoneySum
    {
        /// <summary>
        /// 单位账号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 存钱金额
        /// </summary>
        public decimal SaveMoney { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal PreMoney { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal AccBalance { get; set; }
        /// <summary>
        /// 卡账余额
        /// </summary>
        public decimal CardAccBalance { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal CardBalance { get; set; }
        /// <summary>
        /// 消费
        /// </summary>
        public decimal AccConsume { get; set; }
        /// <summary>
        /// 冲正
        /// </summary>
        public decimal AccCorrect { get; set; }

    }

    /// <summary>
    /// 单位积分统计
    /// </summary>
    public class CustScoreSum
    {
        /// <summary>
        /// 单位账号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 获得积分
        /// </summary>
        public int SavePoint { get; set; }
        /// <summary>
        /// 使用积分
        /// </summary>
        public int UsePoint { get; set; }
        /// <summary>
        /// 剩余积分
        /// </summary>
        public int Bal { get; set; }
    }

    /// <summary>
    /// 卡出入库记录
    /// </summary>
    public class CardInout
    {
        /// <summary>
        /// 站点编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public string OptTime { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 种类
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }
    }

    /// <summary>
    /// 支票接收记录
    /// </summary>
    public class ChequeReceive
    {
        /// <summary>
        /// 单位账号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 支票编号
        /// </summary>
        public string ChequeNo { get; set; }

        /// <summary>
        /// 支票金额
        /// </summary>
        public string ChequeMoney { get; set; }

        /// <summary>
        /// 接收日期
        /// </summary>
        public string ReceiveDate { get; set; }

        /// <summary>
        /// 是否生效
        /// </summary>
        public string IsEffctiveName { get; set; }
        /// <summary>
        /// 是否退票
        /// </summary>
        public string IsReturnName { get; set; }
        /// <summary>
        /// 站点编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        public string OptNo { get; set; }

    }
    /// <summary>
    /// 支票统计信息
    /// </summary>
    public class ChequeSum
    {
        /// <summary>
        /// 全部数量
        /// </summary>
        public int AllCount { get; set; }
        /// <summary>
        /// 生效数量
        /// </summary>
        public int EffectiveCount { get; set; }
        /// <summary>
        /// 未生效数量
        /// </summary>
        public int InEffectiveCount { get; set; }
        /// <summary>
        /// 退票数量
        /// </summary>
        public int ReturnCount { get; set; }
    }
    /// <summary>
    /// 日结信息
    /// P1=客户存钱  + 散户优惠  + 散户储值 + 客户优惠 - 冲正 - 客户消费 - 散户消费 -  客户销户 - 散户退卡 - 散户圈提
    /// C1=期初账户余额+期初卡账余额+期初单位客户卡月+期初散户卡余额
    /// C2=期末账户余额+期末卡账余额+期末单位客户卡月+期末散户卡余额+用户卡账余额(备付金)
    /// SET @C1 = @ALL_SUM_OLDACCBALANCE + @ALL_SUM_OLDCARDACCBALANCE + @ALL_SUM_OLDCARDBALANCE +@ALL_SUM_OLD_USER_CARD_BALANCE
    ///  SET @C2 = @ALL_SUM_ACCBALANCE + @ALL_SUM_CARDACCBALANCE + @ALL_SUM_CARDBALANCE + @ALL_SUM_USERCARDBALANCE + @ALL_SUM_@USER_CARD_ACC
    ///  SET @P1 = @ALL_SUM_SAVEMONEY +@ALL_SUM_USERPRE+ @ALL_SUM_USERDEPOSIT +@ALL_SUM_PREMONEY - @ALL_SUM_ACCCORRECT - @ALL_SUM_ACCCONSUME - @ALL_SUM_USERCONSUME -  @ALL_SUM_ACCDELETE - @ALL_SUM_USERRETURNCARD - @ALL_SUM_USERUNDEPOSIT
    ///  C1 + P1 等于 C2 
    /// </summary>
    public class SettleInfo
    {
        /// <summary>
        /// 单位账号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 存钱金额
        /// </summary>
        public decimal SaveMoney { get; set; }
        /// <summary>
        /// 优惠返还
        /// </summary>
        public decimal PreMoney { get; set; }
        /// <summary>
        /// 期初单位账户余额
        /// </summary>
        public decimal OldAccBalance { get; set; }
        /// <summary>
        /// 期末单位账户余额
        /// </summary>
        public decimal AccBalance { get; set; }
        /// <summary>
        /// 期初卡账余额
        /// </summary>
        public decimal OldCardAccBalance { get; set; }
        /// <summary>
        /// 期末卡账余额
        /// </summary>
        public decimal CardAccBalance { get; set; }
        /// <summary>
        /// 期初单位卡余额
        /// </summary>
        public decimal OldCardBalance { get; set; }
        /// <summary>
        /// 期末单位卡余额
        /// </summary>
        public decimal CardBalance { get; set; }
        /// <summary>
        /// 冲正金额
        /// </summary>
        public decimal AccCorrect { get; set; }
        /// <summary>
        /// 划账金额
        /// </summary>
        public decimal AccViment { get; set; }
        /// <summary>
        /// 反划账金额
        /// </summary>
        public decimal AccUnViment { get; set; }
        /// <summary>
        /// 圈存
        /// </summary>
        public decimal AccDeposit { get; set; }
        /// <summary>
        /// 扣款
        /// </summary>
        public decimal AccUnDeposit { get; set; }
        /// <summary>
        /// 解灰
        /// </summary>
        public decimal AccUnGrey { get; set; }
        /// <summary>
        /// 消费
        /// </summary>
        public decimal AccConsume { get; set; }
        /// <summary>
        /// 销户
        /// </summary>
        public decimal AccDelete { get; set; }
        /// <summary>
        /// 储值
        /// </summary>
        public decimal UserDeposit { get; set; }
        /// <summary>
        /// 扣款
        /// </summary>
        public decimal UserUnDeposit { get; set; }
        /// <summary>
        /// 解灰
        /// </summary>
        public decimal UserUngrey { get; set; }
        /// <summary>
        /// 消费
        /// </summary>
        public decimal UserConsume { get; set; }
        /// <summary>
        /// 用户卡优惠返还
        /// </summary>
        public decimal UserPre { get; set; }
        /// <summary>
        /// 退卡
        /// </summary>
        public decimal UserReturnCard { get; set; }
        /// <summary>
        /// 期初用户卡余额
        /// </summary>
        public decimal OldUserCardBalance { get; set; }
        /// <summary>
        /// 期末用户卡余额
        /// </summary>
        public decimal UserCardBalance { get; set; }
        /// <summary>
        /// 备付金
        /// </summary>
        public decimal PreRefund { get; set; }
        /// <summary>
        /// 是否平衡
        /// </summary>
        public int IsBalance { get; set; }

    }

    /// <summary>
    /// 日结合计
    /// </summary>
    public class SettleSum
    {
        /// <summary>
        /// 存钱金额
        /// </summary>
        public decimal SaveMoney { get; set; }
        /// <summary>
        /// 优惠返还
        /// </summary>
        public decimal PreMoney { get; set; }
        /// <summary>
        /// 期初单位账户余额
        /// </summary>
        public decimal OldAccBalance { get; set; }
        /// <summary>
        /// 期末单位账户余额
        /// </summary>
        public decimal AccBalance { get; set; }
        /// <summary>
        /// 期初卡账余额
        /// </summary>
        public decimal OldCardAccBalance { get; set; }
        /// <summary>
        /// 期末卡账余额
        /// </summary>
        public decimal CardAccBalance { get; set; }
        /// <summary>
        /// 期初单位卡余额
        /// </summary>
        public decimal OldCardBalance { get; set; }
        /// <summary>
        /// 期末单位卡余额
        /// </summary>
        public decimal CardBalance { get; set; }
        /// <summary>
        /// 冲正金额
        /// </summary>
        public decimal AccCorrect { get; set; }
        /// <summary>
        /// 划账金额
        /// </summary>
        public decimal AccViment { get; set; }
        /// <summary>
        /// 反划账金额
        /// </summary>
        public decimal AccUnViment { get; set; }
        /// <summary>
        /// 圈存
        /// </summary>
        public decimal AccDeposit { get; set; }
        /// <summary>
        /// 扣款
        /// </summary>
        public decimal AccUnDeposit { get; set; }
        /// <summary>
        /// 解灰
        /// </summary>
        public decimal AccUnGrey { get; set; }
        /// <summary>
        /// 消费
        /// </summary>
        public decimal AccConsume { get; set; }
        /// <summary>
        /// 销户
        /// </summary>
        public decimal AccDelete { get; set; }
        /// <summary>
        /// 储值
        /// </summary>
        public decimal UserDeposit { get; set; }
        /// <summary>
        /// 扣款
        /// </summary>
        public decimal UserUnDeposit { get; set; }
        /// <summary>
        /// 解灰
        /// </summary>
        public decimal UserUngrey { get; set; }
        /// <summary>
        /// 消费
        /// </summary>
        public decimal UserConsume { get; set; }
        /// <summary>
        /// 用户卡优惠返还
        /// </summary>
        public decimal UserPre { get; set; }
        /// <summary>
        /// 退卡
        /// </summary>
        public decimal UserReturnCard { get; set; }
        /// <summary>
        /// 期初用户卡余额
        /// </summary>
        public decimal OldUserCardBalance { get; set; }
        /// <summary>
        /// 期末用户卡余额
        /// </summary>
        public decimal UserCardBalance { get; set; }
        /// <summary>
        /// 备付金
        /// </summary>
        public decimal PreRefund { get; set; }
        /// <summary>
        /// 是否平衡
        /// </summary>
        public int IsBalance { get; set; }
        /// <summary>
        /// 查询日期
        /// </summary>
        public string nowDate { get; set; }



    }

    /// <summary>
    /// 扣款额度修改记录
    /// </summary>
    public class DeductUpdateLog
    {
        /// <summary>
        /// 单位账号
        /// </summary>
        public string AccNo { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 原额
        /// </summary>
        public decimal OldAmt { get; set; }
        /// <summary>
        /// 新额
        /// </summary>
        public decimal NewAmt { get; set; }

    }
    /// <summary>
    /// 用户卡平衡表
    /// </summary>
    public class UserCardBalance
    {
        /// <summary>
        /// 单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人姓名
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 期初余额
        /// </summary>
        public decimal Balance1 { get; set; }
        /// <summary>
        /// 储值
        /// </summary>
        public decimal Deposit { get; set; }
        /// <summary>
        /// 优惠返还
        /// </summary>
        public decimal Pre { get; set; }
        /// <summary>
        /// 消费
        /// </summary>
        public decimal Consume { get; set; }
        /// <summary>
        /// 扣款
        /// </summary>
        public decimal Undeposit { get; set; }
        /// <summary>
        /// 退卡
        /// </summary>
        public decimal Return { get; set; }
        /// <summary>
        /// 备付金
        /// </summary>
        public decimal Refund { get; set; }
        /// <summary>
        /// 期末余额
        /// </summary>
        public decimal Balance2 { get; set; }
        /// <summary>
        /// 差额
        /// </summary>
        public decimal Difference { get; set; }

    }

    /// <summary>
    /// 按单价合计交易累计
    /// </summary>
    public class TradeSumGroupByPrice
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油品
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public int PAY_WAY { get; set; }
        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
        /// <summary>
        /// 卡单位类型(cust=单位,emp=员工,user=散户)
        /// </summary>
        public string CardAcc { get; set; }
        /// <summary>
        /// 是否为记账(0=否,1=是)
        /// </summary>
        public int IsJiZhang { get; set; }
    }
    /// <summary>
    /// 开票记录查询
    /// </summary>
    public class InvoiceTrade
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string ASN { get; set; }
        /// <summary>
        /// 持卡人
        /// </summary>
        public string HolderName { get; set; }
        /// <summary>
        /// 加油金额
        /// </summary>
        public decimal AMN { get; set; }
        /// <summary>
        /// 加油时间
        /// </summary>
        public DateTime Mach_Time { get; set; }
        /// <summary>
        /// 升
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 开票类型
        /// </summary>
        public int Invoice_type { get; set; }
        /// <summary>
        /// 发票类型名称
        /// </summary>
        public string InvoiceTypeName
        {
            get
            {
                if (Invoice_type == 2)
                {
                    return "未开";
                }
                if (Invoice_type == 3)
                {
                    return "已开";
                }
                return "未知";
            }
        }
    }

    
}
