using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Logging;
using System.Web.Http.Results;
using System.Web.Http.Filters;
using CS.Img.WebAPI.Filters;

namespace CS.Img.Online.Coupon
{
    /// <summary>
    /// 优惠券API
    /// </summary>
    [ActionMonitor]
    public class CouponController : ApiController
    {
        /// <summary>
        /// 获取指定编号的优惠券
        /// </summary>
        /// <param name="cardno">卡号</param>
        /// <param name="guid">GUID</param>
        /// <param name="reqstationid">请求的油站</param>
        /// <param name="couponid">优惠券编号</param>
        /// <returns>优惠券信息</returns>
        public IHttpActionResult GetCoupon(string cardno,string guid,string reqstationid,string couponid)
        {
            Coupon cp = new Coupon();
            cp.couponid = couponid;
            cp.cardno = cardno;
            cp.guid = guid;
            cp.reqstationid = reqstationid;
            return Json<Coupon>(cp);
        }
        /// <summary>
        /// 获取指定卡号下所有优惠券
        /// </summary>
        /// <param name="cardno">积分卡卡号</param>
        /// <param name="guid">GUID</param>
        /// <param name="reqstationid">请求的油站编号</param>
        /// <returns>优惠券列表</returns>
        public IHttpActionResult GetAllCoupons(string cardno, string guid, string reqstationid)
        {
            List<Coupon> rlt = new List<Coupon>();
            Coupon cp = new Coupon();
            cp.couponid = "1111";
            cp.cardno = cardno;
            cp.guid = guid;
            cp.reqstationid = reqstationid;
            rlt.Add(cp);
            cp = new Coupon();
            cp.couponid = "2222";
            cp.cardno = cardno;
            cp.guid = guid;
            cp.reqstationid = reqstationid;
            rlt.Add(cp);
            cp = new Coupon();
            cp.couponid = "3333";
            cp.cardno = cardno;
            cp.guid = guid;
            cp.reqstationid = reqstationid;
            rlt.Add(cp);
            return Json<List<Coupon>>(rlt);
        }

        [Route("api/coupon/Validity")]
        [HttpPatch]
        public IHttpActionResult UpdateCouponValidity(string cardno, string guid, string reqstationid, string couponid, string couponstartdt, string couponenddt)
        {
            string content = string.Format("UpdateCouponValidity:cardno={0},guid={1},reqstationid={2}", cardno, guid, reqstationid);
            return Ok(content);
        }
        /// <summary>
        /// 解锁优惠券
        /// </summary>
        /// <param name="cardno">指定的卡号</param>
        /// <param name="guid"></param>
        /// <param name="reqstationid"></param>
        /// <returns></returns>
        
        [Route("api/coupon/Unlock")]
        [HttpPatch]
        [CustomBasicAuthenticationFilter]
        public IHttpActionResult UnlockCoupon(string cardno, string guid, string reqstationid)
        {
            string content = string.Format("UnlockCoupon:cardno={0},guid={1},reqstationid={2}", cardno, guid, reqstationid);
            return Ok(content);
        }
        /// <summary>
        /// 修改优惠券
        /// </summary>
        /// <param name="cardno"></param>
        /// <param name="guid"></param>
        /// <param name="reqstationid"></param>
        /// <returns></returns>
        [Route("api/coupon/State")]
        [HttpPatch]
        public IHttpActionResult UpdateCouponState(string cardno, string guid, string reqstationid,string state)
        {
            string content = string.Format("UpdateCoupon:cardno={0},guid={1},reqstationid={2}", cardno, guid, reqstationid);
            return Ok(content);
        }
    }
}
