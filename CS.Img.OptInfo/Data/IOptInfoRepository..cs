using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OptInfo
{
    /// <summary>
    /// 操作员信息Repository接口
    /// </summary>
    public interface IOptInfoRepository
    {
        /// <summary>
        /// 获取操作员信息
        /// </summary>
        /// <returns></returns>
        IList<OptInfo> GetOptInfoList();

        /// <summary>
        /// 修改操作员
        /// </summary>
        /// <param name="optInfo"></param>
        void UpdateOptInfo(OptInfo optInfo);
        /// <summary>
        /// 添加操作员
        /// </summary>
        /// <param name="optInfo"></param>
        void AddOptInfo(OptInfo optInfo);
        /// <summary>
        /// 删除操作员
        /// </summary>
        /// <param name="optNo"></param>
        void DeleteOptInfo(string optNo);        
        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="newPWD"></param>
        void ResetOptPWD(string optNo, string newPWD);
        /// <summary>
        /// 获取操作员密码
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        string GetOptPWD(string optNo);
        /// <summary>
        /// 获取全部功能列表
        /// </summary>
        /// <returns></returns>
        List<SystemFunction> GetSystemFunctionList();
        /// <summary>
        /// 获取操作员的权限
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        List<SystemFunction> GetOptFunctionList(string optNo);
        /// <summary>
        /// 设置操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="systemFunctions"></param>
        void AddOptFunctionList(string optNo, SystemFunction systemFunctions);
        /// <summary>
        /// 清除操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        void ClearOptFunctionList(string optNo);
    }
}
