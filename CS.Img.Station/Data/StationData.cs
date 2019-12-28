using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Station
{
    /// <summary>
    /// 油罐报警记录
    /// </summary>
    public class TankStor
    {
        /// <summary>
        /// 油罐编号
        /// </summary>
        public string Tank_No { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OilColor { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string St_no { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_name { get; set; }
        /// <summary>
        /// 油高
        /// </summary>
        public decimal Oil_height { get; set; }
        /// <summary>
        /// 油温
        /// </summary>
        public decimal Oil_temp { get; set; }
        /// <summary>
        /// 水高
        /// </summary>
        public decimal Water_height { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Sta { get; set; }
        /// <summary>
        /// 存油
        /// </summary>
        public decimal Inven_volume { get; set; }
        /// <summary>
        /// 可添
        /// </summary>
        public decimal Empty_volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Tank_diameter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Low_temp { get; set; }
        /// <summary>
        /// /
        /// </summary>
        public decimal High_temp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Low_oil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Low_low_oil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal High_oil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal High_high_oil { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal High_water { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal HeightScale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal LowScale { get; set; }
    }
    /// <summary>
    /// 油站日报按枪号
    /// </summary>
    public class RptDayByMach
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 枪号
        /// </summary>
        public string Terminal { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 初始泵码数
        /// </summary>
        public decimal Pump_Qty1 { get; set; }
        /// <summary>
        /// 结束泵码数
        /// </summary>
        public decimal Pump_Qty2 { get; set; }
        /// <summary>
        /// 升累计
        /// </summary>
        public decimal Sum_Qty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal Sum_Money { get; set; }
    }
    /// <summary>
    /// 油站日报按枪号
    /// </summary>
    public class RptDayByOil
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }

        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 试机
        /// </summary>
        public decimal SJQtys { get; set; }
        /// <summary>
        /// 试机
        /// </summary>
        public decimal SJMoneys { get; set; }
        /// <summary>
        /// 现金
        /// </summary>
        public decimal XJQtys { get; set; }
        /// <summary>
        /// 现金
        /// </summary>
        public decimal XJMoneys { get; set; }
        /// <summary>
        /// 邮票
        /// </summary>
        public decimal YPQtys { get; set; }
        /// <summary>
        /// 邮票
        /// </summary>
        public decimal YPMoneys { get; set; }
        /// <summary>
        /// 银行卡
        /// </summary>
        public decimal YHKQtys { get; set; }
        /// <summary>
        /// 银行卡
        /// </summary>
        public decimal YHKMoneys { get; set; }

        /// <summary>
        /// 信用卡
        /// </summary>
        public decimal XYKQtys { get; set; }
        /// <summary>
        /// 信用卡
        /// </summary>
        public decimal XYKMoneys { get; set; }


        /// <summary>
        /// 记账
        /// </summary>
        public decimal JZQtys { get; set; }
        /// <summary>
        /// 记账
        /// </summary>
        public decimal JZMoneys { get; set; }

        /// <summary>
        /// 其他
        /// </summary>
        public decimal QTQtys { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public decimal QTMoneys { get; set; }
        /// <summary>
        /// 其他1
        /// </summary>
        public decimal QT1Qtys { get; set; }
        /// <summary>
        /// 其他1
        /// </summary>
        public decimal QT1Moneys { get; set; }
        /// <summary>
        /// 微信
        /// </summary>
        public decimal WXQtys { get; set; }
        /// <summary>
        /// 微信
        /// </summary>
        public decimal WXMoneys { get; set; }
        /// <summary>
        /// 支付宝
        /// </summary>
        public decimal ZFBQtys { get; set; }
        /// <summary>
        /// 支付宝
        /// </summary>
        public decimal ZFBMoneys { get; set; }
        /// <summary>
        /// 银联
        /// </summary>
        public decimal YLQtys { get; set; }
        /// <summary>
        /// 银联
        /// </summary>
        public decimal YLMoneys { get; set; }

    }
    /// <summary>
    /// 油站日报按枪号
    /// </summary>
    public class RptDayByTank
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }

        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 油罐编号
        /// </summary>
        public string Tank_No { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Start_li { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal End_li { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Add_li { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Sale_li { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Lost_li { get; set; }
    }
    /// <summary>
    /// 油站日报按加油员加油量
    /// </summary>
    public class RptDayByEmpQty
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        /// 总加油量
        /// </summary>
        public decimal Sum_Qty { get; set; }
    }
    /// <summary>
    /// 油站日报按加油员金额
    /// </summary>
    public class RptDayByEmpMoney
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 现金
        /// </summary>
        public decimal XJMoneys { get; set; }      
        /// <summary>
        /// 邮票
        /// </summary>
        public decimal YPMoneys { get; set; }       
        /// <summary>
        /// 银行卡
        /// </summary>
        public decimal YHKMoneys { get; set; }             
        /// <summary>
        /// 记账
        /// </summary>
        public decimal JZMoneys { get; set; }        
        /// <summary>
        /// 其他
        /// </summary>
        public decimal QTMoneys { get; set; }        
        /// <summary>
        /// 其他1
        /// </summary>
        public decimal QT1Moneys { get; set; }        

    }
    /// <summary>
    /// 卸油记录
    /// </summary>
    public class OilAdd
    {
        /// <summary>
        /// 卸油时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 油罐编号
        /// </summary>
        public string Tank_no { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_name { get; set; }
        /// <summary>
        /// 开始油高
        /// </summary>
        public decimal Start_oilh { get; set; }
        /// <summary>
        /// 开始升数
        /// </summary>
        public decimal Start_vol { get; set; }
        /// <summary>
        /// 开始温度
        /// </summary>
        public decimal Start_temp { get; set; }
        /// <summary>
        /// 开始密度
        /// </summary>
        public decimal Start_dens { get; set; }
        /// <summary>
        /// 开始重量
        /// </summary>
        public decimal Start_wt { get; set; }
        /// <summary>
        /// 结束油高
        /// </summary>
        public decimal End_oilh { get; set; }
        /// <summary>
        /// 结束升数
        /// </summary>
        public decimal End_vol { get; set; }
        /// <summary>
        /// 结束温度
        /// </summary>
        public decimal End_temp { get; set; }
        /// <summary>
        /// 结束密度
        /// </summary>
        public decimal End_dens { get; set; }
        /// <summary>
        /// 结束重量
        /// </summary>
        public decimal End_wt { get; set; }
        /// <summary>
        /// 卸油量升数
        /// </summary>
        public decimal Qty_vol { get; set; }
        /// <summary>
        /// 卸油量重量
        /// </summary>
        public decimal Qty_wt { get; set; }
        /// <summary>
        /// 卸油单升数
        /// </summary>
        public decimal Doc_vol { get; set; }
        /// <summary>
        /// 卸油单密度
        /// </summary>
        public decimal Doc_dens { get; set; }
        /// <summary>
        /// 卸油单重量
        /// </summary>
        public decimal Doc_wt { get; set; }
        /// <summary>
        /// 损益升数
        /// </summary>
        public decimal Lost_vol { get; set; }
        /// <summary>
        /// 损益重量
        /// </summary>
        public decimal Lost_wt { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Start_time { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime End_time { get; set; }
    }
    /// <summary>
    /// 油品信息修改纪录
    /// </summary>
    public class OilChange
    {
        /// <summary>
        /// 传输批次
        /// </summary>
        public string TransOrder { get; set; }
        /// <summary>
        /// 油品代号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 油品简称
        /// </summary>
        public string OilBrief_name { get; set; }
        /// <summary>
        /// 密度
        /// </summary>
        public decimal Density { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ChangeTime { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
    }
    /// <summary>
    /// 油机信息
    /// </summary>
    public class Machine
    {
        /// <summary>
        /// 传输批次
        /// </summary>
        public string TransOrder { get; set; }
        /// <summary>
        /// 油枪编号
        /// </summary>
        public string Terminal { get; set; }
        /// <summary>
        /// 油机编号
        /// </summary>
        public int Mach_No { get; set; }
        /// <summary>
        /// 串口号
        /// </summary>
        public int Port_No { get; set; }
        /// <summary>
        /// 油机类型
        /// </summary>
        public string Mach_Type     { get; set; }
        /// <summary>
        /// 油罐编号
        /// </summary>
        public string Tank_No { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ChangeTime { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
    }
    /// <summary>
    /// 油罐信息
    /// </summary>
    public class Tank
    {
        /// <summary>
        /// 传输批次
        /// </summary>
        public string TransOrder { get; set; }
        /// <summary>
        /// 油罐编号
        /// </summary>
        public string Tank_No { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }

        /// <summary>
        /// 直径
        /// </summary>
        public decimal Tank_Diameter { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public decimal Tank_Length { get; set; }
        
        /// <summary>
        /// 最大容积
        /// </summary>
        public decimal Max_Volume { get; set; }
        /// <summary>
        /// 高油位
        /// </summary>
        public decimal High_Oil { get; set; }
        /// <summary>
        /// 高高油位
        /// </summary>
        public decimal High_High_Oil { get; set; }
        /// <summary>
        /// 低油位
        /// </summary>
        public decimal Low_Oil { get; set; }
        /// <summary>
        /// 低低油位
        /// </summary>
        public decimal Low_Low_Oil { get; set; }
        /// <summary>
        /// 高水位报警高度
        /// </summary>
        public decimal High_Water { get; set; }
        /// <summary>
        /// 高温
        /// </summary>
        public decimal High_Temp { get; set; }
        /// <summary>
        /// 低温
        /// </summary>
        public decimal Low_Temp { get; set; }
        /// <summary>
        /// 油位
        /// </summary>
        public decimal Oil_Offset { get; set; }
        /// <summary>
        /// 水位
        /// </summary>
        public decimal Water_Offset { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ChangeTime { get; set; }
        /// <summary>
        /// 油站名称
        /// </summary>
        public string StationNo { get; set; }
    }
    /// <summary>
    /// 操作日志
    /// </summary>
    public class OperLog
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        public string FunctionName { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public int AutoID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

    }
    /// <summary>
    /// 油站班报
    /// </summary>
    public class TankShift
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 自增编号
        /// </summary>
        public string AutoId { get; set; }
        /// <summary>
        /// 班序号
        /// </summary>
        public string ShiftOrder { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        ///商务日期
        /// </summary>
        public string BussDate { get; set; }
        /// <summary>
        /// 班号
        /// </summary>
        public string Shift_No { get; set; }
        /// <summary>
        /// 记录添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 油罐号
        /// </summary>
        public string Tank_No { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }

        /// <summary>
        /// 期初油高
        /// </summary>
        public decimal Start_Oilh { get; set; }
        /// <summary>
        /// 期初体积
        /// </summary>
        public decimal Start_Vol { get; set; }
        /// <summary>
        /// 期初温度
        /// </summary>
        public decimal Start_Temp { get; set; }
        /// <summary>
        /// 期初密度
        /// </summary>
        public decimal Start_Dens { get; set; }
        /// <summary>
        /// 期初重量
        /// </summary>
        public decimal Start_Wt { get; set; }
        /// <summary>
        /// 期末油高
        /// </summary>
        public decimal End_Oilh { get; set; }
        /// <summary>
        /// 期末体积
        /// </summary>
        public decimal End_Vol { get; set; }
        /// <summary>
        /// 期末温度
        /// </summary>
        public decimal End_Temp { get; set; }
        /// <summary>
        /// 期末密度
        /// </summary>
        public decimal End_Dens { get; set; }
        /// <summary>
        /// 期末重量
        /// </summary>
        public decimal End_Wt { get; set; }
        /// <summary>
        /// 卸油单密度
        /// </summary>
        public decimal Doc_Dens { get; set; }
        /// <summary>
        ///卸油单体积
        /// </summary>
        public decimal Doc_Vol { get; set; }
        /// <summary>
        /// 卸油单重量
        /// </summary>
        public decimal Doc_Wt { get; set; }
        /// <summary>
        ///卸油量密度
        /// </summary>
        public decimal Qty_Dens { get; set; }
        /// <summary>
        /// 卸油量体积
        /// </summary>
        public decimal Qty_Vol { get; set; }
        /// <summary>
        /// 卸油量重量
        /// </summary>
        public decimal Qty_Wt { get; set; }
        /// <summary>
        /// 账面数量
        /// </summary>
        public decimal Acco_Vol { get; set; }
        /// <summary>
        /// 账面重量
        /// </summary>
        public decimal Acco_Wt { get; set; }
        /// <summary>
        /// 损益重量
        /// </summary>
        public decimal Loss_Wt { get; set; }
        /// <summary>
        /// 期初泵码值
        /// </summary>
        public decimal Start_Pump { get; set; }
        /// <summary>
        /// 期末泵码值
        /// </summary>
        public decimal End_Pump{ get; set; }
        /// <summary>
        /// 泵码差
        /// </summary>
        public decimal Diff_Pump { get; set; }

    }
    /// <summary>
    /// 本班营业量加油明细
    /// </summary>
    public class TradeShiftNowDetail
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public int Flow_No { get; set; }
        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string PayWayName { get; set; }
        /// <summary>
        /// 枪号
        /// </summary>
        public string Terminal { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 升数
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// 销售金额
        /// </summary>
        public decimal Money_Sale { get; set; }
        /// <summary>
        /// 加油时间
        /// </summary>
        public DateTime Mach_Time { get; set; }
       
    }
    /// <summary>
    /// 本班营业量按油品统计
    /// </summary>
    public class TradeShiftNowByOil
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 升数
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 本班营业量按油枪统计
    /// </summary>
    public class TradeShiftNowByTerminal
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油枪编号
        /// </summary>
        public string Terminal { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 升数
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 当班信息
    /// </summary>
    public class ShiftInfo
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 商务日起
        /// </summary>
        public string Buss_Date { get; set; }
        /// <summary>
        /// 班号
        /// </summary>
        public int Shift_No { get; set; }
    }
    /// <summary>
    /// 油罐报警纪录
    /// </summary>
    public class TankAlarm
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 商务日期
        /// </summary>
        public string Buss_Date { get; set; }
        /// <summary>
        /// 班号
        /// </summary>
        public int Shift_No { get; set; }
        /// <summary>
        /// 油罐
        /// </summary>
        public string Tank_No { get; set; }
        /// <summary>
        /// 油品
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 报警乐星
        /// </summary>
        public string Alarm_Type { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Start_Time { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime End_Time { get; set; }
        /// <summary>
        /// 水高
        /// </summary>
        public decimal Water_Height { get; set; }
        /// <summary>
        /// 油高
        /// </summary>
        public decimal Oil_Height { get; set; }
        /// <summary>
        /// 油温
        /// </summary>
        public decimal Oil_Temp { get; set; }

    }
    /// <summary>
    /// 加油交易
    /// </summary>
    public class Trade
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public int Flow_No { get; set; }
        /// <summary>
        /// 商务日起
        /// </summary>
        public string Buss_Date { get; set; }
        /// <summary>
        /// 班号
        /// </summary>
        public int Shift_No { get; set; }
        /// <summary>
        /// 枪号
        /// </summary>
        public string Terminal { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 升数
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 加油原额
        /// </summary>
        public decimal Money_Sale { get; set; }
        /// <summary>
        /// 加油金额
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal Bal { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public decimal Pay_Way { get; set; }
        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string Way_Name { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        /// 加油时间
        /// </summary>
        public DateTime Mach_Time { get; set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccName { get; set; }
    }
    /// <summary>
    /// 交易查询条件
    /// </summary>
    public class TradeQuery
    {
        /// <summary>
        /// 加油开始时间
        /// </summary>
        public string BeginTime { get; set; }
        /// <summary>
        /// 加油结束时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 商务日起
        /// </summary>
        public string BussDate { get; set; }
        /// <summary>
        /// 班号
        /// </summary>
        public int ShiftNo { get; set; }
        /// <summary>
        /// 油品名称
        /// </summary>
        public string OilCode { get; set; }
        /// <summary>
        /// 油枪号
        /// </summary>
        public string Terminal { get; set; }
        /// <summary>
        /// 支付方式编号
        /// </summary>
        public int Payway { get; set; }
        /// <summary>
        /// 卡类型
        /// </summary>
        public string CardType { get; set; }
        /// <summary>
        /// 交易类型
        /// </summary>
        public int TradeType { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string EmpNo { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 是否包含系统交易
        /// </summary>
        public int SysTrade { get; set; }
    }
    /// <summary>
    /// 加油统计按照交易类型
    /// </summary>
    public class TradeSumByTradeType
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 交易类型
        /// </summary>
        public int TradeType { get; set; }
        /// <summary>
        /// 交易类型名称
        /// </summary>
        public string TradeTypeName { get; set; }
        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 加油统计按照卡号
    /// </summary>
    public class TradeSumByCard
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string Card_no { get; set; }
        /// <summary>
        /// 所属单位名称
        /// </summary>
        public string AccName { get; set; }
        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 加油统计按照卡类型
    /// </summary>
    public class TradeSumByCardType
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 卡类型
        /// </summary>
        public string Card_Type { get; set; }
        /// <summary>
        /// 卡类型名称
        /// </summary>
        public string CardTypeName { get; set; }
        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 加油统计按照员工
    /// </summary>
    public class TradeSumByEmpNo
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 卡类型
        /// </summary>
        public string Emp_No { get; set; }
        
        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 加油统计按照油品
    /// </summary>
    public class TradeSumByOil
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
        ///油品名称
        /// </summary>
        public string Oil_Name { get; set; }
        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 加油统计按照枪号
    /// </summary>
    public class TradeSumByTerminal
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 逻辑枪号
        /// </summary>
        public string Terminal { get; set; }

        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 加油统计按照结算方式
    /// </summary>
    public class TradeSumByPayWay
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 结算方式编号
        /// </summary>
        public int Pay_Way { get; set; }
        /// <summary>
        /// 结算方式名称
        /// </summary>
        public string Way_Name { get; set; }

        /// <summary>
        /// 升累计
        /// </summary>
        public decimal SumQty { get; set; }
        /// <summary>
        /// 金额累计
        /// </summary>
        public decimal SumMoney { get; set; }
    }
    /// <summary>
    /// 综合日报表
    /// </summary>
    public class Rpt_Day_OilTank
    {
        /// <summary>
        /// 油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 油品编号
        /// </summary>
        public string Oil_Code { get; set; }
        /// <summary>
        /// 商务日期
        /// </summary>
        public string Buss_Date { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 试机
        /// </summary>
        public decimal SJMoneys { get; set; }
        /// <summary>
        /// 现金
        /// </summary>
        public decimal XJMoneys { get; set; }
        /// <summary>
        /// 邮票
        /// </summary>
        public decimal YPMoneys { get; set; }
        /// <summary>
        /// 银行卡
        /// </summary>
        public decimal YHKMoneys { get; set; }
        /// <summary>
        /// 信用卡
        /// </summary>
        public decimal XYKMoneys { get; set; }
        /// <summary>
        /// 记账
        /// </summary>
        public decimal JZMoneys { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public decimal QTMoneys { get; set; }
        /// <summary>
        /// 其他1
        /// </summary>
        public decimal QT1Moneys { get; set; }
        /// <summary>
        /// 全部升数
        /// </summary>
        public decimal TotalQtys { get; set; }
        /// <summary>
        /// 全部金额
        /// </summary>
        public decimal TotalMoneys { get; set; }
        /// <summary>
        /// 本月加油
        /// </summary>
        public decimal MonthQtys { get; set; }
        /// <summary>
        /// 结束存量
        /// </summary>
        public decimal End_li { get; set; }
        /// <summary>
        /// 可添百分比
        /// </summary>
        public decimal  CanAdd { get; set; }

    }
    /// <summary>
    /// 员工卡
    /// </summary>
    public class EmpCard
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Emp_Name { get; set; }
        /// <summary>
        /// 员工工号
        /// </summary>
        public string Emp_No { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string Card_No { get; set; }
        /// <summary>
        /// 证件编号
        /// </summary>
        public string CerNo { get; set; }
        /// <summary>
        /// 站点编号
        /// </summary>
        public string StationNo { get; set; }
    }
    /// <summary>
    /// 对账单
    /// </summary>
    public class EmpCardBill
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmpName { get; set; }
        /// <summary>
        /// 期初余额
        /// </summary>
        public decimal Begin_Balance { get; set; }
        /// <summary>
        /// 期末余额
        /// </summary>
        public decimal End_Balance { get; set; }
        /// <summary>
        /// 储值金额
        /// </summary>
        public decimal SaveMoney { get; set; }
        /// <summary>
        /// 扣款金额
        /// </summary>
        public decimal UnSaveMoney { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        public decimal UseMoney { get; set; }
    }
}
