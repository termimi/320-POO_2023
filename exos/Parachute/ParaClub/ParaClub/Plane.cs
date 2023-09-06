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

            for(int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(PlaneX, PlaneY +i);
                Console.WriteLine(view[i]);
            }
        }
        public void MoveRight()
        {
            PlaneX++;
            if(PlaneX == Console.WindowWidth - 1)
            {
                PlaneX = 0;
                PlaneY = 0;
            }
        }
    }
}
