﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLenght;
        double roomWidth;
        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        /* <summary>
           </summary>
           <returns></returns> */
        public double RoomPerimeter ()
        {
            return 2 * (roomWidth + roomLenght);
        }
        /* <summary>
           </summary>
           <returns></returns> */
        public double RoomArea()
        {
            return roomWidth * roomLenght;
        }
        /* <summary>
           </summary>
           <param name="np"> </param>
           <returns></returns> */
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }

        public string  Info()
        {
            return "Комната площадью " + RoomArea() + "кв.м";
        }

        /* <summary> 
         Класс "Живая"
         </summary> */
        public class LivingRoom: Room
        {
            int numWin;
            public int NumWin
            { get { return numWin; } set { numWin = value; } }

            public string Info()
            {
                return "Жилая комната площадью " + RoomArea() + " кв.м, с " + numWin + " окнами";
            }
        }

        public class Office : Room
        {
            int numSockets;
            public int NumSockets
            { get { return numSockets; } set { numSockets = value; } }

            public int NumWorkplaces()
            {
                int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
                return Math.Min(numSockets, num);
            }
            public string Info()
            {
                return "Офис на " + NumWorkplaces() + " рабочих мест";
            }
        }
    }
}
