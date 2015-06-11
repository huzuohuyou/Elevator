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

        public Floor _floorcurrent ;

        public Floor _floortarget;

        public List<Floor> _floorTargetList = new List<Floor>();

        public List<Floor> _floorAll = new List<Floor>();

        #endregion


        public void CheckStatus()
        {
            foreach (var item in _floorAll)
            {
                if (item.GetStatus())
                {
                    if (_floorcurrent.Compare(item) < 0)
                    {
                        GoUp(_floorcurrent);
                    }
                    else if (_floorcurrent.Compare(item) > 0)
                    {
                        GoDown(_floorcurrent);
                    }
                }
            }

        }


        public void CommandStop(Floor floor)
        {
            floor.BoolStop = true;
            _floortarget = floor;
            CheckStatus();
        }

        /// <summary>
        /// 电梯向上运行
        /// </summary>
        public void GoUp(Floor floor)
        {
            if (floor.Compare(_floortarget) < 0)
            {
                if (floor.GetStatusFlag() == 1)
                {
                    Console.WriteLine("电梯门打开,停靠层：" + floor.IFloorNo);
                }
                else
                {
                    Console.WriteLine("上行：" + floor.IFloorNo);
                }
                int index = _floorAll.IndexOf(floor);
                floor = _floorAll[index + 1];
                GoUp(floor);
            }
            else
            {
                Reach(floor);
                _floorTargetList.Remove(floor);
                return ;
            }

        }

        /// <summary>
        ///  电梯向下运行
        /// </summary>
        public void GoDown(Floor floor)
        {
            if (floor.Compare(_floortarget) > 0)
            {
                if (floor.GetStatusFlag() == -1)
                {
                    Console.WriteLine("电梯门打开,停靠层：" + floor.IFloorNo);
                }
                else
                {
                    Console.WriteLine("下行：" + floor.IFloorNo);
                }
                int index = _floorAll.IndexOf(floor);
                floor = _floorAll[index - 1];
                GoDown(floor);
            }
            else
            {
                Reach(floor);
                _floorTargetList.Remove(floor);
                return;
            }
        }

        /// <summary>
        /// 到达楼层命令
        /// </summary>
        public void Reach(Floor f)
        {
            Console.WriteLine("电梯门打开,停靠层："+f.IFloorNo);
            _floorcurrent.Fresh();
        }

        public void Stop()
        {
            Console.WriteLine("电梯停止"+_floorcurrent.IFloorNo);
        }
    }
}
