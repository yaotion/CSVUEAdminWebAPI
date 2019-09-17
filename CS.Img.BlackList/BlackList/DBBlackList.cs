using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Img.BlackList
{
    public class DBBlackList
    {
        public static List<AddBlackList> GetAddBlackList(string StationNo,int PageIndex, int PageCount)
        {
            List<AddBlackList> result = new List<AddBlackList>();
            return result;
        }
        public static int GetAddBlackCount()
        {
            return 0;
        }

        public static bool GetBlackVersion(BlackListConfig BConfig)
        {
            BlackListConfig result = new BlackListConfig();
            return false;
        }
        
    }
}
