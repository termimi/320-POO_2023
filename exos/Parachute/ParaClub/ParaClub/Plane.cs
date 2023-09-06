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
        public Plane(int PlaneX, int PlaneY)
        {
            this.PlaneX = PlaneX;
            this.PlaneY = PlaneY;
        }
        public void show()
        {

            foreach (string c in view)
            {
                Console.SetCursorPosition(PlaneX, PlaneY);
                this.PlaneY++;
                Console.WriteLine(c);
            }
        }
        public void MoveRight()
        {
            Console.SetCursorPosition(PlaneX + 1, PlaneY);
            PlaneX++;
            PlaneY = 0;
            if(PlaneX == Console.WindowWidth - 1)
            {
                PlaneX = 0;
                PlaneY = 0;
            }
        }
    }
}
