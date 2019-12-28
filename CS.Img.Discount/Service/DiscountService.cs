using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Discount
{
    /// <summary>
    /// 明折明扣信息Service实现
    /// </summary>
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _Repository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public DiscountService(IDiscountRepository repository)
        {
            _Repository = repository;
        }
        /// <summary>
        /// 获取活动列表
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <param name="actName"></param>
        /// <returns></returns>
        public List<DiscountAct> GetActList(string beginTime, string endTime, string actName)
        {
            return _Repository.GetActList(beginTime, endTime, actName);
        }

        /// <summary>
        /// 获取活动日志
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DiscountActLog> GetActLogList(string actID)
        {
            return _Repository.GetActLogList(actID);
        }

        /// <summary>
        /// 获取指定活动的 活动内容
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DiscountContent> GetDiscountContentList(string actID)
        {
            return _Repository.GetDiscountContentList(actID);
        }

        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="act"></param>
        public void AddAct(DiscountAct act)
        {
            _Repository.AddAct(act);
        }
        /// <summary>
        /// 修改活动
        /// </summary>
        /// <param name="act"></param>
        public void UpdateAct(DiscountAct act)
        {
            _Repository.UpdateAct(act);
        }
        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteAct(string actID)
        {
            _Repository.DeleteAct(actID);
        }

        /// <summary>
        /// 添加活动内容
        /// </summary>
        /// <param name="content"></param>
        public void AddContent(DiscountContent content)
        {
            _Repository.AddContent(content);
        }
        /// <summary>
        /// 修改活动内容
        /// </summary>
        /// <param name="content"></param>
        public void UpdateContent(DiscountContent content)
        {
            _Repository.UpdateContent(content);
        }
        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="disID"></param>
        public void DeleteContent(string disID)
        {
            _Repository.DeleteContent(disID);
        }
        /// <summary>
        /// 删除活动内容
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteActContent(string actID)
        {
            _Repository.DeleteActContent(actID);
        }
    }
}
