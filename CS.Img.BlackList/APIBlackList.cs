using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Logging;


namespace CS.Img.BlackList
{
    /// <summary>
    /// 基础黑名单
    /// </summary>
    public class BlackListController : ApiController
    {             
        /// <summary>
        /// 获取基础黑名单
        /// </summary>
        /// <param name="StationNo">站点编号</param>
        /// <param name="Version">站点基础黑名单版本</param>
        /// <param name="PageIndex">基础黑名单开始序号</param>
        /// <param name="PageCount">每次获取的黑名单数量</param>
        /// <returns>如果基础黑名单需要更新，则返回请求的黑名单列表</returns>
        public BlackGetResult Get(string StationNo, string Version, int PageIndex, int PageCount)
        {
            ILog logger = LogManager.GetLogger("BlackListController");
            logger.Info("Exec Get");
            BlackGetResult result = new BlackGetResult();
            BlackListConfig bConfig = new BlackListConfig();
            result.IsUpdate = false;
            if (!DBBlackList.GetBlackVersion(bConfig))
            {
                // "服务器尚未配置黑名单信息";                
                return result;
            }
            if (bConfig.BlackVer == Version)
            {
                //return "版本相同无需更新";                
                return result;
            }
            List<AddBlackList> blackList = DBBlackList.GetAddBlackList(StationNo, PageIndex, PageCount);
            int blackCount = DBBlackList.GetAddBlackCount();
            result.IsUpdate = true;
            result.DataList = blackList;
            result.ServerVersion = bConfig.BlackVer;
            result.PageIndex = PageIndex;
            result.PageCount = PageCount;
            result.MaxCount = blackCount;
            return result;
        }


        [HttpGet]
        /// <summary>
        /// 提交本地站点黑名单信息
        /// </summary>
        /// <param name="StationNo">油站编号</param>
        /// <param name="BlackListType">黑名单类型(1、)</param>
        /// <param name="Version">黑名单版本号</param>
        /// <param name="UpdateTime">本地黑名单最后更新时间</param>
        /// <param name="CheckCode">黑名单校验码</param>
        public void CommitBlack(string StationNo, BlackType BlackListType, string Version, DateTime UpdateTime, string CheckCode)
        {
            //从黑名单摘要表中获取指定类型、指定版本得黑名单摘要信息

            ///如果不存在则计算校验码并插入其摘要信息
            

            //根据油站编号和黑名单类型，修改或这插入到油站黑名单摘要信息表中

            //修改的同时要计算当时油站黑名单是否和中心黑名单一致



        }
    }

    /// <summary>
    /// 基础黑名单调用返回
    /// </summary>
    public class BlackGetResult
    {
        public int PageCount;
        public int PageIndex;
        public bool IsUpdate;
        public string ServerVersion;
        public int MaxCount;

        public object DataList;
    }
   
    /// <summary>
    /// 黑名单类型
    /// </summary>
    public enum BlackType
    {
        /// <summary>
        /// 基础黑名单
        /// </summary>
        Base = 1,
        /// <summary>
        /// 新增黑名单
        /// </summary>
        Add = 2,
        /// <summary>
        /// 新删黑名单
        /// </summary>
        Del = 3  
    }
    
}
