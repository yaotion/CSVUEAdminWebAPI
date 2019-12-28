using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Deposit
{
    /// <summary>
    /// 储值赠送信息Repository接口
    /// </summary>
    public interface IDepositRepository
    {
        /// <summary>
        /// 获取活动列表
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="actName"></param>
        /// <returns></returns>
        List<DepositAct> GetActList(string beginTime, string endTime, string actName);
        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="act"></param>
        void AddAct(DepositAct act);
        /// <summary>
        /// 修改活动
        /// </summary>
        /// <param name="act"></param>
        void UpdateAct(DepositAct act);
        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="actID"></param>
        void DeleteAct(int actID);

        
        /// <summary>
        /// 获取指定活动的 活动内容
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        List<DepositContent> GetDepositContentList(int actID);

        /// <summary>
        /// 添加活动内容
        /// </summary>
        /// <param name="content"></param>
        void AddContent(DepositContent content);
        /// <summary>
        /// 修改活动内容
        /// </summary>
        /// <param name="content"></param>
        void UpdateContent(DepositContent content);
        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="contentID"></param>
        void DeleteContent(int contentID);
        /// <summary>
        /// 删除活动内容
        /// </summary>
        /// <param name="actID"></param>
        void DeleteActContent(int actID);
        
        
    }
}
