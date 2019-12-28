using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.Card
{
    public interface ICardService:ICardRepository
    {
        /// <summary>
        /// 获取油站最后传输时间
        /// </summary>
        /// <returns></returns>
        StationTransResp GetStationLastTransRecord();

    }
}
