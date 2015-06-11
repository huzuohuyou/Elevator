using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    interface IElevator
    {

        void SetFloor(List<int> l);

        /// <summary>
        /// 更具输入楼增设置电梯状态，上行还是下行
        /// </summary>
        /// <param name="floor">楼层</param>
        /// <returns>电梯状态</returns>
        bool SetStatus(int floor);

        /// <summary>
        /// 输入电梯初始楼层
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        void InputOriginFloor(int floor);

        /// <summary>
        /// 输入电梯目标楼层
        /// </summary>
        /// <param name="floor"></param>
        /// <returns></returns>
        void InputTargetFloor(int floor);

        /// <summary>
        /// 上行
        /// </summary>
        /// <returns>停止楼层</returns>
        void GoUp();

        /// <summary>
        /// 下行
        /// </summary>
        /// <returns>停止楼层</returns>
        void GoDown();

        void Stop();

        void CheckStatus();
    }
}
