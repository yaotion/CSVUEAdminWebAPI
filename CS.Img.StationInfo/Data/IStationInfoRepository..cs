using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.StationInfo
{
    /// <summary>
    /// 站点信息Repository接口
    /// </summary>
    public interface IStationInfoRepository
    {
        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <param name="stationType"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        IList<StationInfo> GetStationInfoList(int stationType, string stationNo);
        /// <summary>
        /// 修改站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        /// <returns></returns>
        void UpdateStationInfo(StationInfo stationInfo);
        /// <summary>
        /// 删除站点信息
        /// </summary>
        /// <param name="stationNo"></param>
        void DeleteStationInfo(string stationNo);
        /// <summary>
        /// 添加站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        void AddStationInfo(StationInfo stationInfo);
        /// <summary>
        /// 初始化站点
        /// </summary>
        /// <param name="stationNo"></param>
        void InitStationInfo(string stationNo);
    }
}
