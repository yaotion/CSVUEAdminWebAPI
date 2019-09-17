using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Utils
{
    /// <summary>
    /// 自定义WebAPI返回的数据内容
    /// </summary>
    public class CSHttpWebAPIResp
    {
        /// <summary>
        /// 自定义状态代码,20000表示正常
        /// </summary>
        public int code = 20000;
        /// <summary>
        /// 自定义接口返回数据
        /// </summary>
        public object data;
    }

    /// <summary>
    /// 列表类返回数据
    /// </summary>
    public class CSWebAPIListResp
    {
        /// <summary>
        /// 数据内容
        /// </summary>
        public object items;
        /// <summary>
        /// 数据数量
        /// </summary>
        public int total;
    }

    /// <summary>
    /// 列表类返回数据
    /// </summary>
    public class CSWebAPIListSumResp : CSWebAPIListResp
    {
        /// <summary>
        /// 统计信息
        /// </summary>
        public object sum;

    }
}
