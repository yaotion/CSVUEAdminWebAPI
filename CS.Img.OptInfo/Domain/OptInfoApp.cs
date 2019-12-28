using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OptInfo
{
    /// <summary>
    /// 操作员信息App接口实现
    /// </summary>
    public class OptInfoApp : IOptInfoApp
    {
        private readonly IOptInfoService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public OptInfoApp(IOptInfoService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }
       
        /// <summary>
        /// 获取操作员信息
        /// </summary>
        /// <returns></returns>
        public IList<OptInfo> GetOptInfoList()
        {
            return _Service.GetOptInfoList();
        }
        /// <summary>
        /// 获取操作员密码
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        public string GetOptPWD(string optNo)
        {
            return _Service.GetOptPWD(optNo);
        }
        /// <summary>
        /// 修改操作员
        /// </summary>
        /// <param name="optInfo"></param>
        public void UpdateOptInfo(OptInfo optInfo)
        {
            _Service.UpdateOptInfo(optInfo);
        }
        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="newPWD"></param>
        public void ResetOptPWD(string optNo, string newPWD)
        {
            _Service.ResetOptPWD(optNo, newPWD);
        }
        /// <summary>
        /// 转换密码
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public string TransPWD(string strText)
        {
            if (string.IsNullOrEmpty(strText))
                return "";
            return MD5PWD(strText);
        }
        /// <summary>
        /// 修改操作员的密码
        /// </summary>
        /// <param name="optInfoResetPWD"></param>
        public bool UpdateOptPassword(OptInfoResetPWD optInfoResetPWD)
        {
            string oldPWD = _Service.GetOptPWD(optInfoResetPWD.OptNo);
            string inputOldPWD = TransPWD(optInfoResetPWD.OldPassword);
           
            if (oldPWD.Trim() != inputOldPWD.Trim())
            {
                return false;
            }
            string newPWD = TransPWD(optInfoResetPWD.NewPassword);
            
            _Service.ResetOptPWD(optInfoResetPWD.OptNo, newPWD);
            return true;
        }
        /// <summary>
        /// 修改操作员
        /// </summary>
        /// <param name="optInfo"></param>
        public void UpdateOptInfoLogic(OptInfoUpdate optInfo)
        {
            using (var tran = _uoWFactory.Create())
            {
                _Service.UpdateOptInfo(optInfo);
                if (optInfo.ResetPWD > 0)
                {
                    _Service.ResetOptPWD(optInfo.OptNo, string.Empty);
                }
                tran.SaveChanges();
            }
        }
        private string MD5PWD(string strText)
        {
            //转为字符数组
            byte[] result = Encoding.Default.GetBytes(strText);
            //使用MD5
            MD5 md5 = new MD5CryptoServiceProvider();
            //加密
            byte[] output = md5.ComputeHash(result);
            //转换为字符串
            return BitConverter.ToString(output).Replace("-", "");
        }
        /// <summary>
        /// 添加操作员
        /// </summary>
        /// <param name="optInfo"></param>
        public void AddOptInfo(OptInfo optInfo)
        {
            if (string.IsNullOrEmpty(optInfo.Pin))
                optInfo.Pin = "";
            else
                optInfo.Pin = MD5PWD(optInfo.Pin);
            _Service.AddOptInfo(optInfo);
        }
        /// <summary>
        /// 删除操作员
        /// </summary>
        /// <param name="optNo"></param>
        public void DeleteOptInfo(string optNo)
        {
            using (var tran = _uoWFactory.Create())
            {
                _Service.ClearOptFunctionList(optNo);
                _Service.DeleteOptInfo(optNo);
                tran.SaveChanges();
            }
        }
        /// <summary>
        /// 获取全部功能列表
        /// </summary>
        /// <returns></returns>
        public List<SystemFunction> GetSystemFunctionList()
        {
            return _Service.GetSystemFunctionList();
        }
        /// <summary>
        /// 获取操作员的权限
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        public List<SystemFunction> GetOptFunctionList(string optNo)
        {
            return _Service.GetOptFunctionList(optNo);
        }
        /// <summary>
        /// 设置操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="systemFunctions"></param>
        public void AddOptFunctionList(string optNo, SystemFunction systemFunctions)
        {
            _Service.AddOptFunctionList(optNo, systemFunctions);
        }
        /// <summary>
        /// 清除操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        public void ClearOptFunctionList(string optNo)
        {
            _Service.ClearOptFunctionList(optNo);
        }
        /// <summary>
        /// 批量修改操作员的权限
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="systemFunctions"></param>
        public void UpdateOptFunctionList(string optNo, List<SystemFunction> systemFunctions)
        {
            using (var tran = _uoWFactory.Create())
            {
                _Service.ClearOptFunctionList(optNo);
                if (systemFunctions != null)
                {
                    foreach (var item in systemFunctions)
                    {
                        _Service.AddOptFunctionList(optNo, item);
                    }
                }
                tran.SaveChanges();
            }
        }
    }
}
