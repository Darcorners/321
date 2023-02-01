using System;
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
    }
}
