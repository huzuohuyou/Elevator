using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            elevator._floorCurrent = f1;

            f2.CommandUp();
            elevator.CommandStop(f5);


            f8.CommandDown();
            elevator.CommandStop(f5);
            Console.ReadLine();
        }
    }
}
