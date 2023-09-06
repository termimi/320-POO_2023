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
                PlaneY++;
                Console.WriteLine(c);
            }
        }
        public void MoveRight()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(PlaneX + 1, PlaneY);
                show();
                PlaneX++;
                PlaneY =0;
                Thread.Sleep(500);
            }
        }
    }
}
