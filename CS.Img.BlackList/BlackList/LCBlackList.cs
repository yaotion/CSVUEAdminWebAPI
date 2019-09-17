using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Img.BlackList
{
    public class LCBlackList
    {
        public static List<AddBlackList> GetAddBlackList(string StationNo, string Version, int PageIndex, int PageCount)
        {
            return DBBlackList.GetAddBlackList(StationNo,PageIndex,PageCount);
        }
    }
}
