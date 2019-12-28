using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Discount
{
    /// <summary>
    /// 明折明扣信息Repository接口
    /// </summary>
    public interface IDiscountRepository
    {
        /// <summary>
        /// 获取活动列表
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="actName"></param>
        /// <returns></returns>
        List<DiscountAct> GetActList(string beginTime, string endTime, string actName);
        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="act"></param>
        void AddAct(DiscountAct act);
        /// <summary>
        /// 修改活动
        /// </summary>
        /// <param name="act"></param>
        void UpdateAct(DiscountAct act);
        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="actID"></param>
        void DeleteAct(string actID);

        
        /// <summary>
        /// 获取指定活动的 活动内容
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        List<DiscountContent> GetDiscountContentList(string actID);

        /// <summary>
        /// 添加活动内容
        /// </summary>
        /// <param name="content"></param>
        void AddContent(DiscountContent content);
        /// <summary>
        /// 修改活动内容
        /// </summary>
        /// <param name="content"></param>
        void UpdateContent(DiscountContent content);
        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="disID"></param>
        void DeleteContent(string disID);
        /// <summary>
        /// 删除活动内容
        /// </summary>
        /// <param name="actID"></param>
        void DeleteActContent(string actID);
        
        /// <summary>
        /// 获取活动日志
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        List<DiscountActLog> GetActLogList(string actID);
    }
}
