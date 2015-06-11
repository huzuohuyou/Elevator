using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
             Elevator elevator = new Elevator();
            List<Floor> lfloor = new List<Floor>();
            Floor f1 = new Floor(1, elevator);
            Floor f2 = new Floor(2, elevator);
            Floor f3 = new Floor(3, elevator);
            Floor f4 = new Floor(4, elevator);
            Floor f5 = new Floor(5, elevator);
            Floor f6 = new Floor(6, elevator);
            Floor f7 = new Floor(7, elevator);
            Floor f8 = new Floor(8, elevator);
            Floor f9 = new Floor(9, elevator);
            Floor f10 = new Floor(10, elevator);
            lfloor.Add(f1);
            lfloor.Add(f2);
            lfloor.Add(f3);
            lfloor.Add(f4);
            lfloor.Add(f5);
            lfloor.Add(f6);
            lfloor.Add(f7);
            lfloor.Add(f8);
            lfloor.Add(f9);
            lfloor.Add(f10);
           
            elevator._floorAll = lfloor;
            //设置当前楼层
            elevator._floorCurrent = f1;
            //2楼叫梯 想下楼
            f2.CommandDown();
            //目标楼层为1楼
            elevator.CommandStop(f1);
            //4楼叫梯
            f4.CommandUp();
            //目标楼层为8楼
            elevator.CommandStop(f8);

            Console.ReadLine();
        }
    }
}
