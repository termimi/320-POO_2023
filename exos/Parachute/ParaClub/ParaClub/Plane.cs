using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Plane
    {
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        private int PlaneX;
        private int PlaneY;
        public Plane()
        {
         PlaneX = 0;
         PlaneY = 0;
        }
        public void show()
        {
         foreach (string c in view)
         {
          Console.WriteLine(c);
         }
        }
        public void MoveRight()
        {

        }
    }
}
