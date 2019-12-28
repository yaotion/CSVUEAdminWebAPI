using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.StationInfo
{
    /// <summary>
    /// 站点信息App接口实现
    /// </summary>
    public class StationInfoApp: IStationInfoApp
    {
        private readonly IStationInfoService _Service;
        private readonly CSUoWFactory _uoWFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="service"></param>
        /// <param name="uoWFactory"></param>
        public StationInfoApp(IStationInfoService service, CSUoWFactory uoWFactory)
        {
            _Service = service;
            _uoWFactory = uoWFactory;
        }
        /// <summary>
        /// 获取油站信息
        /// </summary>
        /// <param name="stationType"></param>
        /// <param name="stationNo"></param>
        /// <returns></returns>
        public IList<StationInfo> GetStationInfoList(int stationType, string stationNo)
        {
            return _Service.GetStationInfoList(stationType, stationNo);
        }
        /// <summary>
        /// 修改站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        /// <returns></returns>
        public void UpdateStationInfo(StationInfo stationInfo)
        {
            _Service.UpdateStationInfo(stationInfo);
        }
        /// <summary>
        /// 删除站点信息
        /// </summary>
        /// <param name="stationNo"></param>
        public void DeleteStationInfo(string stationNo)
        {
            _Service.DeleteStationInfo(stationNo);
        }
        /// <summary>
        /// 添加站点信息
        /// </summary>
        /// <param name="stationInfo"></param>
        public void AddStationInfo(StationInfo stationInfo)
        {
            _Service.AddStationInfo(stationInfo);
        }
        /// <summary>
        /// 初始化站点
        /// </summary>
        /// <param name="stationNo"></param>
        public void InitStationInfo(string stationNo)
        {
            _Service.InitStationInfo(stationNo);
        }
    }
}
