using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Card
{

    /// <summary>
    /// 用户卡挂失记录
    /// </summary>
    public class UserLossCardRecord
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

}
