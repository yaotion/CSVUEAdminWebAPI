using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;

namespace CS.Img.User
{
    /// <summary>
    /// 临时Token类
    /// </summary>
    public class CSWebAPIRespLogin
    {
        /// <summary>
        /// token值
        /// </summary>
        public string token = "admin-token";
    }
   
    /// <summary>
    /// 返回用户信息值
    /// </summary>
    public class CSWebAPIRespUserInfo
    {
        /// <summary>
        /// 用户角色
        /// </summary>
        public string[] roles = new string[]{"admin"};
        /// <summary>
        /// 个人介绍
        /// </summary>
        public string introduction = "I am a super administrator";
        /// <summary>
        /// 头像链接
        /// </summary>
        public string avatar = "https://wpimg.wallstcn.com/f778738c-e4f8-4870-b634-56703b4acafe.gif";
        /// <summary>
        /// 名字
        /// </summary>
        public string name = "Super Admin";
  
    }

   
    /// <summary>
    /// 用户信息控制类
    /// </summary>
    public class UserController: ApiController
    {
        /// <summary>
        /// 登入
        /// </summary>
        /// <returns></returns>
        [Route("api/user/login")]
        [HttpPost]        
        public IHttpActionResult Login()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            resp.data = new CSWebAPIRespLogin();
        
            return Ok(resp);
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        [Route("api/user/logout")]
        [HttpPost]
        public IHttpActionResult Logout()
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            resp.data = "success";
            return Ok(resp);
        }
        
        /// <summary>
        /// 根据用户token值返回用户信息
        /// </summary>
        /// <returns></returns>
        [Route("api/user/info")]
        [HttpGet]
        public IHttpActionResult GetUserInfo(string token)
        {
            var resp = new CS.Img.Utils.CSHttpWebAPIResp();
            resp.data = new CSWebAPIRespUserInfo();        
            return Ok(resp);
        }

    }
}
