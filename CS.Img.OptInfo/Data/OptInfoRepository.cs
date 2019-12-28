using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.OptInfo
{
    /// <summary>
    /// 操作员信息Repository实现
    /// </summary>
    public class OptInfoRepository : CSRepository, IOptInfoRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public OptInfoRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取所有操作员信息
        /// </summary>
        /// <returns></returns>
        public IList<OptInfo> GetOptInfoList()
        {
            string strSql = @"select OptNo,OptName,OptLevel,UseFlag,SuperFlag,o.StationNO,s.StationName,o.Memo from OperatorInfo o
                            left join StationInfo s on o.StationNO = s.StationNo
                            order by OptNo";
            string strWhere = "";
           
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
              
            };
            return DBContext.Query<OptInfo>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取操作员密码
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        public string GetOptPWD(string optNo)
        {
            string strSql = @"select Pin from OperatorInfo where OptNo=@OptNo";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                OptNo = optNo
            };

            string rlt = DBContext.ExecuteScalar<string>(strSql, sqlParams);
            if (string.IsNullOrEmpty(rlt))
                rlt = "";
            return rlt;
        }
        /// <summary>
        /// 修改操作员
        /// </summary>
        /// <param name="optInfo"></param>
        public void UpdateOptInfo(OptInfo optInfo)
        {
            string strSql = @"update OperatorInfo set OptName = @OptName, UseFlag=@UseFlag,Memo=@Memo,OptLevel=@OptLevel
                                where OptNo=@OptNo";

            var sqlParams = new
            {
                optInfo.OptNo,
                optInfo.OptName,
                optInfo.Memo,
                optInfo.OptLevel,
                optInfo.UseFlag
            };
            DBContext.Execute(strSql, sqlParams);
        }

        /// <summary>
        /// 添加操作员
        /// </summary>
        /// <param name="optInfo"></param>
        public void AddOptInfo(OptInfo optInfo)
        {
            string strSql = @"insert into OperatorInfo (OptNo,OptName,UseFlag,SuperFlag,OptLevel,Pin,Memo,StationNo) values (@OptNo,@OptName,@UseFlag,@SuperFlag,@OptLevel,@Pin,@Memo,@StationNo)";

            var sqlParams = new
            {
                optInfo.OptNo,
                optInfo.OptName,
                optInfo.Memo,
                optInfo.OptLevel,
                optInfo.Pin,
                optInfo.SuperFlag,
                optInfo.StationNo,
                optInfo.UseFlag
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除操作员
        /// </summary>
        /// <param name="optNo"></param>
        public void DeleteOptInfo(string optNo)
        {
            string strSql = @"delete from OperatorInfo where OptNo=@OptNo";

            var sqlParams = new
            {
                OptNo = optNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="newPWD"></param>
        public void ResetOptPWD(string optNo, string newPWD)
        {
            string strSql = @"update OperatorInfo set Pin = @Pin  where OptNo=@OptNo";

            var sqlParams = new
            {
                OptNo = optNo,
                Pin = newPWD                
            };
            DBContext.Execute(strSql, sqlParams);
        }


        /// <summary>
        /// 获取全部功能列表
        /// </summary>
        /// <returns></returns>
        public List<SystemFunction> GetSystemFunctionList()
        {
            string strSql = @"select * from SystemFunctionList where functionType=0 order by FunctionType,FunctionName";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {

            };
            return DBContext.Query<SystemFunction>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 获取操作员的权限
        /// </summary>
        /// <param name="optNo"></param>
        /// <returns></returns>
        public List<SystemFunction> GetOptFunctionList(string optNo)
        {
            string strSql = @"select optFun.FunctionNo,optFun.FunctionType,sysFun.FunctionName from OperatorFunctionList optFun 
                                left join SystemFunctionList sysFun 
                                on optFun.FunctionNo = sysFun.FunctionNo and optFun.FunctionType = sysFun.FunctionType
                                where 1=1 and optFun.OptNo=@OptNo order by sysFun.FunctionType,sysFun.FunctionName";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                OptNo=optNo
            };
            return DBContext.Query<SystemFunction>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 设置操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        /// <param name="systemFunctions"></param>
        public void AddOptFunctionList(string optNo, SystemFunction systemFunctions)
        {
            string strSql = @"insert into OperatorFunctionList (OptNo,FunctionType,FunctionNo) values (@OptNo,@FunctionType,@FunctionNo)";
            var sqlParams = new
            {
                OptNo = optNo,
                systemFunctions.FunctionType,
                systemFunctions.FunctionNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 清除操作员功能
        /// </summary>
        /// <param name="optNo"></param>
        public void ClearOptFunctionList(string optNo)
        {
            string strSql = @"delete OperatorFunctionList  where OptNo=@OptNo";
            var sqlParams = new
            {
                OptNo = optNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
    }
}
