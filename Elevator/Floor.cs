using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    /// <summary>
    /// 楼层类
    /// </summary>
    public class Floor
    {
        Elevator elevator;
        /// <summary>
        /// 楼层号
        /// </summary>
        private int _iFloorNo;

        public int IFloorNo
        {
            get { return _iFloorNo; }
            set { _iFloorNo = value; }
        }
        /// <summary>
        /// 上行需求
        /// </summary>
        private bool _boolUp = false;
        /// <summary>
        /// 下行需求
        /// </summary>
        private bool _boolDown = false;

        private bool _boolStop = false;

        public bool BoolStop
        {
            get { return _boolStop; }
            set { _boolStop = value; }
        }

        public Floor(int f,Elevator e)
        {
            _iFloorNo = f;
            elevator = e;
        }

        public Floor(int f)
        {
            _iFloorNo = f;
        }

        public Floor()
        {
        }

        /// <summary>
        /// 获取本层是否停靠
        /// </summary>
        /// <returns>停靠true；过false；</returns>
        public bool GetStatus()
        {
            return _boolDown || _boolUp;
        }

        /// <summary>
        /// 上行返回1；下行返回-1；本层为目的地返回0；
        /// </summary>
        /// <returns></returns>
        public int GetStatusFlag()
        {
            if (_boolDown)
            {
                return -1;
            }
            else if(_boolUp)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// 上楼命令
        /// </summary>
        public void CommandUp()
        {
            _boolUp = true;
            
        }

        /// <summary>
        /// 下楼命令
        /// </summary>
        public void CommandDown()
        {
            _boolDown = true;
           
        }


        public void Fresh()
        {
            _boolUp = false;
            _boolDown = false;
            _boolStop = false;
        }


        /// <summary>
        /// 楼层比较看楼层号
        /// </summary>
        /// <param name="floor"></param>
        /// <returns></returns>
        public int Compare(Floor floor)
        {
            int result = 1;
            if (this._iFloorNo > floor._iFloorNo)
            {
                result = 1;
            }
            else if (this._iFloorNo < floor._iFloorNo)
            {
                result = -1;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
