using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OptInfo
{
    /// <summary>
    /// 操作员信息Service实现
    /// </summary>
    public class OptInfoService : IOptInfoService
    {
        private readonly IOptInfoRepository _Repository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public OptInfoService(IOptInfoRepository repository)
        {
            _Repository = repository;
        }
        /// <summary>
        /// 获取操作员信息
        /// </summary>
        /// <returns></returns>
        public IList<OptInfo> GetOptInfoList()
        {
            return _Repository.GetOptInfoList();
        }
        /// <summary>
        /// 修改操作员
        /// </summary>
        /// <param name="optInfo"></param>
        public void UpdateOptInfo(OptInfo optInfo)
        {
            _Repository.UpdateOptInfo(optInfo);
        }

        /// <summary>
        /// 添加操作员
        /// </summary>
        /// <param name="optInfo"></param>
        public void AddOptInfo(OptInfo optInfo)
        {
            _Repository.AddOptInfo(optInfo);
        }
            /// <summary>
            /// 重置密码
            /// </summary>
            /// <param name="optNo"></param>
            /// <param name="newPWD"></param>
            public void ResetOptPWD(string optNo, string newPWD)
        {
            _Repository.ResetOptPWD(optNo, newPWD);
        }
        /// <summary>
        /// 删除操作员
        /// </summary>
        /// <param name="optNo"></param>
        public void DeleteOptInfo(string optNo)
        {
            _Repository.DeleteOptInfo(optNo);
        }
        /// <summary>
        /// 获取操作员密码
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        public string GetOptPWD(string optNo)
        {
            return _Repository.GetOptPWD(optNo);
        }
        /// <summary>
        /// 获取全部功能列表
        /// </summary>
        /// <returns></returns>
        public List<SystemFunction> GetSystemFunctionList()
        {
           return _Repository.GetSystemFunctionList();
        }
        /// <summary>
        /// 获取操作员的权限
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        public List<SystemFunction> GetOptFunctionList(string optNo)
        {
            return _Repository.GetOptFunctionList(optNo);
        }
        /// <summary>
        /// 设置操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="systemFunctions"></param>
        public void AddOptFunctionList(string optNo, SystemFunction systemFunctions)
        {
            _Repository.AddOptFunctionList(optNo,systemFunctions);
        }
        /// <summary>
        /// 清除操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        public void ClearOptFunctionList(string optNo)
        {
            _Repository.ClearOptFunctionList(optNo);
        }
    }
}
