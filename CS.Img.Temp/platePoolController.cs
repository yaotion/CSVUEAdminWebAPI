using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
namespace CS.Img.Temp
{
    public class Test
    {
        public string data { get; set; }
    }
    public class platePoolController : ApiController
    {
        [Route("platePool/sendPlates")]

        [HttpPost]
        public IHttpActionResult GetUserSaleTrade([FromBody]Test data)
        {

            return Ok(data.data);
        }
    }
}
