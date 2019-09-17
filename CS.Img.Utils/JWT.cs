using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Security.Claims;
namespace CS.Img.Utils
{
    /// <summary>
    /// Token工具类
    /// </summary>
    public class TokenManager
    {
        private static string Secret = "szQkFW37ihYnEfgw1huvUMtp53zAA8w4jpQ/m6uaVDpkZdGu+FL8XbWZ+Oxs0w0g/KdjFVAYk9D9MJoXT7MfzQ==";
        /// <summary>
        /// 生成Token
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static string GenerateToken(string username)
        {

            var symmetricKey = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new[] {
                        new Claim(ClaimTypes.Name,username),
                    }),
                Expires = DateTime.Now.AddMinutes(30),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(securityToken);
        }
        /// <summary>
        /// 解析Principal
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private static ClaimsPrincipal GetPrincipal(string token)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken;
            if (jwtToken == null)
            {
                return null;
            }
            var symmetricKey = Convert.FromBase64String(Secret);
            var validationParams = new TokenValidationParameters()
            {
                RequireExpirationTime = true,
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(symmetricKey),
            };
            SecurityToken securityToken;
            var pincipal = tokenHandler.ValidateToken(token, validationParams, out securityToken);
            return pincipal;

        }
        /// <summary>
        /// 验证Principal
        /// </summary>
        /// <param name="token"></param>
        public static bool ValidateToken(string token,out IPrincipal LoginPrincipal)
        {
            var principal = GetPrincipal(token);
            LoginPrincipal = null;
            if (principal == null) return false;

            var identity = principal.Identity as ClaimsIdentity;
            if (identity == null)
            {
                return false;
            }
            if (!identity.IsAuthenticated)
            {
                return false;
            }
            LoginPrincipal = principal;
            return true;
            //var nameClaim = identity.FindFirst(ClaimTypes.Name);
            //var username = nameClaim.Value;
            //if (string.IsNullOrEmpty(username))
            //{
            //    return false;
            //}

            //return true;
        }
    }
}
