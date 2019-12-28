using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OptInfo
{
  
    /// <summary>
    /// 操作员信息
    /// </summary>
    public class OptInfo
    {
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public string OptLevel { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pin { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int UseFlag { get; set; }
        /// <summary>
        /// 是否超级管理员
        /// </summary>
        public int SuperFlag { get; set; }
        /// <summary>
        /// 所属油站编号
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 所属站点名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 管理卡卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
    }
    /// <summary>
    /// 操作员修改信息
    /// </summary>
    public class OptInfoUpdate : OptInfo
    {
        /// <summary>
        /// 是否重置密码0:否,1:是
        /// </summary>
        public int ResetPWD { get; set; }
    }
    /// <summary>
    /// 操作员重置密码
    /// </summary>
    public class OptInfoResetPWD
    {
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 旧密码
        /// </summary>
        public string OldPassword { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }
    }
    /// <summary>
    /// 系统功能列表
    /// </summary>
    public class SystemFunction
    {
        /// <summary>
        /// 功能编号
        /// </summary>
        public string FunctionNo { get; set; }
        /// <summary>
        /// 功能类型(0:中心报表,1:发卡点报表)
        /// </summary>
        public int FunctionType { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        public string FunctionName { get; set; }
    }
    /// <summary>
    /// 操作员的权限列表
    /// </summary>
    public class OptFuntionList
    {
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作员编号
        /// </summary>
        public List<SystemFunction> FunctionList {get;set;}
    }
}
