using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Discount
{
    /// <summary>
    /// 明折明扣信息App接口实现
    /// </summary>
    public class DiscountApp : IDiscountApp
    {
        private readonly IDiscountService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public DiscountApp(IDiscountService service, CSUoWFactory uoWFactory)
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
        public List<DiscountAct> GetActList(string beginTime, string endTime, string actName)
        {
            return _Service.GetActList(beginTime, endTime, actName);
        }

        /// <summary>
        /// 获取活动日志
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DiscountActLog> GetActLogList(string actID)
        {
            return _Service.GetActLogList(actID);
        }
        /// <summary>
        /// 获取指定活动的 活动内容
        /// </summary>
        /// <param name="actID"></param>
        /// <returns></returns>
        public List<DiscountContent> GetDiscountContentList(string actID)
        {
            return _Service.GetDiscountContentList(actID);
        }
        /// <summary>
        /// 添加活动
        /// </summary>
        /// <param name="act"></param>
        public void AddAct(DiscountAct act)
        {
            if (string.IsNullOrEmpty(act.ActID))
                act.ActID = Guid.NewGuid().ToString();
            _Service.AddAct(act);
        }
        /// <summary>
        /// 修改活动
        /// </summary>
        /// <param name="act"></param>
        public void UpdateAct(DiscountAct act)
        {
            _Service.UpdateAct(act);
        }
        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteAct(string actID)
        {
            _Service.DeleteAct(actID);
        }

        /// <summary>
        /// 添加活动内容
        /// </summary>
        /// <param name="content"></param>
        public void AddContent(DiscountContent content)
        {
            if (string.IsNullOrEmpty(content.DisID))
                content.DisID = Guid.NewGuid().ToString();
            _Service.AddContent(content);
        }
        /// <summary>
        /// 修改活动内容
        /// </summary>
        /// <param name="content"></param>
        public void UpdateContent(DiscountContent content)
        {
            _Service.UpdateContent(content);
        }
        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="disID"></param>
        public void DeleteContent(string disID)
        {
            _Service.DeleteContent(disID);
        }
        /// <summary>
        /// 删除活动内容
        /// </summary>
        /// <param name="actID"></param>
        public void DeleteActContent(string actID)
        {
            _Service.DeleteActContent(actID);
        }
    }
}
