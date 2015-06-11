using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    public class Elevator
    {
        #region 属性

        public readonly static int UP = 1;

        public readonly static int DOWN = -1;

        public readonly static int STOP = 0;

        private static int _iStatus = STOP;

        public Floor _floorCurrent ;

        public Floor _floorTarget;

        public List<Floor> _floorTargetList = new List<Floor>();

        public List<Floor> _floorAll = new List<Floor>();

        #endregion


        public void CheckStatus()
        {
            foreach (var item in _floorAll)
            {
                if (item.GetStatus())
                {
                    if (_floorCurrent.Compare(item) < 0)
                    {
                        GoUp(item);
                    }
                    else if (_floorCurrent.Compare(item) > 0)
                    {
                        GoDown(item);
                    }
                }
            }

        }


        public void CommandStop(Floor floor)
        {
            floor.BoolStop = true;
            GoToTargetFloor();
        }

  

       /// <summary>
        /// 电梯向上运行,运行到floor层
       /// </summary>
       /// <param name="floor"></param>
        public void GoUp(Floor floor)
        {
            if (_floorCurrent.Compare(floor) < 0)
            {
                Console.WriteLine("上行：" + _floorCurrent.IFloorNo);
                int index = _floorAll.IndexOf(_floorCurrent);
                _floorCurrent = _floorAll[index + 1];
                GoUp(floor);
            }
            else
            {
                Reach(floor);
            }
        }

        /// <summary>
        ///  电梯向下运行
        /// </summary>
        public void GoDown(Floor floor)
        {
            if (_floorCurrent.Compare(floor) > 0)
            {
                Console.WriteLine("下行：" + _floorCurrent.IFloorNo);
                int index = _floorAll.IndexOf(_floorCurrent);
                _floorCurrent = _floorAll[index - 1];
                GoDown(floor);
            }
            else
            {
                Reach(floor);
            }
        }

        /// <summary>
        /// 前往命令层,循环列表是否有命令层
        /// </summary>
        public void GoToCommandFloor()
        {
            foreach (var item in _floorAll)
            {
                if (item.GetStatus())
                {
                    if (_floorCurrent.Compare(item) < 0)
                    {
                        GoUp(item);
                    }
                    else if (_floorCurrent.Compare(item) > 0)
                    {
                        GoDown(item);
                    }
                }
            }
        }

        /// <summary>
        /// 前往目标楼层
        /// </summary>
        public void GoToTargetFloor() {

            foreach (var item in _floorAll)
            {
                if (item.GetStatusFlag()==0)
                {
                    if (_floorCurrent.Compare(item) < 0)
                    {
                        GoUp(item);
                    }
                    else if (_floorCurrent.Compare(item) > 0)
                    {
                        GoDown(item);
                    }
                }
            }
        }
       

        /// <summary>
        /// 到达楼层命令
        /// </summary>
        public void Reach(Floor f)
        {
            Console.WriteLine("电梯门打开,停靠层："+f.IFloorNo);
            f.Fresh();
        }

        public void Stop()
        {
            Console.WriteLine("电梯停止"+_floorCurrent.IFloorNo);
        }
    }
}
