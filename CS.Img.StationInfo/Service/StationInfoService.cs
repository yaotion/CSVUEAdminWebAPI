using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.StationInfo
{
    /// <summary>
    /// 站点信息Service实现
    /// </summary>
    public class StationInfoService : IStationInfoService
    {
        private readonly IStationInfoRepository _Repository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public StationInfoService(IStationInfoRepository repository)
        {
            _Repository = repository;
        }
        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <param name="stationType"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<StationInfo> GetStationInfoList(int stationType, string stationNo)
        {
            return _Repository.GetStationInfoList(stationType, stationNo);
        }
        /// <summary>
        /// 修改站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        /// <returns></returns>
        public void UpdateStationInfo(StationInfo stationInfo)
        {
            _Repository.UpdateStationInfo(stationInfo);
        }
        /// <summary>
        /// 删除站点信息
        /// </summary>
        /// <param name="stationNo"></param>
        public void DeleteStationInfo(string stationNo)
        {
            _Repository.DeleteStationInfo(stationNo);
        }
        /// <summary>
        /// 添加站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        public void AddStationInfo(StationInfo stationInfo)
        {
            _Repository.AddStationInfo(stationInfo);
        }
        /// <summary>
        /// 初始化站点
        /// </summary>
        /// <param name="stationNo"></param>
        public void InitStationInfo(string stationNo)
        {
            _Repository.InitStationInfo(stationNo);
        }
    }
}
