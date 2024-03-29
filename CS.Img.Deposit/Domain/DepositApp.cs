﻿using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Deposit
{
    /// <summary>
    /// 储值赠送信息App接口实现
    /// </summary>
    public class DepositApp : IDepositApp
    {
        private readonly IDepositService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public DepositApp(IDepositService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }

        /// <summary>
        /// 获取活动列表
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="actName"></param>
        /// <returns></returns>
        public List<DepositAct> GetActList(string beginTime, string endTime, string actName)
        {
            string strSql = @"select * from UserDepositAct where Flag <> 0 {0} order by ActEndTime desc";
            string strWhere = "";
            if (!string.IsNullOrEmpty(beginTime))
            {
                strWhere += " and startTm >= @STime";
            }
            if (!string.IsNullOrEmpty(endTime))
            {
                strWhere += " and endTm >= @ETime";
            }
            if (!string.IsNullOrEmpty(actName))
            {
                strWhere += " and ActName like ActName";
            }
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                Stime = beginTime,
                ETime = endTime,
                ActName = "%" + actName + "%"
            };
            return _Service.GetActList(beginTime, endTime, actName);
        }
        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="act"></param>
        public void AddAct(DepositAct act)
        {
            string strSql = @"insert into UserDepositAct  (ActName,StartTm,EndTm,Flag,Createtime) values (@ActName,@StartTm,@EndTm,@Flag,@Createtime)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                act.ActName,
                act.StartTm,
                act.EndTm,
                Flag = 0,
                Createtime = DateTime.Now
            };
            _Service.AddAct(act);
        }
        /// <summary>
        /// 修改活动
        /// </summary>
        /// <param name="act"></param>
        public void UpdateAct(DepositAct act)
        {
            _Service.UpdateAct(act);
        }
        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteAct(int actID)
        {
            _Service.DeleteAct(actID);
        }



        /// <summary>
        /// 获取指定活动的 活动内容
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DepositContent> GetDepositContentList(int actID)
        {
            return _Service.GetDepositContentList(actID);
        }

        /// <summary>
        /// 添加活动内容
        /// </summary>
        /// <param name="content"></param>
        public void AddContent(DepositContent content)
        {
            content.CreateTime = DateTime.Now;
            content.Flag = 0;
        
            _Service.AddContent(content);
        }
        /// <summary>
        /// 修改活动内容
        /// </summary>
        /// <param name="content"></param>
        public void UpdateContent(DepositContent content)
        {
            _Service.UpdateContent(content);
        }
        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="contentID"></param>
        public void DeleteContent(int contentID)
        {
            _Service.DeleteContent(contentID);
        }
        /// <summary>
        /// 删除活动内容
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteActContent(int actID)
        {
            _Service.DeleteContent(actID);
        }
    }
}
