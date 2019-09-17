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

namespace CS.Img.Identity
{
    /// <summary>
    /// 登录验证结果
    /// </summary>
    public class IdentityResult
    {
        /// <summary>
        /// 是否登录成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 登录结果说明文字
        /// </summary>
        public string ResultText { get; set; }
        /// <summary>
        /// 登录成功的票据
        /// </summary>
        public string TokenString { get; set; }
    }
   
    /// <summary>
    /// 登录请求信息
    /// </summary>
    public class IdentityBase
    {
        public string username;
        public string password;
    }

    /// <summary>
    /// 操作员信息
    /// </summary>
    public class OperatorInfo
    {
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string OptNo { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pin { get; set; }
        /// <summary>
        /// 油站
        /// </summary>
        public string StationNO { get; set; }
        /// <summary>
        /// 授权卡号
        /// </summary>
        public string CardNo { get; set; }
        
        
    }
    /// <summary>
    /// 登录验证控制器
    /// </summary>
    public class IdentityController : ApiController
    {
        [HttpPost]
        public IdentityResult Login([FromBody]IdentityBase req)
        {
            IdentityResult result = new IdentityResult();
            if (IdentityUser(req))
            {
                result.Success = true;
                result.TokenString =  Utils.TokenManager.GenerateToken(req.username);
                result.ResultText = "登录成功";
                return result;
            }
            return result;
        }
        [JWTAuthorizationFilter]
        [HttpGet]
        public IHttpActionResult GetUser(string UserID)
        {            
            OperatorInfo op = new OperatorInfo();
            op.OptNo = "admin";
            op.OptName = "测试管理员";
            op.StationNO = "00000001";

            //System.Web.HttpContext.Current.User
            return Json<OperatorInfo>(op);
        }
        private bool IdentityUser(IdentityBase Req)
        {
            if ((Req.username == "admin") && (Req.password == "admin123"))
                return true;
            return false;
        }

    }
}
